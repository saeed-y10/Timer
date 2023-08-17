using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private TimeSpan TotalTime;
        private TimeSpan DurationTime;

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Allert";
            notifyIcon1.BalloonTipText = "Timer complete";
        }

        private void ShowDoneImage()
        {
                pbDone.Visible = true;
        }

        private void HideDoneImage()
        {
            pbDone.Visible = false;
        }

        private void EnableTimer()
        {
            timer1.Enabled = true;
        }

        private void DisableTimer()
        {
            timer1.Enabled = false;
        }

        private void EnableTxtBoxs()
        {
            numHours.Enabled = true;
            numHours.TabStop = true;
            
            numMinutes.Enabled = true;
            numMinutes.TabStop = true;
            
            numSeconds.Enabled = true; 
            numSeconds.TabStop = true;
        }

        private void EnableStartButton()
        {
            btnStart.Enabled = true;
            btnStart.TabStop = true;
        }

        private void DisableStartButton()
        {
            btnStart.Enabled = false;
            btnStart.TabStop = false;
        }

        private void EnableStopResumeButton()
        {
            btnStopResume.Enabled = true;
            btnStopResume.TabStop = true;
            btnStopResume.Image = Properties.Resources.Stop;
        }

        private void DisableStopResumeButton()
        {
            btnStopResume.Enabled = false; 
            btnStopResume.TabStop = false;
        }

        private void ResetStopResumeButton()
        {
            btnStopResume.Enabled = false;
            btnStopResume.TabStop = false;
            btnStopResume.Tag = "Stop";
            btnStopResume.Image = Properties.Resources.Stop;
        }

        private void DisableNumBoxs()
        {
            numHours.Enabled = false;
            numHours.TabStop = false;

            numMinutes.Enabled = false;
            numMinutes.TabStop = false;

            numSeconds.Enabled = false;
            numSeconds.TabStop = false;
        }

        private void ResetAllDefaults()
        {
            HideDoneImage();
            DisableTimer();
            EnableTxtBoxs();
            EnableStartButton();
            ResetStopResumeButton();

            lblCompletePercentage.Text = "0%";
            lblDuration.Text = "0 : 0 : 0";

            numHours.Value = 0;
            numMinutes.Value = 0;
            numSeconds.Value = 0;

            TotalTime = new TimeSpan(0, 0, 0);
            DurationTime = new TimeSpan(0, 0, 0);
            progressBar1.Value = 0;
        }

        private string GetCompletePercentage()
        {
            if (TotalTime.TotalSeconds <= 0)
                return "0%";

            return ((int)(DurationTime.TotalSeconds / TotalTime.TotalSeconds * 100)).ToString() + "%";
        }

        private void UpdateCompletePercentage()
        {
            lblCompletePercentage.Text = GetCompletePercentage();
        }

        private void UpdateDurationLabel()
        {
            lblDuration.Text = DurationTime.Hours.ToString() + " : " + DurationTime.Minutes.ToString() + " : " + DurationTime.Seconds.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DurationTime.TotalSeconds < TotalTime.TotalSeconds && progressBar1.Value < progressBar1.Maximum)
            {
                DurationTime = DurationTime.Add(new TimeSpan(0, 0, 1));
                progressBar1.Value += 1;

                UpdateDurationLabel();
                UpdateCompletePercentage();
            }

            else
            {
                DisableTimer();
                DisableStopResumeButton();
                ShowDoneImage();
                notifyIcon1.ShowBalloonTip(30000);
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (numHours.Value == 0 && numMinutes.Value == 0 && numSeconds.Value == 0)
            {
                ResetAllDefaults();
                return;
            }
         
            TotalTime = new TimeSpan((int)numHours.Value, (int)numMinutes.Value, (int)numSeconds.Value);
            DurationTime = new TimeSpan(0, 0, 0);

            progressBar1.Maximum = Convert.ToInt32(TotalTime.TotalSeconds);

            DisableStartButton();
            DisableNumBoxs();
            EnableStopResumeButton();
            EnableTimer();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllDefaults();
        }

        private void btnStopResume_Click(object sender, EventArgs e)
        {
            if (btnStopResume.Tag.ToString() == "Stop")
            {
                btnStopResume.Tag = "Pause";
                btnStopResume.Image = Properties.Resources.Pause;
                DisableTimer();
            }

            else
            {
                btnStopResume.Tag = "Stop";
                btnStopResume.Image = Properties.Resources.Stop;
                EnableTimer();
            }
        }

    }
}
