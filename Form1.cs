using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace VP_IT_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            MessageBox.Show(dt.Date.ToString());
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            // MessageBox.Show("Original date"+dt1+"Short Date Only"+dt1.Date.ToShortDateString());
            ///MessageBox.Show(DateTime.Now.ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
               timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                SoundPlayer sp = new SoundPlayer(@"c:\Windows\Media\Alarm01.wav");
                sp.Play();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
