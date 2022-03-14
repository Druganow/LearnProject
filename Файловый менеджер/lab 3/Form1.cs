using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_3
{
    
    public partial class MainForm : Form
    {
        string BufferName;
        public MainForm()
        {
            
        InitializeComponent();
        }

        private void DriveLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirLB.Path = DriveLB.Drive;
        }

        private void DirLB_Change(object sender, EventArgs e)
        {
            FileLB.Path = DirLB.Path;
        }

        private void DeleteMI_Click(object sender, EventArgs e)
        {
            //удаление выделенного файла
            if (contextMenuStrip1.SourceControl.Equals(FileLB))
            {
                //определяем полный путь к выбранному файлу
                string DestFile =
                Path.Combine(FileLB.Path, FileLB.FileName);
                //запрашиваем подтверждение на удаление файла
                if (MessageBox.Show("Вы действительно хотите удалить файл \"" + DestFile + "\"",
                "Подтверждение удаления файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //удаляем файл
                        File.Delete(DestFile);
                        
                        //обновляем содержимое компонента FileLB
                        FileLB.Refresh();
                    }
                    catch
                    {
                        //выводим сообщение об ошибке
                        MessageBox.Show("Удаление файла не завершено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }
            }

            //удаление выделенного каталога
            if (contextMenuStrip1.SourceControl.Equals(DirLB))
            {
                //определяем полное имя выбранного каталога
                string DestFolder = DirLB.get_DirList(DirLB.DirListIndex);
                //запрашиваем подтверждение на удаление каталога
                if (MessageBox.Show("Вы действительно хотите удалить каталог \"" + DestFolder + "\" и все его содержимое", "Подтверждение удаления каталога", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //удаляем каталог
                        Directory.Delete(DestFolder, true);
                        //обновляем содержимое компонента DirLb
                        DirLB.Path =
                        Directory.GetParent(DestFolder).FullName;
                        DirLB.Refresh();
                    }
                    catch
                    {
                        MessageBox.Show("Удаление каталога не завершено!", "Уведомление",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void CreateMI_Click(object sender, EventArgs e)
        {

            if (contextMenuStrip1.SourceControl.Equals(DirLB))
            {
                Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
                if(Data.Value!=null)
                {
 //определяем полный путь к выбранному файлу
                string DestFolder = Path.Combine(DirLB.Path, Data.Value);
                //запрашиваем подтверждение на удаление файла
                if (!Directory.Exists(DestFolder))
                {
                    Directory.CreateDirectory(DestFolder);
                    DirLB.Path = Directory.GetParent(DestFolder).FullName;  
                }
                else
                {
                    if (MessageBox.Show("Каталог \"" + DestFolder + "\" уже существует создать его копию?", "Подтверждение создании копии", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DestFolder = Path.Combine(DirLB.Path, Data.Value + " -копия");
                        Directory.CreateDirectory(DestFolder);
                        DirLB.Path = Directory.GetParent(DestFolder).FullName;
                    }
                }
                }
                DirLB.Refresh();
            }
            if (contextMenuStrip1.SourceControl.Equals(FileLB))
            {
                Form2 f = new Form2();
                f.Owner = this;
                f.ShowDialog();
                if (Data.Value != null)
                {
                    //определяем полный путь к выбранному файлу
                    string DestFolder = Path.Combine(FileLB.Path, Data.Value);
                    //запрашиваем подтверждение на удаление файла
                    if (!File.Exists(DestFolder))
                    {
                        File.Create(DestFolder);
                        DirLB.Path = Directory.GetParent(DestFolder).FullName;
                    }
                    else
                    {
                        if (MessageBox.Show("Файл \"" + DestFolder + "\" уже существует создать его копию?", "Подтверждение создании копии", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DestFolder = Path.Combine(FileLB.Path, Data.Value + " -копия");
                            File.Create(DestFolder);
                            DirLB.Path = Directory.GetParent(DestFolder).FullName;
                        }
                    }
                }

                FileLB.Refresh();
            }
        }

        private void InsertMI_Click(object sender, EventArgs e)
        {
            //Directory.Move(BufferName, DirLB.get_DirList(DirLB.DirListIndex));
            //Directory.
        }

        private void CopyMI_Click(object sender, EventArgs e)
        {
            BufferName = DirLB.get_DirList(DirLB.DirListIndex);
            InsertMI.Enabled = true;
        }
    }

    static class Data
    {
        public static string Value { get; set; }
    }
}
