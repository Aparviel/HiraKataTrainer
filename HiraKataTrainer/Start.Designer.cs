namespace HiraKataTrainer
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Katakana_Button = new System.Windows.Forms.Button();
            this.Hiragana_Button = new System.Windows.Forms.Button();
            this.FocusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Katakana_Button
            // 
            this.Katakana_Button.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Katakana_Button.Location = new System.Drawing.Point(12, 12);
            this.Katakana_Button.Name = "Katakana_Button";
            this.Katakana_Button.Size = new System.Drawing.Size(180, 104);
            this.Katakana_Button.TabIndex = 0;
            this.Katakana_Button.TabStop = false;
            this.Katakana_Button.Text = "Katakana";
            this.Katakana_Button.UseVisualStyleBackColor = true;
            this.Katakana_Button.Click += new System.EventHandler(this.Katakana_Button_Click);
            // 
            // Hiragana_Button
            // 
            this.Hiragana_Button.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hiragana_Button.Location = new System.Drawing.Point(200, 11);
            this.Hiragana_Button.Name = "Hiragana_Button";
            this.Hiragana_Button.Size = new System.Drawing.Size(180, 104);
            this.Hiragana_Button.TabIndex = 1;
            this.Hiragana_Button.TabStop = false;
            this.Hiragana_Button.Text = "Hiragana";
            this.Hiragana_Button.UseVisualStyleBackColor = true;
            this.Hiragana_Button.Click += new System.EventHandler(this.Hiragana_Button_Click);
            // 
            // FocusLabel
            // 
            this.FocusLabel.AutoSize = true;
            this.FocusLabel.Location = new System.Drawing.Point(293, 73);
            this.FocusLabel.Name = "FocusLabel";
            this.FocusLabel.Size = new System.Drawing.Size(0, 13);
            this.FocusLabel.TabIndex = 2;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 127);
            this.Controls.Add(this.FocusLabel);
            this.Controls.Add(this.Hiragana_Button);
            this.Controls.Add(this.Katakana_Button);
            this.MaximumSize = new System.Drawing.Size(408, 166);
            this.MinimumSize = new System.Drawing.Size(408, 166);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiraKataTrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Katakana_Button;
        private System.Windows.Forms.Button Hiragana_Button;
        private System.Windows.Forms.Label FocusLabel;
    }
}

