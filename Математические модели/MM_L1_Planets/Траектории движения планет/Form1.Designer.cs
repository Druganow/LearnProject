namespace WindowsFormsApplication
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
            this.ResButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.T_MAXtextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dTtextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PY3textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PY2textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PY1textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PX3textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PX2textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PX1textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Y3textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Y2textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Y1textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.X3textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.X2textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.X1textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.M3textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.M2textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.M1textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResButton
            // 
            this.ResButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResButton.Location = new System.Drawing.Point(585, 454);
            this.ResButton.Name = "ResButton";
            this.ResButton.Size = new System.Drawing.Size(167, 49);
            this.ResButton.TabIndex = 2;
            this.ResButton.Text = "ПОСТРОИТЬ ТРАЕКТОРИИ";
            this.ResButton.UseVisualStyleBackColor = true;
            this.ResButton.Click += new System.EventHandler(this.ResButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(159, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 507);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.ResButton);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 507);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 507);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.T_MAXtextBox);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.dTtextBox);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.PY3textBox);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.PY2textBox);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.PY1textBox);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.PX3textBox);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.PX2textBox);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.PX1textBox);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.Y3textBox);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.Y2textBox);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.Y1textBox);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.X3textBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.X2textBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.X1textBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.M3textBox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.M2textBox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.M1textBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 507);
            this.panel5.TabIndex = 3;
            // 
            // T_MAXtextBox
            // 
            this.T_MAXtextBox.Location = new System.Drawing.Point(53, 427);
            this.T_MAXtextBox.Name = "T_MAXtextBox";
            this.T_MAXtextBox.Size = new System.Drawing.Size(100, 20);
            this.T_MAXtextBox.TabIndex = 33;
            this.T_MAXtextBox.Text = "500";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "t max";
            // 
            // dTtextBox
            // 
            this.dTtextBox.Location = new System.Drawing.Point(53, 401);
            this.dTtextBox.Name = "dTtextBox";
            this.dTtextBox.Size = new System.Drawing.Size(100, 20);
            this.dTtextBox.TabIndex = 31;
            this.dTtextBox.Text = "0.5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 404);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "dt";
            // 
            // PY3textBox
            // 
            this.PY3textBox.Location = new System.Drawing.Point(53, 372);
            this.PY3textBox.Name = "PY3textBox";
            this.PY3textBox.Size = new System.Drawing.Size(100, 20);
            this.PY3textBox.TabIndex = 29;
            this.PY3textBox.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "`y3";
            // 
            // PY2textBox
            // 
            this.PY2textBox.Location = new System.Drawing.Point(53, 346);
            this.PY2textBox.Name = "PY2textBox";
            this.PY2textBox.Size = new System.Drawing.Size(100, 20);
            this.PY2textBox.TabIndex = 27;
            this.PY2textBox.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "`y2";
            // 
            // PY1textBox
            // 
            this.PY1textBox.Location = new System.Drawing.Point(53, 320);
            this.PY1textBox.Name = "PY1textBox";
            this.PY1textBox.Size = new System.Drawing.Size(100, 20);
            this.PY1textBox.TabIndex = 25;
            this.PY1textBox.Text = "2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "`y1";
            // 
            // PX3textBox
            // 
            this.PX3textBox.Location = new System.Drawing.Point(53, 294);
            this.PX3textBox.Name = "PX3textBox";
            this.PX3textBox.Size = new System.Drawing.Size(100, 20);
            this.PX3textBox.TabIndex = 23;
            this.PX3textBox.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "`x3";
            // 
            // PX2textBox
            // 
            this.PX2textBox.Location = new System.Drawing.Point(53, 268);
            this.PX2textBox.Name = "PX2textBox";
            this.PX2textBox.Size = new System.Drawing.Size(100, 20);
            this.PX2textBox.TabIndex = 21;
            this.PX2textBox.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "`x2";
            // 
            // PX1textBox
            // 
            this.PX1textBox.Location = new System.Drawing.Point(53, 242);
            this.PX1textBox.Name = "PX1textBox";
            this.PX1textBox.Size = new System.Drawing.Size(100, 20);
            this.PX1textBox.TabIndex = 19;
            this.PX1textBox.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "`x1";
            // 
            // Y3textBox
            // 
            this.Y3textBox.Location = new System.Drawing.Point(53, 216);
            this.Y3textBox.Name = "Y3textBox";
            this.Y3textBox.Size = new System.Drawing.Size(100, 20);
            this.Y3textBox.TabIndex = 17;
            this.Y3textBox.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "y3";
            // 
            // Y2textBox
            // 
            this.Y2textBox.Location = new System.Drawing.Point(53, 190);
            this.Y2textBox.Name = "Y2textBox";
            this.Y2textBox.Size = new System.Drawing.Size(100, 20);
            this.Y2textBox.TabIndex = 15;
            this.Y2textBox.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "y2";
            // 
            // Y1textBox
            // 
            this.Y1textBox.Location = new System.Drawing.Point(53, 164);
            this.Y1textBox.Name = "Y1textBox";
            this.Y1textBox.Size = new System.Drawing.Size(100, 20);
            this.Y1textBox.TabIndex = 13;
            this.Y1textBox.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "y1";
            // 
            // X3textBox
            // 
            this.X3textBox.Location = new System.Drawing.Point(53, 138);
            this.X3textBox.Name = "X3textBox";
            this.X3textBox.Size = new System.Drawing.Size(100, 20);
            this.X3textBox.TabIndex = 11;
            this.X3textBox.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "x3";
            // 
            // X2textBox
            // 
            this.X2textBox.Location = new System.Drawing.Point(53, 112);
            this.X2textBox.Name = "X2textBox";
            this.X2textBox.Size = new System.Drawing.Size(100, 20);
            this.X2textBox.TabIndex = 9;
            this.X2textBox.Text = "16";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "x2";
            // 
            // X1textBox
            // 
            this.X1textBox.Location = new System.Drawing.Point(53, 86);
            this.X1textBox.Name = "X1textBox";
            this.X1textBox.Size = new System.Drawing.Size(100, 20);
            this.X1textBox.TabIndex = 7;
            this.X1textBox.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "x1";
            // 
            // M3textBox
            // 
            this.M3textBox.BackColor = System.Drawing.Color.Lime;
            this.M3textBox.Location = new System.Drawing.Point(53, 60);
            this.M3textBox.Name = "M3textBox";
            this.M3textBox.Size = new System.Drawing.Size(100, 20);
            this.M3textBox.TabIndex = 5;
            this.M3textBox.Text = "0.0001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "M3";
            // 
            // M2textBox
            // 
            this.M2textBox.BackColor = System.Drawing.Color.Blue;
            this.M2textBox.Location = new System.Drawing.Point(53, 34);
            this.M2textBox.Name = "M2textBox";
            this.M2textBox.Size = new System.Drawing.Size(100, 20);
            this.M2textBox.TabIndex = 3;
            this.M2textBox.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "M2";
            // 
            // M1textBox
            // 
            this.M1textBox.BackColor = System.Drawing.Color.Red;
            this.M1textBox.Location = new System.Drawing.Point(53, 8);
            this.M1textBox.Name = "M1textBox";
            this.M1textBox.Size = new System.Drawing.Size(100, 20);
            this.M1textBox.TabIndex = 1;
            this.M1textBox.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "M1";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 0);
            this.panel4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 507);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ResButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox T_MAXtextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox dTtextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PY3textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PY2textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PY1textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PX3textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PX2textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PX1textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Y3textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Y2textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Y1textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox X3textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox X2textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox X1textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox M3textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox M2textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox M1textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}

