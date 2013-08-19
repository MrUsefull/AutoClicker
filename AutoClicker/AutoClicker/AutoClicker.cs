using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AutoClicker
{


    public partial class AutoClicker : Form
    {

        private Clicker clicker;
        private Thread click_thread;
        
        public AutoClicker()
        {
            InitializeComponent();
            clicker = new Clicker();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (click_thread != null && click_thread.IsAlive)
            {
                return;
            }
            int freq = int.Parse(this.frequency.Text);
            int hold = int.Parse(this.hold.Text);
            click_thread = new Thread(() => clicker.run(freq, hold) );
            click_thread.Start();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            clicker.keep_clicking = false;
            click_thread.Abort();
            click_thread.Join();
        }
    }
}
