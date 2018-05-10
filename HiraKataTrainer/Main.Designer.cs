namespace HiraKataTrainer
{
    partial class Main
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("Arial", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(12, 53);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(773, 353);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(12, 428);
            this.InputTextBox.MaxLength = 6;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(773, 48);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.TabStop = false;
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 12);
            this.ProgressBar.Minimum = 1;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(773, 23);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.Value = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 501);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.InputTextBox);
            this.MaximumSize = new System.Drawing.Size(813, 540);
            this.MinimumSize = new System.Drawing.Size(813, 540);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiraKataTrainer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}