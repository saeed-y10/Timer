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
            txbHours.Enabled = true;
            txbMinutes.Enabled = true;
            txbSeconds.Enabled = true;
        }

        private void EnableStartButton()
        {
            btnStart.Enabled = true;
        }

        private void DisableStartButton()
        {
            btnStart.Enabled = false;
        }


        private void EnableStopResumButton()
        {
            btnStopResum.Enabled = true;
        }

        private void DisableStopResumButton()
        {
            btnStopResum.Enabled = false;
        }

        private void DisableTxtBoxs()
        {
            txbHours.Enabled = false;
            txbMinutes.Enabled = false;
            txbSeconds.Enabled = false;
        }

        private void ResetAllDefaults()
        {
            DisableTimer();
            EnableTxtBoxs();
            EnableStartButton();
            DisableStopResumButton();

            lblDuration.Text = "0 : 0 : 0";
            txbHours.Text = "0";
            txbMinutes.Text = "00";
            txbSeconds.Text = "00";

            TotalTime = new TimeSpan(0, 0, 0);
            DurationTime = new TimeSpan(0, 0, 0);
            progressBar1.Value = 0;
        }

        private void UpdateDurationLabel()
        {
            lblDuration.Text = DurationTime.Hours.ToString() + " : " + DurationTime.Minutes.ToString() + " : " + DurationTime.Seconds.ToString();
        }

        private bool IsAllInputsAreZero()
        {
            return (Convert.ToInt32(txbHours.Text) == 0 && Convert.ToInt32(txbMinutes.Text) == 0 && Convert.ToInt32(txbSeconds.Text) == 0);
        }

        private bool IsValidInputs()
        {
            return (Convert.ToInt32(txbHours.Text) >= 0 && Convert.ToInt32(txbMinutes.Text) >= 0 && Convert.ToInt32(txbSeconds.Text) >= 0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsAllInputsAreZero())
            {
                ResetAllDefaults();
                return;
            }

            if (txbHours.MaskCompleted && txbMinutes.MaskCompleted && txbSeconds.MaskCompleted)
            {

                TotalTime = new TimeSpan(Convert.ToInt32(txbHours.Text), Convert.ToInt32(txbMinutes.Text), Convert.ToInt32(txbSeconds.Text));
                DurationTime = new TimeSpan(0, 0, 0);

                progressBar1.Maximum = Convert.ToInt32(TotalTime.TotalSeconds);

                DisableStartButton();
                DisableTxtBoxs();
                EnableStopResumButton();
                EnableTimer();
            }

            else
            {
                MessageBox.Show("invaled inputs", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DurationTime.TotalSeconds < TotalTime.TotalSeconds && progressBar1.Value < progressBar1.Maximum)
            {
                DurationTime = DurationTime.Add(new TimeSpan(0, 0, 1));
                progressBar1.Value += 1;

                UpdateDurationLabel();

                //progressBar1.Refresh();
                //lblDuration.Refresh();
            }

            else
            {
                DisableTimer();
                DisableStopResumButton();
                notifyIcon1.ShowBalloonTip(30000);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllDefaults();
        }

        private void btnStopResum_Click(object sender, EventArgs e)
        {
            

            if (btnStopResum.Text == "Stop")
            {
                btnStopResum.Text = "Resum";
                DisableTimer();
            }

            else
            {
                btnStopResum.Text = "Stop";
                EnableTimer();
            }
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {

        }


    }
}
