using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;
using static ModelGry.Ruch;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;
        private CountTime countTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {

            gameBox.Visible = false;
            finishBox.Visible = false;
            groupBoxLosowanie.Visible = true;
        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            // try-catch
            int zakresOd = int.Parse( textBoxZakresOd.Text );
            int zakresDo = int.Parse(textBoxZakresDo.Text);
            ResetGame();
            gameBox.Visible = true;
            g = new Gra( zakresOd, zakresDo );
            countTime = new CountTime();
            countTime.startWatch(OnTimerTick);
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            var time = DateTime.Now - countTime.now;
            var timeString = time.ToString();
            timeLabel.Text = timeString.Substring(0, timeString.Length - 5);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            countTime.stopWatch();
            finishBox.Visible = true;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            var resp = g.Ocena(Int32.Parse(pickedNumber.Text));
            if (resp == Odp.Trafiono)
            {
                response.Text = "Trafiłeś";
                finishBox.Visible = true;
                countTime.stopWatch();
                endTimeLabel.Text = "Całkowity czas gry: " + countTime.countedTime.ToString();
                NumberOfTurnsLabel.Text = "Liczba ruchów: " + g.getHistoria().Count.ToString();
                randomNumberLabel.Text = "Wylosowana: " + g.CoByloWylosowane().ToString();
            }
            else if (resp == Odp.ZaDuzo)
                response.Text = "Za Dużo";
            else
                response.Text = "Za Mało";  
        }

        private void ResetGame()
        {
            if (countTime != null)
            {
                countTime.stopWatch();
            }
            response.Text = "";
            finishBox.Visible = false;
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(g.getHistoria());
            historyForm.ShowDialog();
        }
    }
}
