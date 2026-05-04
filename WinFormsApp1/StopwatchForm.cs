using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class StopwatchForm : Form
    {
        //Stopwatch using IStopwatch interface
        private IStopwatch stopwatch;
        //Constructor
        public StopwatchForm()
        {
            InitializeComponent();
            //Create App Stopwatch instance
            stopwatch = new AppStopwatch();
        }
        //Event when start button is clicked
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Start the stopwatch
            stopwatch.Start();
            //Start the timer to update the label with the elapsed time
            timer1.Start();
        }
        //Event when stop button is clicked
        private void buttonStop_Click(object sender, EventArgs e)
        {
            //Stop the stopwatch
            stopwatch.Stop();
            //Stop the timer as updating the label is not needed when the stopwatch is stopped
            timer1.Stop();
        }
        //Event when reset button is clicked
        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Reset the stopwatch
            stopwatch.Reset();
            //Stop the timer as updating the label is not needed when the stopwatch is reset
            timer1.Stop();
            //Text is reset to 0
            timeLabel.Text = "00:00:00.00";
        }

        //Timer tick event to update the time label, does not count the stopwatch time
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }


    }
}
