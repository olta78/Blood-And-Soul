namespace Rudokop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timerDelay.Interval = 2000;
            labelText.Text = "Õ¿∆Ã»“≈ —“¿–“";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelText.ForeColor = Color.Green;
            labelText.Text = "– ¿ ¡ Œ “ ¿ ≈ Ã...";
            timerDelay.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            labelText.ForeColor = Color.Red;
            labelText.Text = "Œ “ ƒ € ’ ¿ ≈ Ã...";
            timerDelay.Enabled = false;
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Delay = rnd.Next(7000, 10000);
            timerDelay.Interval = Delay;
            MessageBox.Show(Delay.ToString());
        }
    }
}