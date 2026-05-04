namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public float timeElapsed = 5;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "stoped";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Math.Round(timeElapsed, 3).ToString();
            timeElapsed += timer1.Interval/1000f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
