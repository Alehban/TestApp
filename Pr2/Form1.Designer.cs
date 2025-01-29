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
            this.Отобразить.Location = new System.Drawing.Point(36, 474);
            this.Отобразить.Margin = new System.Windows.Forms.Padding(4);
            this.Отобразить.Name = "Отобразить";
            this.Отобразить.Size = new System.Drawing.Size(255, 58);
            this.Отобразить.TabIndex = 0;
            this.Отобразить.Text = "Отобразить";
            this.Отобразить.UseVisualStyleBackColor = true;
            this.Отобразить.Click += new System.EventHandler(this.Отобразить_Click);
            // 
            // Выход
            // 
            this.Выход.Location = new System.Drawing.Point(752, 473);
            this.Выход.Margin = new System.Windows.Forms.Padding(4);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(273, 58);
            this.Выход.TabIndex = 1;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = true;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(988, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.Отобразить);
            this.Margin = new System.Windows.Forms.Padding(4);
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

