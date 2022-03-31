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

namespace Sbor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer(Sbor.Properties.Resources.Dasha);        
        public int minDes1 = 5;
        public int minEd1 = 9;
        public int secDes1 = 5;
        public int secEd1 = 9;
        private void FormMain_Load(object sender, EventArgs e)
        {
            trDelay.Enabled = false;
            trDelay.Interval = 1000;
            minDes.Text = "0";
            minEd.Text = "0";
            secDes.Text = "0";
            secEd.Text = "0";
            lbTire.Text = ":";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            minDes.Text = "5";
            minEd.Text = "9";
            secDes.Text = "5";
            secEd.Text = "9";
            trDelay.Enabled = true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            minDes.Text = "0";
            minEd.Text = "0";
            secDes.Text = "0";
            secEd.Text = "0";
            trDelay.Enabled = false;
        }

        private void trDelay_Tick(object sender, EventArgs e)
        {
            secEd.Text = secEd1.ToString();
            secEd1 = secEd1 - 1;
            secEd.Text = secEd1.ToString();
            if (secEd1 < 0) 
            {
                secEd1 = 9;
                secDes1 = secDes1 - 1;
                secEd.Text = secEd1.ToString();
                secDes.Text = secDes1.ToString();
            }
            if (secDes1 < 0)
            {
                secDes1 = 5;
                minEd1 = minEd1 - 1;
                secDes.Text = secDes1.ToString();
                minEd.Text = minEd1.ToString();

            }
            if (minEd1 < 0)
            {
                minEd1 = 9;
                minDes1 = minDes1 - 1;
                minEd.Text = minEd1.ToString();
                minDes.Text = minDes1.ToString();
            }
            if ((minDes1 == 0) && (minEd1 == 0) && (secDes1 == 0) && (secEd1 == 0))
            {
                trDelay.Enabled = false;
                player.Play();
                minDes.Text = "0";
                minEd.Text = "0";
                secDes.Text = "0";
                secEd.Text = "0";
            }
        }
    }
}
