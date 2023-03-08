using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {

        private static readonly Stopwatch watch = new Stopwatch();
        public Form2()
        {
            InitializeComponent();

            UpdateTime();
        }

        private void UpdateTime()
        {
            label1.Text = GetTimeString(watch.Elapsed);

        }

        private string GetTimeString(TimeSpan elapsed)
        {
            string result = string.Empty;
            result = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                elapsed.Hours,
                elapsed.Minutes,
                elapsed.Seconds,
                elapsed.Milliseconds);

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "START")
            {
                watch.Start();
                button1.Text = "PAUSE";
                timer1.Enabled = true;

            }
            else
            {
                watch.Stop();
                button1.Text = "START";
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            watch.Reset();
            timer1.Enabled = false;
            UpdateTime();
            button1.Text = "START";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
