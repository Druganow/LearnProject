namespace Lab4
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.HouseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FlatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.абонентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поАдресуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТелефонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОтчествуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУлицеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКвартиреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДомуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТелефонуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Quantity_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.QuantityToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Number_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Улица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дом";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Квартира";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Телефон";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Enabled = false;
            this.PatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTextBox.Location = new System.Drawing.Point(94, 100);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(123, 26);
            this.PatronymicTextBox.TabIndex = 7;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Enabled = false;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextBox.Location = new System.Drawing.Point(94, 48);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(123, 26);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(94, 74);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(123, 26);
            this.NameTextBox.TabIndex = 9;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Enabled = false;
            this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(94, 126);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(123, 26);
            this.StreetTextBox.TabIndex = 10;
            // 
            // HouseNumericUpDown
            // 
            this.HouseNumericUpDown.Enabled = false;
            this.HouseNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseNumericUpDown.Location = new System.Drawing.Point(94, 152);
            this.HouseNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HouseNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HouseNumericUpDown.Name = "HouseNumericUpDown";
            this.HouseNumericUpDown.Size = new System.Drawing.Size(123, 26);
            this.HouseNumericUpDown.TabIndex = 11;
            this.HouseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FlatNumericUpDown
            // 
            this.FlatNumericUpDown.Enabled = false;
            this.FlatNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatNumericUpDown.Location = new System.Drawing.Point(94, 178);
            this.FlatNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.FlatNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FlatNumericUpDown.Name = "FlatNumericUpDown";
            this.FlatNumericUpDown.Size = new System.Drawing.Size(123, 26);
            this.FlatNumericUpDown.TabIndex = 12;
            this.FlatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Enabled = false;
            this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(94, 202);
            this.PhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(123, 26);
            this.PhoneMaskedTextBox.TabIndex = 13;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousButton.Location = new System.Drawing.Point(60, 238);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(33, 35);
            this.PreviousButton.TabIndex = 0;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(134, 238);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(33, 35);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абонентToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(346, 28);
            this.MainMenuStrip.TabIndex = 16;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // абонентToolStripMenuItem
            // 
            this.абонентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.абонентToolStripMenuItem.Name = "абонентToolStripMenuItem";
            this.абонентToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.абонентToolStripMenuItem.Text = "Абонент";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Enabled = false;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФИОToolStripMenuItem,
            this.поАдресуToolStripMenuItem,
            this.поТелефонуToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поФИОToolStripMenuItem
            // 
            this.поФИОToolStripMenuItem.Name = "поФИОToolStripMenuItem";
            this.поФИОToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.поФИОToolStripMenuItem.Text = "по ФИО";
            this.поФИОToolStripMenuItem.Click += new System.EventHandler(this.поФИОToolStripMenuItem_Click);
            // 
            // поАдресуToolStripMenuItem
            // 
            this.поАдресуToolStripMenuItem.Name = "поАдресуToolStripMenuItem";
            this.поАдресуToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.поАдресуToolStripMenuItem.Text = "по адресу";
            this.поАдресуToolStripMenuItem.Click += new System.EventHandler(this.поАдресуToolStripMenuItem_Click);
            // 
            // поТелефонуToolStripMenuItem
            // 
            this.поТелефонуToolStripMenuItem.Name = "поТелефонуToolStripMenuItem";
            this.поТелефонуToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.поТелефонуToolStripMenuItem.Text = "по телефону";
            this.поТелефонуToolStripMenuItem.Click += new System.EventHandler(this.поТелефонуToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФамилииToolStripMenuItem,
            this.поИмениToolStripMenuItem,
            this.поОтчествуToolStripMenuItem,
            this.поУлицеToolStripMenuItem,
            this.поКвартиреToolStripMenuItem,
            this.поДомуToolStripMenuItem,
            this.поТелефонуToolStripMenuItem1});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поФамилииToolStripMenuItem
            // 
            this.поФамилииToolStripMenuItem.Name = "поФамилииToolStripMenuItem";
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.поФамилииToolStripMenuItem.Text = "По фамилии";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.поФамилииToolStripMenuItem_Click);
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.поИмениToolStripMenuItem.Text = "По имени";
            this.поИмениToolStripMenuItem.Click += new System.EventHandler(this.поИмениToolStripMenuItem_Click);
            // 
            // поОтчествуToolStripMenuItem
            // 
            this.поОтчествуToolStripMenuItem.Name = "поОтчествуToolStripMenuItem";
            this.поОтчествуToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.поОтчествуToolStripMenuItem.Text = "По отчеству";
            this.поОтчествуToolStripMenuItem.Click += new System.EventHandler(this.поОтчествуToolStripMenuItem_Click);
            // 
            // поУлицеToolStripMenuItem
            // 
            this.поУлицеToolStripMenuItem.Name = "поУлицеToolStripMenuItem";
            this.поУлицеToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.поУлицеToolStripMenuItem.Text = "По улице";
            this.поУлицеToolStripMenuItem.Click += new System.EventHandler(this.поУлицеToolStripMenuItem_Click);
            // 
            // поКвартиреToolStripMenuItem
            // 
            this.поКвартиреToolStripMenuItem.Name = "поКвартиреToolStripMenuItem";
            this.поКвартиреToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.поКвартиреToolStripMenuItem.Text = "По квартире";
            this.поКвартиреToolStripMenuItem.Click += new System.EventHandler(this.поКвартиреToolStripMenuItem_Click);
            // 
            // поДомуToolStripMenuItem
            // 
            this.поДомуToolStripMenuItem.Name = "поДомуToolStripMenuItem";
            this.поДомуToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.поДомуToolStripMenuItem.Text = "По дому";
            this.поДомуToolStripMenuItem.Click += new System.EventHandler(this.поДомуToolStripMenuItem_Click);
            // 
            // поТелефонуToolStripMenuItem1
            // 
            this.поТелефонуToolStripMenuItem1.Name = "поТелефонуToolStripMenuItem1";
            this.поТелефонуToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.поТелефонуToolStripMenuItem1.Text = "По телефону";
            this.поТелефонуToolStripMenuItem1.Click += new System.EventHandler(this.поТелефонуToolStripMenuItem1_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quantity_ToolStripStatusLabel,
            this.QuantityToolStripStatusLabel,
            this.Number_ToolStripStatusLabel,
            this.NumberToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 330);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(346, 24);
            this.StatusStrip.TabIndex = 17;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // Quantity_ToolStripStatusLabel
            // 
            this.Quantity_ToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Quantity_ToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Quantity_ToolStripStatusLabel.Name = "Quantity_ToolStripStatusLabel";
            this.Quantity_ToolStripStatusLabel.Size = new System.Drawing.Size(123, 19);
            this.Quantity_ToolStripStatusLabel.Text = "Количество записей";
            // 
            // QuantityToolStripStatusLabel
            // 
            this.QuantityToolStripStatusLabel.AutoSize = false;
            this.QuantityToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.QuantityToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.QuantityToolStripStatusLabel.Name = "QuantityToolStripStatusLabel";
            this.QuantityToolStripStatusLabel.Size = new System.Drawing.Size(30, 19);
            // 
            // Number_ToolStripStatusLabel
            // 
            this.Number_ToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Number_ToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Number_ToolStripStatusLabel.Name = "Number_ToolStripStatusLabel";
            this.Number_ToolStripStatusLabel.Size = new System.Drawing.Size(90, 19);
            this.Number_ToolStripStatusLabel.Text = "Номер записи";
            // 
            // NumberToolStripStatusLabel
            // 
            this.NumberToolStripStatusLabel.AutoSize = false;
            this.NumberToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.NumberToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.NumberToolStripStatusLabel.Name = "NumberToolStripStatusLabel";
            this.NumberToolStripStatusLabel.Size = new System.Drawing.Size(30, 19);
            this.NumberToolStripStatusLabel.Text = "0";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Enabled = false;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 354);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.FlatNumericUpDown);
            this.Controls.Add(this.HouseNumericUpDown);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телефонная книжка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.NumericUpDown HouseNumericUpDown;
        private System.Windows.Forms.NumericUpDown FlatNumericUpDown;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Quantity_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel QuantityToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Number_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NumberToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem абонентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКвартиреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поАдресуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТелефонуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОтчествуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУлицеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДомуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТелефонуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

