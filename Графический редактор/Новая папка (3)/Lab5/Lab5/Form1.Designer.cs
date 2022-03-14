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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRedactorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Pointtsb = new System.Windows.Forms.ToolStripButton();
            this.Linetsb = new System.Windows.Forms.ToolStripButton();
            this.Elipstsb = new System.Windows.Forms.ToolStripButton();
            this.Recttsb = new System.Windows.Forms.ToolStripButton();
            this.LineHgtCB = new System.Windows.Forms.ToolStripComboBox();
            this.widthSCB = new System.Windows.Forms.ToolStripComboBox();
            this.Erasertsb = new System.Windows.Forms.ToolStripSplitButton();
            this.формаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маленькийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.большойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Filltsb = new System.Windows.Forms.ToolStripButton();
            this.ColorButton = new System.Windows.Forms.ToolStripButton();
            this.BackColorButton = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Field = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Create";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Open";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pointtsb,
            this.Linetsb,
            this.Elipstsb,
            this.Recttsb,
            this.LineHgtCB,
            this.widthSCB,
            this.Erasertsb,
            this.Filltsb,
            this.ColorButton,
            this.BackColorButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
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
            this.Pointtsb.Text = "Точка";
            this.Pointtsb.Click += new System.EventHandler(this.Pointtsb_Click);
            // 
            // Linetsb
            // 
            this.Linetsb.CheckOnClick = true;
            this.Linetsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Linetsb.Image = ((System.Drawing.Image)(resources.GetObject("Linetsb.Image")));
            this.Linetsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Linetsb.Name = "Linetsb";
            this.Linetsb.Size = new System.Drawing.Size(23, 22);
            this.Linetsb.Text = "Линия";
            this.Linetsb.Click += new System.EventHandler(this.Linetsb_Click);
            // 
            // Elipstsb
            // 
            this.Elipstsb.CheckOnClick = true;
            this.Elipstsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Elipstsb.Image = ((System.Drawing.Image)(resources.GetObject("Elipstsb.Image")));
            this.Elipstsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Elipstsb.Name = "Elipstsb";
            this.Elipstsb.Size = new System.Drawing.Size(23, 22);
            this.Elipstsb.Text = "Эллипс";
            this.Elipstsb.Click += new System.EventHandler(this.Elipstsb_Click);
            // 
            // Recttsb
            // 
            this.Recttsb.CheckOnClick = true;
            this.Recttsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Recttsb.Image = ((System.Drawing.Image)(resources.GetObject("Recttsb.Image")));
            this.Recttsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Recttsb.Name = "Recttsb";
            this.Recttsb.Size = new System.Drawing.Size(23, 22);
            this.Recttsb.Text = "Прямоугольник";
            this.Recttsb.Click += new System.EventHandler(this.Recttsb_Click);
            // 
            // LineHgtCB
            // 
            this.LineHgtCB.Enabled = false;
            this.LineHgtCB.Items.AddRange(new object[] {
            "Контур",
            "Заливка",
            "Контур+заливка"});
            this.LineHgtCB.Name = "LineHgtCB";
            this.LineHgtCB.Size = new System.Drawing.Size(75, 25);
            this.LineHgtCB.Text = "Контур";
            this.LineHgtCB.Click += new System.EventHandler(this.LineHgtCB_Click);
            // 
            // widthSCB
            // 
            this.widthSCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
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
            this.widthSCB.Text = "1";
            this.widthSCB.Click += new System.EventHandler(this.widthSCB_Click);
            // 
            // Erasertsb
            // 
            this.Erasertsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Erasertsb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формаToolStripMenuItem,
            this.размерToolStripMenuItem});
            this.Erasertsb.Image = ((System.Drawing.Image)(resources.GetObject("Erasertsb.Image")));
            this.Erasertsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Erasertsb.Name = "Erasertsb";
            this.Erasertsb.Size = new System.Drawing.Size(32, 22);
            this.Erasertsb.Text = "Ластик";
            this.Erasertsb.ButtonClick += new System.EventHandler(this.Erasertsb_ButtonClick);
            // 
            // формаToolStripMenuItem
            // 
            this.формаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кругToolStripMenuItem,
            this.квадратToolStripMenuItem});
            this.формаToolStripMenuItem.Name = "формаToolStripMenuItem";
            this.формаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.формаToolStripMenuItem.Text = "Форма";
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.кругToolStripMenuItem.Text = "Круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.кругToolStripMenuItem_Click);
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маленькийToolStripMenuItem,
            this.среднийToolStripMenuItem,
            this.большойToolStripMenuItem});
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.размерToolStripMenuItem.Text = "Размер";
            // 
            // маленькийToolStripMenuItem
            // 
            this.маленькийToolStripMenuItem.Name = "маленькийToolStripMenuItem";
            this.маленькийToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.маленькийToolStripMenuItem.Text = "Маленький";
            this.маленькийToolStripMenuItem.Click += new System.EventHandler(this.маленькийToolStripMenuItem_Click);
            // 
            // среднийToolStripMenuItem
            // 
            this.среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            this.среднийToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.среднийToolStripMenuItem.Text = "Средний";
            this.среднийToolStripMenuItem.Click += new System.EventHandler(this.среднийToolStripMenuItem_Click);
            // 
            // большойToolStripMenuItem
            // 
            this.большойToolStripMenuItem.Name = "большойToolStripMenuItem";
            this.большойToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.большойToolStripMenuItem.Text = "Большой";
            this.большойToolStripMenuItem.Click += new System.EventHandler(this.большойToolStripMenuItem_Click);
            // 
            // Filltsb
            // 
            this.Filltsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Filltsb.Image = ((System.Drawing.Image)(resources.GetObject("Filltsb.Image")));
            this.Filltsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Filltsb.Name = "Filltsb";
            this.Filltsb.Size = new System.Drawing.Size(23, 22);
            this.Filltsb.Text = "Заливка";
            this.Filltsb.Click += new System.EventHandler(this.Filltsb_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(23, 22);
            this.ColorButton.Text = "Цвет";
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // BackColorButton
            // 
            this.BackColorButton.BackColor = System.Drawing.SystemColors.Control;
            this.BackColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(23, 22);
            this.BackColorButton.Text = "Цвет фона";
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Значок1.ico");
            this.imageList1.Images.SetKeyName(1, "Значок2.ico");
            this.imageList1.Images.SetKeyName(2, "Значок3.ico");
            this.imageList1.Images.SetKeyName(3, "Значок4.ico");
            this.imageList1.Images.SetKeyName(4, "Значок5.ico");
            this.imageList1.Images.SetKeyName(5, "Значок6.ico");
            // 
            // Field
            // 
            this.Field.Cursor = System.Windows.Forms.Cursors.Default;
            this.Field.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Field.Location = new System.Drawing.Point(0, 52);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(484, 409);
            this.Field.TabIndex = 2;
            this.Field.TabStop = false;
            this.Field.Paint += new System.Windows.Forms.PaintEventHandler(this.Field_Paint);
            this.Field.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Field_MouseDown);
            this.Field.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Field_MouseMove);
            this.Field.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Field_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GRedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GRedactorForm";
            this.Text = "Графический редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GRedactorForm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Pointtsb;
        private System.Windows.Forms.ToolStripButton Linetsb;
        private System.Windows.Forms.ToolStripButton Recttsb;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Field;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripComboBox LineHgtCB;
        private System.Windows.Forms.ToolStripButton Elipstsb;
        private System.Windows.Forms.ToolStripComboBox widthSCB;
        private System.Windows.Forms.ToolStripSplitButton Erasertsb;
        private System.Windows.Forms.ToolStripMenuItem формаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маленькийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem большойToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Filltsb;
        private System.Windows.Forms.ToolStripButton BackColorButton;
        private System.Windows.Forms.ToolStripButton ColorButton;
    }
}

