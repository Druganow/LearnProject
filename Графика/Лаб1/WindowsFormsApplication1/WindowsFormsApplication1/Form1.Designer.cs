namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Рисунок = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1169, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "График";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.graf_Click);
            // 
            // Рисунок
            // 
            this.Рисунок.Location = new System.Drawing.Point(1169, 75);
            this.Рисунок.Name = "Рисунок";
            this.Рисунок.Size = new System.Drawing.Size(75, 23);
            this.Рисунок.TabIndex = 1;
            this.Рисунок.Text = "Рисунок";
            this.Рисунок.UseVisualStyleBackColor = true;
            this.Рисунок.Click += new System.EventHandler(this.Picture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 709);
            this.Controls.Add(this.Рисунок);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Домашнее задание";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Рисунок;
    }
}

