using ModelGry;
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
    public partial class HistoryForm : Form
    {
        public HistoryForm(List<Ruch> history)
        {
            InitializeComponent();
            var i = 0;
            foreach (var ruch in history)
            {
                historyGridView.Rows.Add();
                historyGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
                historyGridView.Rows[i].Cells[1].Value = ruch.Propozycja;
                historyGridView.Rows[i].Cells[2].Value = ruch.Odpowiedz;
                historyGridView.Rows[i].Cells[3].Value = ruch.Kiedy;
                i++;
            }
        }

        private void HistoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
