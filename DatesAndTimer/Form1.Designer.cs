namespace DatesAndTimer
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            lblDayOfWeek = new Label();
            lblTime = new Label();
            lblMonth = new Label();
            lblDayNumberOfMonth = new Label();
            lblYear = new Label();
            timTime = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(130, 235);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Location = new Point(136, 104);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(69, 15);
            lblDayOfWeek.TabIndex = 1;
            lblDayOfWeek.Text = "DayOfWeek";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(136, 141);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(33, 15);
            lblTime.TabIndex = 2;
            lblTime.Text = "Time";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(281, 101);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(43, 15);
            lblMonth.TabIndex = 3;
            lblMonth.Text = "Month";
            // 
            // lblDayNumberOfMonth
            // 
            lblDayNumberOfMonth.AutoSize = true;
            lblDayNumberOfMonth.Location = new Point(282, 141);
            lblDayNumberOfMonth.Name = "lblDayNumberOfMonth";
            lblDayNumberOfMonth.Size = new Size(120, 15);
            lblDayNumberOfMonth.TabIndex = 4;
            lblDayNumberOfMonth.Text = "DayNumberOfMonth";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(284, 180);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 5;
            lblYear.Text = "Year";
            // 
            // timTime
            // 
            timTime.Interval = 1000;
            timTime.Tick += timTime_Tick;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 292);
            Controls.Add(lblYear);
            Controls.Add(lblDayNumberOfMonth);
            Controls.Add(lblMonth);
            Controls.Add(lblTime);
            Controls.Add(lblDayOfWeek);
            Controls.Add(btnStart);
            Name = "frmMainForm";
            Text = "Dates and Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label lblDayOfWeek;
        private Label lblTime;
        private Label lblMonth;
        private Label lblDayNumberOfMonth;
        private Label lblYear;
        private System.Windows.Forms.Timer timTime;
    }
}
