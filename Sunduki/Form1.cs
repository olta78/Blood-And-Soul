using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sunduki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        const uint WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x101;


        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите кнопку 'START', наведи курсор на окно игры. Псоле того как персонаж начнет рыть руду, окно игры можно свернуть. Приятной игры и удачного фарма ;)", "П о м о щ ь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            timer1.Interval = 3000;
            timer1.Enabled = true;
            //MessageBox.Show("ХЭНДЛ окна: " + Hwnd, "Handle window");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr Hwnd = GetForegroundWindow();
            PostMessage(Hwnd, WM_KEYDOWN, (IntPtr)(int)Keys.F1, (IntPtr)0);
            Thread.Sleep(400);
            PostMessage(Hwnd, WM_KEYUP, (IntPtr)(int)Keys.F1, (IntPtr)0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
