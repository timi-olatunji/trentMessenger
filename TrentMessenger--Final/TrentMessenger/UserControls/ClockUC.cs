using System;
using System.Windows.Forms;

namespace Trentmessenger
{
    public partial class ucClock : UserControl
    {
        public Label dateLB;
        public Label timeLB;

        public ucClock()
        {
            InitializeComponent();

            dateLB = label_date;
            timeLB = label_time;

            dateLB.Text = DateTime.Now.ToShortDateString();
            timeLB.Text = DateTime.Now.ToLongTimeString();
            timer_clock.Start();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            dateLB.Text = DateTime.Now.ToShortDateString();
            timeLB.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
