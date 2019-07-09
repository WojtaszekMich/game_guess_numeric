using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GraGUI
{
    public class CountTime
    {
        public System.Timers.Timer aTimer;
        public TimeSpan countedTime;
        public DateTime now;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public void startWatch(EventHandler func)
        {
            
            now = DateTime.Now;
            timer.Tick += func;
            timer.Tick += OnTimerTick;
            timer.Interval = 5;
            timer.Start();

        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            countedTime = DateTime.Now - now;
        }


        public void stopWatch()
        {
            timer.Stop();
        }

    }
}
