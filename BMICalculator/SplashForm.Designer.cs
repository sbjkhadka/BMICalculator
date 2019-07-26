namespace BMICalculator
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 500;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashLabel
            // 
            this.SplashLabel.AutoSize = true;
            this.SplashLabel.BackColor = System.Drawing.Color.Transparent;
            this.SplashLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplashLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SplashLabel.Location = new System.Drawing.Point(72, 77);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(238, 34);
            this.SplashLabel.TabIndex = 0;
            this.SplashLabel.Text = "BMI Calculator";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.DimGray;
            this.progressBar.Location = new System.Drawing.Point(78, 410);
            this.progressBar.Maximum = 60;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(136, 23);
            this.progressBar.TabIndex = 1;
            this.progressBar.UseWaitCursor = true;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.SplashLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "SplashForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label SplashLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}