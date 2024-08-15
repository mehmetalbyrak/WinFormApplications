namespace StopWatch
{
    partial class frmMainForm
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
            btnStart = new Button();
            btnStop = new Button();
            btnExit = new Button();
            lblStart = new Label();
            lblEnd = new Label();
            label3 = new Label();
            lblElapsed = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            txtElapsed = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(167, 89);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(167, 148);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 1;
            btnStop.Text = "S&top";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(167, 208);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(391, 93);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(60, 15);
            lblStart.TabIndex = 3;
            lblStart.Text = "Start Time";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(395, 152);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(56, 15);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "End Time";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // lblElapsed
            // 
            lblElapsed.AutoSize = true;
            lblElapsed.Location = new Point(326, 208);
            lblElapsed.Name = "lblElapsed";
            lblElapsed.Size = new Size(136, 15);
            lblElapsed.TabIndex = 5;
            lblElapsed.Text = "Elapsed Time in Seconds";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(468, 89);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(137, 23);
            txtStart.TabIndex = 6;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(468, 140);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(137, 23);
            txtEnd.TabIndex = 7;
            // 
            // txtElapsed
            // 
            txtElapsed.Location = new Point(468, 200);
            txtElapsed.Name = "txtElapsed";
            txtElapsed.Size = new Size(137, 23);
            txtElapsed.TabIndex = 8;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 310);
            Controls.Add(txtElapsed);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(lblElapsed);
            Controls.Add(label3);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(btnExit);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "frmMainForm";
            Text = "StopWatch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Button btnExit;
        private Label lblStart;
        private Label lblEnd;
        private Label label3;
        private Label lblElapsed;
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtElapsed;
    }
}
