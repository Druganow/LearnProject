namespace lab_3
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DriveLB = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.DirLB = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMI = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMI = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FileLB = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DriveLB);
            this.splitContainer1.Panel1.Controls.Add(this.DirLB);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FileLB);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(684, 461);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // DriveLB
            // 
            this.DriveLB.FormattingEnabled = true;
            this.DriveLB.Location = new System.Drawing.Point(114, 3);
            this.DriveLB.Name = "DriveLB";
            this.DriveLB.Size = new System.Drawing.Size(121, 21);
            this.DriveLB.TabIndex = 3;
            this.DriveLB.SelectedIndexChanged += new System.EventHandler(this.DriveLB_SelectedIndexChanged);
            // 
            // DirLB
            // 
            this.DirLB.ContextMenuStrip = this.contextMenuStrip1;
            this.DirLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DirLB.FormattingEnabled = true;
            this.DirLB.IntegralHeight = false;
            this.DirLB.Location = new System.Drawing.Point(0, 50);
            this.DirLB.Name = "DirLB";
            this.DirLB.Size = new System.Drawing.Size(346, 407);
            this.DirLB.TabIndex = 2;
            this.DirLB.Change += new System.EventHandler(this.DirLB_Change);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMI,
            this.CopyMI,
            this.InsertMI,
            this.DeleteMI});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // CreateMI
            // 
            this.CreateMI.Name = "CreateMI";
            this.CreateMI.Size = new System.Drawing.Size(180, 22);
            this.CreateMI.Text = "Создать";
            this.CreateMI.Click += new System.EventHandler(this.CreateMI_Click);
            // 
            // CopyMI
            // 
            this.CopyMI.Name = "CopyMI";
            this.CopyMI.Size = new System.Drawing.Size(180, 22);
            this.CopyMI.Text = "Копировать";
            this.CopyMI.Click += new System.EventHandler(this.CopyMI_Click);
            // 
            // InsertMI
            // 
            this.InsertMI.Enabled = false;
            this.InsertMI.Name = "InsertMI";
            this.InsertMI.Size = new System.Drawing.Size(180, 22);
            this.InsertMI.Text = "Вставить";
            this.InsertMI.Click += new System.EventHandler(this.InsertMI_Click);
            // 
            // DeleteMI
            // 
            this.DeleteMI.Name = "DeleteMI";
            this.DeleteMI.Size = new System.Drawing.Size(180, 22);
            this.DeleteMI.Text = "Удалить";
            this.DeleteMI.Click += new System.EventHandler(this.DeleteMI_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Список каталогов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите диск";
            // 
            // FileLB
            // 
            this.FileLB.ContextMenuStrip = this.contextMenuStrip1;
            this.FileLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FileLB.FormattingEnabled = true;
            this.FileLB.Location = new System.Drawing.Point(0, 50);
            this.FileLB.Name = "FileLB";
            this.FileLB.Pattern = "*.*";
            this.FileLB.Size = new System.Drawing.Size(326, 407);
            this.FileLB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Список файлов в каталоге";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Файловый менеджер";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox DriveLB;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox DirLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox FileLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateMI;
        private System.Windows.Forms.ToolStripMenuItem CopyMI;
        private System.Windows.Forms.ToolStripMenuItem InsertMI;
        private System.Windows.Forms.ToolStripMenuItem DeleteMI;
    }
}

