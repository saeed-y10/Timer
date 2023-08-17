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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDuration = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbDone = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStopResume = new System.Windows.Forms.Button();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCompletePercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Crimson;
            this.lblDuration.Location = new System.Drawing.Point(12, 19);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(520, 72);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "0 : 0 : 0";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 147);
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
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Timer Complete";
            this.notifyIcon1.Visible = true;
            // 
            // pbDone
            // 
            this.pbDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDone.Image = ((System.Drawing.Image)(resources.GetObject("pbDone.Image")));
            this.pbDone.Location = new System.Drawing.Point(23, 19);
            this.pbDone.Name = "pbDone";
            this.pbDone.Size = new System.Drawing.Size(92, 72);
            this.pbDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDone.TabIndex = 14;
            this.pbDone.TabStop = false;
            this.pbDone.Tag = "Done";
            this.pbDone.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Image = global::Timer.Properties.Resources.Start;
            this.btnStart.Location = new System.Drawing.Point(12, 283);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 70);
            this.btnStart.TabIndex = 3;
            this.btnStart.Tag = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = global::Timer.Properties.Resources.Restart;
            this.btnReset.Location = new System.Drawing.Point(440, 283);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 70);
            this.btnReset.TabIndex = 5;
            this.btnReset.Tag = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStopResume
            // 
            this.btnStopResume.AutoSize = true;
            this.btnStopResume.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStopResume.Enabled = false;
            this.btnStopResume.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStopResume.FlatAppearance.BorderSize = 0;
            this.btnStopResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopResume.ForeColor = System.Drawing.Color.Black;
            this.btnStopResume.Image = global::Timer.Properties.Resources.Stop;
            this.btnStopResume.Location = new System.Drawing.Point(226, 283);
            this.btnStopResume.Name = "btnStopResume";
            this.btnStopResume.Size = new System.Drawing.Size(70, 70);
            this.btnStopResume.TabIndex = 4;
            this.btnStopResume.TabStop = false;
            this.btnStopResume.Tag = "Stop";
            this.btnStopResume.UseVisualStyleBackColor = false;
            this.btnStopResume.Click += new System.EventHandler(this.btnStopResume_Click);
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(12, 242);
            this.numHours.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(92, 22);
            this.numHours.TabIndex = 0;
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(226, 242);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(92, 22);
            this.numMinutes.TabIndex = 1;
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(440, 238);
            this.numSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(92, 22);
            this.numSeconds.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCompletePercentage
            // 
            this.lblCompletePercentage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletePercentage.Location = new System.Drawing.Point(218, 91);
            this.lblCompletePercentage.Name = "lblCompletePercentage";
            this.lblCompletePercentage.Size = new System.Drawing.Size(100, 47);
            this.lblCompletePercentage.TabIndex = 15;
            this.lblCompletePercentage.Text = "0%";
            this.lblCompletePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 376);
            this.Controls.Add(this.lblCompletePercentage);
            this.Controls.Add(this.numSeconds);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.numHours);
            this.Controls.Add(this.btnStopResume);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbDone);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pbDone;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStopResume;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCompletePercentage;
    }
}

