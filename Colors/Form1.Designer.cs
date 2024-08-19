namespace Colors
{
    partial class frmMain
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
            txtColors = new TextBox();
            SuspendLayout();
            // 
            // txtColors
            // 
            txtColors.Location = new Point(55, 12);
            txtColors.Multiline = true;
            txtColors.Name = "txtColors";
            txtColors.ScrollBars = ScrollBars.Vertical;
            txtColors.Size = new Size(678, 279);
            txtColors.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtColors);
            Name = "frmMain";
            Text = "Colors - OOP Approach";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtColors;
    }
}
