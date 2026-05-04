namespace WinFormsApp1
{
    partial class StopwatchForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonStart = new Button();
            buttonStop = new Button();
            buttonReset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.ForestGreen;
            buttonStart.Location = new Point(302, 207);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(191, 41);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.IndianRed;
            buttonStop.Location = new Point(302, 252);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(191, 41);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "stop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Cornsilk;
            buttonReset.Location = new Point(302, 299);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(191, 41);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(320, 142);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(155, 38);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "00:00:00.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timeLabel);
            Controls.Add(buttonReset);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Stopwatch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private Button buttonReset;
        private System.Windows.Forms.Timer timer1;
        private Label timeLabel;
    }
}
