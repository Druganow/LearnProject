namespace Lab5
{
    partial class GRedactorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRedactorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Pointtsb = new System.Windows.Forms.ToolStripButton();
            this.Linetsb = new System.Windows.Forms.ToolStripButton();
            this.Recttsb = new System.Windows.Forms.ToolStripButton();
            this.widthSCB = new System.Windows.Forms.ToolStripComboBox();
            this.ColorButton1 = new System.Windows.Forms.ToolStripButton();
            this.ColorButton2 = new System.Windows.Forms.ToolStripButton();
            this.Field = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LineHgtCB = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.большойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маленькийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pointtsb,
            this.Linetsb,
            this.toolStripButton1,
            this.Recttsb,
            this.LineHgtCB,
            this.widthSCB,
            this.ColorButton1,
            this.ColorButton2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(349, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Pointtsb
            // 
            this.Pointtsb.Checked = true;
            this.Pointtsb.CheckOnClick = true;
            this.Pointtsb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Pointtsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pointtsb.Image = ((System.Drawing.Image)(resources.GetObject("Pointtsb.Image")));
            this.Pointtsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pointtsb.Name = "Pointtsb";
            this.Pointtsb.Size = new System.Drawing.Size(23, 22);
            this.Pointtsb.Text = "toolStripButton1";
            // 
            // Linetsb
            // 
            this.Linetsb.CheckOnClick = true;
            this.Linetsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Linetsb.Image = ((System.Drawing.Image)(resources.GetObject("Linetsb.Image")));
            this.Linetsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Linetsb.Name = "Linetsb";
            this.Linetsb.Size = new System.Drawing.Size(23, 22);
            this.Linetsb.Text = "toolStripButton2";
            // 
            // Recttsb
            // 
            this.Recttsb.CheckOnClick = true;
            this.Recttsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Recttsb.Image = ((System.Drawing.Image)(resources.GetObject("Recttsb.Image")));
            this.Recttsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Recttsb.Name = "Recttsb";
            this.Recttsb.Size = new System.Drawing.Size(23, 22);
            this.Recttsb.Text = "toolStripButton3";
            // 
            // widthSCB
            // 
            this.widthSCB.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.widthSCB.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.widthSCB.Name = "widthSCB";
            this.widthSCB.Size = new System.Drawing.Size(75, 25);
            this.widthSCB.Text = "2";
            // 
            // ColorButton1
            // 
            this.ColorButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorButton1.Image = ((System.Drawing.Image)(resources.GetObject("ColorButton1.Image")));
            this.ColorButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorButton1.Name = "ColorButton1";
            this.ColorButton1.Size = new System.Drawing.Size(23, 22);
            this.ColorButton1.Text = "toolStripButton1";
            this.ColorButton1.Click += new System.EventHandler(this.ColorButton1_Click);
            // 
            // ColorButton2
            // 
            this.ColorButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorButton2.Image = ((System.Drawing.Image)(resources.GetObject("ColorButton2.Image")));
            this.ColorButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorButton2.Name = "ColorButton2";
            this.ColorButton2.Size = new System.Drawing.Size(23, 22);
            this.ColorButton2.Text = "toolStripButton1";
            this.ColorButton2.Click += new System.EventHandler(this.ColorButton2_Click);
            // 
            // Field
            // 
            this.Field.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Field.Location = new System.Drawing.Point(0, 55);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(349, 206);
            this.Field.TabIndex = 2;
            this.Field.TabStop = false;
            this.Field.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Field_MouseDown);
            this.Field.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Field_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LineHgtCB
            // 
            this.LineHgtCB.Items.AddRange(new object[] {
            "Контур",
            "Заливка",
            "Контур+заливка"});
            this.LineHgtCB.Name = "LineHgtCB";
            this.LineHgtCB.Size = new System.Drawing.Size(75, 25);
            this.LineHgtCB.Text = "Контур";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.большойToolStripMenuItem,
            this.среднийToolStripMenuItem,
            this.маленькийToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Размер";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кругToolStripMenuItem,
            this.квадратToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Форма";
            // 
            // большойToolStripMenuItem
            // 
            this.большойToolStripMenuItem.Name = "большойToolStripMenuItem";
            this.большойToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.большойToolStripMenuItem.Text = "Большой";
            // 
            // среднийToolStripMenuItem
            // 
            this.среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            this.среднийToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.среднийToolStripMenuItem.Text = "Средний";
            // 
            // маленькийToolStripMenuItem
            // 
            this.маленькийToolStripMenuItem.Checked = true;
            this.маленькийToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.маленькийToolStripMenuItem.Name = "маленькийToolStripMenuItem";
            this.маленькийToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.маленькийToolStripMenuItem.Text = "Маленький";
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.кругToolStripMenuItem.Text = "Круг";
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Checked = true;
            this.квадратToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // GRedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GRedactorForm";
            this.Text = "Графический редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Pointtsb;
        private System.Windows.Forms.ToolStripButton Linetsb;
        private System.Windows.Forms.ToolStripButton Recttsb;
        private System.Windows.Forms.PictureBox Field;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripComboBox widthSCB;
        private System.Windows.Forms.ToolStripButton ColorButton1;
        private System.Windows.Forms.ToolStripButton ColorButton2;
        private System.Windows.Forms.ToolStripComboBox LineHgtCB;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem большойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маленькийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

