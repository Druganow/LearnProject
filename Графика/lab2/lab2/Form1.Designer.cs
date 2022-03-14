namespace lab2
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
            this.WyborGraf = new System.Windows.Forms.ComboBox();
            this.ParamA = new System.Windows.Forms.TextBox();
            this.ParamB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ParamK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Нарисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WyborGraf
            // 
            this.WyborGraf.FormattingEnabled = true;
            this.WyborGraf.Items.AddRange(new object[] {
            "Улитка Паскаля",
            "Конхоида Никомеда",
            "Эпициклоида",
            "Астроида",
            "Циссоида",
            "Строфоида",
            "Циклоида",
            "Удлиненная и укороченная циклоида",
            "Удлиненная гипоциклоида",
            "Укороченная гипоциклоида",
            "Архимедова спираль",
            "Логарифмическая спираль",
            "Эвольвента окружности",
            "Лемниската Бернулли"});
            this.WyborGraf.Location = new System.Drawing.Point(709, 33);
            this.WyborGraf.Name = "WyborGraf";
            this.WyborGraf.Size = new System.Drawing.Size(121, 21);
            this.WyborGraf.TabIndex = 1;
            // 
            // ParamA
            // 
            this.ParamA.Location = new System.Drawing.Point(729, 60);
            this.ParamA.Name = "ParamA";
            this.ParamA.Size = new System.Drawing.Size(101, 20);
            this.ParamA.TabIndex = 2;
            this.ParamA.Text = "1";
            // 
            // ParamB
            // 
            this.ParamB.Location = new System.Drawing.Point(729, 86);
            this.ParamB.Name = "ParamB";
            this.ParamB.Size = new System.Drawing.Size(101, 20);
            this.ParamB.TabIndex = 3;
            this.ParamB.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "График функции";
            // 
            // ParamK
            // 
            this.ParamK.Location = new System.Drawing.Point(729, 112);
            this.ParamK.Name = "ParamK";
            this.ParamK.Size = new System.Drawing.Size(100, 20);
            this.ParamK.TabIndex = 7;
            this.ParamK.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "K:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(781, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 532);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ParamK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParamB);
            this.Controls.Add(this.ParamA);
            this.Controls.Add(this.WyborGraf);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox WyborGraf;
        private System.Windows.Forms.TextBox ParamA;
        private System.Windows.Forms.TextBox ParamB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ParamK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

