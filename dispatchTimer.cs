using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Personal_Organiser_Project
{
    class dispatchTimer : MainWindow
    {

        public void InitialiseClock()
        {
            DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
           // string dateFormat = "dddd, dd MMMM yyyy";

            dispatchLbl.Content = DateTime.Now.ToString("dddd, dd MMMM yyyy");

        }
    }
}
