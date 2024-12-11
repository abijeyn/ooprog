using System;
using System.Windows.Forms;

namespace Dental
{
    public partial class PatientRecord : UserControl
    {
        private Timer _timer; 

        public PatientRecord()
        {
            InitializeComponent();
            InitializeTimer(); 
        }

        private void InitializeTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1000; 
            _timer.Tick += Timer_Tick;
            _timer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void PatientRecord_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToShortDateString();
        }

      
    }
}
