namespace Pr2
{
    partial class Form1
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
            this.Отобразить = new System.Windows.Forms.Button();
            this.Выход = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Отобразить
            // 
            this.Отобразить.Location = new System.Drawing.Point(27, 385);
            this.Отобразить.Name = "Отобразить";
            this.Отобразить.Size = new System.Drawing.Size(191, 47);
            this.Отобразить.TabIndex = 0;
            this.Отобразить.Text = "Отобразить";
            this.Отобразить.UseVisualStyleBackColor = true;
            // 
            // Выход
            // 
            this.Выход.Location = new System.Drawing.Point(564, 384);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(205, 47);
            this.Выход.TabIndex = 1;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(742, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.Отобразить);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Отобразить;
        private System.Windows.Forms.Button Выход;
        private System.Windows.Forms.TextBox textBox1;
    }
}

