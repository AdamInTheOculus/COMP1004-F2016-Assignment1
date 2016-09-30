namespace COMP1004_F2016_Assignment1
{
    partial class MailSplashScreen
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
            this.MainTextSplashLabel = new System.Windows.Forms.Label();
            this.MainSplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MainTextSplashLabel
            // 
            this.MainTextSplashLabel.AutoSize = true;
            this.MainTextSplashLabel.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextSplashLabel.Location = new System.Drawing.Point(-3, 129);
            this.MainTextSplashLabel.Name = "MainTextSplashLabel";
            this.MainTextSplashLabel.Size = new System.Drawing.Size(752, 79);
            this.MainTextSplashLabel.TabIndex = 0;
            this.MainTextSplashLabel.Text = "Sinclair Solution\'s Project";
            // 
            // MainSplashScreenTimer
            // 
            this.MainSplashScreenTimer.Enabled = true;
            this.MainSplashScreenTimer.Interval = 3000;
            this.MainSplashScreenTimer.Tick += new System.EventHandler(this.MainSplashScreenTimer_Tick);
            // 
            // MailSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.MainTextSplashLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailSplashScreen";
            this.Load += new System.EventHandler(this.MailSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTextSplashLabel;
        private System.Windows.Forms.Timer MainSplashScreenTimer;
    }
}