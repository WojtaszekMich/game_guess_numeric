using GraGUI.Ai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraGUI
{
    public partial class ComputerForm : Form
    {
        private AiGame aiGame;
        private CountTime countTime;
        public ComputerForm()
        {
            InitializeComponent();
            aiGame = new AiGame(null, null);
            rangeLabel.Text = "Wybrany Zakres: " + aiGame.GetStartingNumber().ToString() + " - " + aiGame.GetEndingNumber().ToString();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PickNumberBtn_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(pickedNumberInp.Text) < aiGame.GetStartingNumber() || Int32.Parse(pickedNumberInp.Text) > aiGame.GetEndingNumber())
                MessageBox.Show("Prosze wybrać numer z zakresu");
            else
            {
                gameBox.Visible = true;
                PickNumberBtn.Enabled = false;
                countTime = new CountTime();
                countTime.startWatch(OnTimerTick);
                aiGame.PickedNumber = Int32.Parse(pickedNumberInp.Text);
                pickedNumberLabel.Text = aiGame.PickFirstNumber().Value.ToString();
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            var time = DateTime.Now - countTime.now;
            var timeString = time.ToString();
            timeLabel.Text = timeString.Substring(0, timeString.Length - 5);
        }

        private void TooSmallBtn_Click(object sender, EventArgs e)
        {
            if (aiGame.CheckIfSmallerNumber())
            {
                pickedNumberLabel.Text = aiGame.PickNumber(true).Value.ToString();
            } else
            {
                MessageBox.Show("Nie Oszukuj");
            }
            
        }

        private void WinBtn_Click(object sender, EventArgs e)
        {
            pickedNumberLabel.Text = "Komputer Wygrał";
            countTime.stopWatch();
            finishBox.Visible = true;
            finishTimeLabel.Text = "Czas: " + countTime.countedTime.ToString();
            finishPickedNr.Text = "Wybrany Numer: " + aiGame.GetLastPickedNumber().ToString();
            finishNrOftimes.Text = "Ilość Ruchów: " + aiGame.History.Count.ToString();
            aiGame.WinGame();
        }

        private void ToBigBtn_Click(object sender, EventArgs e)
        {

            if (aiGame.CheckIfBiggerNumber())
            {
                pickedNumberLabel.Text = aiGame.PickNumber(false).Value.ToString();
            } else
            {
                MessageBox.Show("Nie Oszukuj");
            }
}

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(aiGame.History);
            historyForm.ShowDialog();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            aiGame = new AiGame(null, null);
            countTime.stopWatch();
            gameBox.Visible = false;
            finishBox.Visible = false;
            rangeLabel.Text = "Wybrany Zakres: " + aiGame.GetStartingNumber().ToString() + " - " + aiGame.GetEndingNumber().ToString();
            PickNumberBtn.Enabled = true;
        }
    }
}
