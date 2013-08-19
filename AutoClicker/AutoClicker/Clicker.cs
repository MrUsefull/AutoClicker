using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace AutoClicker
{
    class Clicker
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;
        private const uint MOUSEEVENTF_ABSOLUTE = 0x8000; 

        public bool keep_clicking = true;

        /// <summary>
        /// Clicks the mouse, holds it, then releases it. Repeatedly. 
        /// </summary>
        /// <param name="freq">How often to click the mouse</param>
        /// <param name="hold">How long to hold the mouse down</param>
        public void run(int freq, int hold)
        {
            
            while (keep_clicking)
            {
                uint X = Convert.ToUInt32(Cursor.Position.X);
                uint Y = Convert.ToUInt32(Cursor.Position.Y);
                mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
                System.Threading.Thread.Sleep(hold * 1000);
                mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                System.Threading.Thread.Sleep(freq * 1000);
            }
        }
    }
}
