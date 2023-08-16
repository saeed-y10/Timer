namespace Timer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbHours = new System.Windows.Forms.MaskedTextBox();
            this.txbMinutes = new System.Windows.Forms.MaskedTextBox();
            this.txbSeconds = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStopResum = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDuration = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txbHours
            // 
            this.txbHours.BeepOnError = true;
            this.txbHours.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic);
            this.txbHours.Location = new System.Drawing.Point(12, 238);
            this.txbHours.Mask = "0";
            this.txbHours.Name = "txbHours";
            this.txbHours.Size = new System.Drawing.Size(92, 26);
            this.txbHours.TabIndex = 0;
            this.txbHours.Text = "0";
            // 
            // txbMinutes
            // 
            this.txbMinutes.AllowPromptAsInput = false;
            this.txbMinutes.BeepOnError = true;
            this.txbMinutes.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMinutes.Location = new System.Drawing.Point(226, 238);
            this.txbMinutes.Mask = "00";
            this.txbMinutes.Name = "txbMinutes";
            this.txbMinutes.Size = new System.Drawing.Size(92, 26);
            this.txbMinutes.TabIndex = 1;
            this.txbMinutes.Text = "00";
            this.txbMinutes.ValidatingType = typeof(int);
            // 
            // txbSeconds
            // 
            this.txbSeconds.AllowPromptAsInput = false;
            this.txbSeconds.BeepOnError = true;
            this.txbSeconds.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeconds.Location = new System.Drawing.Point(440, 238);
            this.txbSeconds.Mask = "00";
            this.txbSeconds.Name = "txbSeconds";
            this.txbSeconds.Size = new System.Drawing.Size(92, 26);
            this.txbSeconds.TabIndex = 2;
            this.txbSeconds.Text = "00";
            this.txbSeconds.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(221, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(12, 303);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 37);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStopResum
            // 
            this.btnStopResum.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold);
            this.btnStopResum.Location = new System.Drawing.Point(226, 303);
            this.btnStopResum.Name = "btnStopResum";
            this.btnStopResum.Size = new System.Drawing.Size(92, 37);
            this.btnStopResum.TabIndex = 7;
            this.btnStopResum.Text = "Stop";
            this.btnStopResum.UseVisualStyleBackColor = true;
            this.btnStopResum.Click += new System.EventHandler(this.btnStopResum_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(440, 303);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 37);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Crimson;
            this.lblDuration.Location = new System.Drawing.Point(12, 35);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(520, 72);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "0 : 0 : 0";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 147);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(520, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Timer Complete";
            this.notifyIcon1.BalloonTipTitle = "Allert";
            this.notifyIcon1.Text = "Timer Complete";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 376);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStopResum);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSeconds);
            this.Controls.Add(this.txbMinutes);
            this.Controls.Add(this.txbHours);
            this.Name = "MainForm";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txbHours;
        private System.Windows.Forms.MaskedTextBox txbMinutes;
        private System.Windows.Forms.MaskedTextBox txbSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStopResum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

