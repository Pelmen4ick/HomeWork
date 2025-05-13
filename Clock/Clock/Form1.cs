using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        private DateTime startTime, pauseTime;
        private TimeSpan pauseSpan;

        private void Form1_Resize(object sender, EventArgs e)
        {
            Text = WindowState == FormWindowState.Minimized ? label1.Text : "Clock"; 
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                checkBox1.Checked = !checkBox1.Checked;
            }
            else
            {
                if (!button1.Enabled)
                {
                    return;
                }
                if (e.Button == MouseButtons.Left)
                {
                    button1_Click(this, null);
                }
                else
                {
                    if(e.Button == MouseButtons.Right)
                    {
                        button2_Click(this, null);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                pauseSpan += DateTime.Now - pauseTime;
            }
            else
            {
                pauseTime = DateTime.Now;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pauseTime = startTime;
            pauseSpan = TimeSpan.Zero;
            label1.Text = "Timer: 0:0"; 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TimeSpan s = DateTime.Now - startTime - pauseSpan;
                label1.Text = string.Format("Timer: {0}:{1}: ", s.Minutes*60+s.Seconds, s.Milliseconds / 100);
            }
            else
            {
                label1.Text = DateTime.Now.ToLongTimeString();
                Text = WindowState == FormWindowState.Minimized ? label1.Text : "Clock";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                startTime = DateTime.Now;
                pauseSpan = TimeSpan.Zero;
                timer1.Interval = 100;
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                timer1.Interval = 1000;
                timer1_Tick(this, null);
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
