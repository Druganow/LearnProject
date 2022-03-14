namespace Lab4
{
    partial class SearchAdresForm
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
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FlatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HouseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(31, 201);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(229, 253);
            this.ResultsTextBox.TabIndex = 32;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(107, 129);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 31;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(124, 36);
            this.StreetTextBox.MaxLength = 25;
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 26);
            this.StreetTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Квартира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Дом";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Улица";
            // 
            // FlatNumericUpDown
            // 
            this.FlatNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatNumericUpDown.Location = new System.Drawing.Point(124, 88);
            this.FlatNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.FlatNumericUpDown.Name = "FlatNumericUpDown";
            this.FlatNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.FlatNumericUpDown.TabIndex = 1;
            this.FlatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HouseNumericUpDown
            // 
            this.HouseNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseNumericUpDown.Location = new System.Drawing.Point(124, 62);
            this.HouseNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HouseNumericUpDown.Name = "HouseNumericUpDown";
            this.HouseNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.HouseNumericUpDown.TabIndex = 1;
            this.HouseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SearchAdresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 484);
            this.Controls.Add(this.FlatNumericUpDown);
            this.Controls.Add(this.HouseNumericUpDown);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchAdresForm";
            this.Text = "Поиск по адресу";
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FlatNumericUpDown;
        private System.Windows.Forms.NumericUpDown HouseNumericUpDown;
    }
}