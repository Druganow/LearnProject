using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textredactor
{
    public partial class MainForm : Form
    {
        int LastSize = 8;
        string s = "";
        bool izm = false;
        public MainForm()
        {
            InitializeComponent();
       
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            if (izm)
            {
                DialogResult dr = MessageBox.Show("Хотите сохранить изменения в файле?",
                      "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            if (s != "") TextEdit.SaveFile(s);
                            else
                            {
                                saveFileDialog1.Filter = "RTF files|*.rtf";
                                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                {
                                    TextEdit.SaveFile(saveFileDialog1.FileName);
                                    s = saveFileDialog1.FileName;
                                }
                            }
                        }
                        break;
                    case DialogResult.No: break;
                }
            }
            //устанавливаем фильтр
            openFileDialog1.Filter = "RTF files|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //загружаем текст из файла
                TextEdit.LoadFile(openFileDialog1.FileName);
                //отображаем полное имя файла в заголовке формы
                Text = "Text Editor   " + openFileDialog1.FileName;
                s = openFileDialog1.FileName;
            }

        }

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тоже интересно, что должно быть здесь");
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {

            
            if (s != "") TextEdit.SaveFile(s);
            else
            {
                saveFileDialog1.Filter = "RTF files|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextEdit.SaveFile(saveFileDialog1.FileName);
                    s = saveFileDialog1.FileName;
                }
            }
        }

        private void BoldToolStripButton_Click(object sender, EventArgs e)
        {
            {
               // IfTextChanged = true;

                string SelectedText = TextEdit.SelectedText;
                int LengthSelectedText = TextEdit.SelectionLength;
                int SelectionStart = TextEdit.SelectionStart;

                if (!TextEdit.SelectionFont.Bold)
                {
                    for (int i = 0; i < LengthSelectedText; i++)
                    {
                        TextEdit.Select(SelectionStart + i, 1);
                        if (TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                        else if (TextEdit.SelectionFont.Underline)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Bold | FontStyle.Underline);
                        else if (TextEdit.SelectionFont.Italic)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Bold | FontStyle.Italic);
                        else
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Bold);
                    }
                    if (LengthSelectedText == 0)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Bold);

                    BoldToolStripButton.Checked = true;

                }
                else
                {
                    for (int i = 0; i <= LengthSelectedText; i++)
                    {
                        TextEdit.Select(SelectionStart + i, 1);
                        if (TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                        else if (TextEdit.SelectionFont.Underline)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold | FontStyle.Underline);
                        else if (TextEdit.SelectionFont.Italic)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold | FontStyle.Italic);
                        else
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold);
                    }
                    if (LengthSelectedText == 0)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold);
                    BoldToolStripButton.Checked = false;
                }
                TextEdit.Select(SelectionStart, LengthSelectedText);

            }

        }

        private void TextEdit_SelectionChanged(object sender, EventArgs e)
        {
            if (TextEdit.SelectionFont == null) return;
            BoldToolStripButton.Checked = TextEdit.SelectionFont.Bold;
            if (TextEdit.SelectionFont == null) return;
            ItalicToolStripButton.Checked = TextEdit.SelectionFont.Italic;
            if (TextEdit.SelectionFont == null) return;
            UnderLineToolStripButton.Checked = TextEdit.SelectionFont.Underline;
            if (TextEdit.SelectionFont == null) return;
            // . CeterToolStripButton.Checked = HorizontalAlignment.Left;
            //lectionAlignment = HorizontalAlignment.Left;
            if (TextEdit.SelectionAlignment.ToString() == "Right")
            {
                CeterToolStripButton.Checked = false;
                RightToolStripButton.Checked = true;
                LeftToolStripButton.Checked = false;
                правоToolStripMenuItem.Checked = true;
                левыйToolStripMenuItem.Checked = false;
                центрToolStripMenuItem.Checked = false;

            }
            else if (TextEdit.SelectionAlignment.ToString() == "Center")
            {
                CeterToolStripButton.Checked = true;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = false;
                правоToolStripMenuItem.Checked = false;
                левыйToolStripMenuItem.Checked = false;
                центрToolStripMenuItem.Checked = true;
            }
            else
            {
                CeterToolStripButton.Checked = false;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = true;
                правоToolStripMenuItem.Checked = false;
                левыйToolStripMenuItem.Checked = true;
                центрToolStripMenuItem.Checked = false;

            }
            if (TextEdit.SelectionFont == null) return;
            if (TextEdit.SelectionLength == 0)
            {
                вырезатьToolStripButton.Enabled = false;
                копироватьToolStripButton.Enabled = false;
                вырезатьToolStripMenuItem.Enabled = false;
                копироватьToolStripMenuItem.Enabled = false;
            }
            else
            {
                вырезатьToolStripButton.Enabled = true;
                копироватьToolStripButton.Enabled = true;
                вырезатьToolStripMenuItem.Enabled = true;
                копироватьToolStripMenuItem.Enabled = true;
            }
                SizeTSComboBox.Text = Convert.ToString(Convert.ToInt16(TextEdit.SelectionFont.SizeInPoints));//.ToString();  // TextEdit.SelectionFont.FontFamily, 
            izm = TextEdit.CanUndo;
            }

        private void SizeTSComboBox_DropDownClosed(object sender, EventArgs e)
        {
            string SelectedText = TextEdit.SelectedText;
            int LengthSelectedText = TextEdit.SelectionLength;
            int SelectionStart = TextEdit.SelectionStart;

            byte NewSize;
            if (SizeTSComboBox.SelectedItem != null && byte.TryParse(SizeTSComboBox.SelectedItem.ToString(), out NewSize) == true)
            {
                LastSize = NewSize;
                for (int i = 0; i <= LengthSelectedText; i++)
                {
                    if (LengthSelectedText != 0) TextEdit.Select(SelectionStart + i, 1);
                    if (TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    else if (TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic && !TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Bold | FontStyle.Italic);
                    else if (TextEdit.SelectionFont.Bold && !TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Bold | FontStyle.Underline);
                    else if (!TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Italic | FontStyle.Underline);
                    else if (!TextEdit.SelectionFont.Bold && !TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Underline);
                    else if (!TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic &&

                    !TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Italic);
                    else if (TextEdit.SelectionFont.Bold && !TextEdit.SelectionFont.Italic && !TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Bold);
                    else if (!TextEdit.SelectionFont.Bold && !TextEdit.SelectionFont.Italic && !TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize);
                    if (LengthSelectedText == 0) break;
                }

                TextEdit.Select(SelectionStart, LengthSelectedText);
            }
            else  SizeTSComboBox.Text = LastSize.ToString();

           TextEdit.Focus();
        }
    

        private void UnderLineToolStripButton_Click(object sender, EventArgs e)
        {
            //IfTextChanged = true;

            string SelectedText = TextEdit.SelectedText;
            int LengthSelectedText = TextEdit.SelectionLength;
            int SelectionStart = TextEdit.SelectionStart;

            if (!TextEdit.SelectionFont.Underline)
            {
                for (int i = 0; i < LengthSelectedText; i++)
                {
                    TextEdit.Select(SelectionStart + i, 1);
                    if (TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                    else if (TextEdit.SelectionFont.Italic)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Underline | FontStyle.Italic);
                    else if (TextEdit.SelectionFont.Bold)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Underline | FontStyle.Bold);
                    else
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Underline);
                }
                if (LengthSelectedText == 0)
                    TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Underline);
                UnderLineToolStripButton.Checked = true;

            }
            else
            {
                for (int i = 0; i < LengthSelectedText; i++)
                {
                    TextEdit.Select(SelectionStart + i, 1);
                    if (TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                    else if (TextEdit.SelectionFont.Italic)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Underline | FontStyle.Italic);
                    else if (TextEdit.SelectionFont.Bold)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Underline | FontStyle.Bold);
                    else
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Underline);
                }
                if (LengthSelectedText == 0)
                    TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Underline);
                //ToolStripMenuItemBold.CheckOnClick = false; 
                UnderLineToolStripButton.Checked = false;
            }
            TextEdit.Select(SelectionStart, LengthSelectedText);
            //TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold); 
            //SetBoldTwice = !SetBoldTwice; 
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {
           
               // IfTextChanged = true;

                string SelectedText = TextEdit.SelectedText;
                int LengthSelectedText = TextEdit.SelectionLength;
                int SelectionStart = TextEdit.SelectionStart;

                if (!TextEdit.SelectionFont.Italic)
                {
                    for (int i = 0; i < LengthSelectedText; i++)
                    {
                        TextEdit.Select(SelectionStart + i, 1);
                        if (TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Underline)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                        else if (TextEdit.SelectionFont.Underline)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Italic | FontStyle.Underline);
                        else if (TextEdit.SelectionFont.Bold)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Italic | FontStyle.Bold);
                        else
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Italic);
                    }
                    if (LengthSelectedText == 0)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Italic);
                    ItalicToolStripButton.Checked = true;

                }
                else
                {
                    for (int i = 0; i < LengthSelectedText; i++)
                    {
                        TextEdit.Select(SelectionStart + i, 1);
                        if (TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Underline)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                        else if (TextEdit.SelectionFont.Underline)

                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Italic |

                            FontStyle.Underline);
                        else if (TextEdit.SelectionFont.Bold)
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Italic | FontStyle.Bold);
                        else
                            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Italic);
                    }
                    if (LengthSelectedText == 0)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Italic);
                    ItalicToolStripButton.Checked = false;
                }
                TextEdit.Select(SelectionStart, LengthSelectedText);
                //TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold); 
                //SetBoldTwice = !SetBoldTwice; 
            }

        private void ColorBuuton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) TextEdit.SelectionBackColor = colorDialog1.Color;
            //TextEdit.SelectionFont =
            //    new Font(TextEdit.SelectionFont,
            //    TextEdit.SelectionFont.
            //    //if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            //this.BackColor=colorDialog1.Color;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) TextEdit.SelectionColor= colorDialog1.Color;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //if (fontDialog1.ShowDialog() == DialogResult.OK) TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style);
            //TextEdit.SelectionFont =
            //    new Font(TextEdit.SelectionFont,
            //    TextEdit.SelectionFont.
            //    if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            //this.BackColor = colorDialog1.Color;
            if (fontDialog1.ShowDialog() == DialogResult.Cancel) return;
            TextEdit.SelectionFont = fontDialog1.Font;
            TextEdit.SelectionColor = fontDialog1.Color;
            SizeTSComboBox.Text = Convert.ToString(Convert.ToInt16(TextEdit.SelectionFont.SizeInPoints));//.ToString();  // TextEdit.SelectionFont.FontFamily, 
            izm = TextEdit.CanUndo;
            BoldToolStripButton.Checked = TextEdit.SelectionFont.Bold;
            if (TextEdit.SelectionFont == null) return;
            ItalicToolStripButton.Checked = TextEdit.SelectionFont.Italic;
            if (TextEdit.SelectionFont == null) return;
            UnderLineToolStripButton.Checked = TextEdit.SelectionFont.Underline;
        }

        private void CeterToolStripButton_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionAlignment == HorizontalAlignment.Center)
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Left;
               CeterToolStripButton.Checked = false;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = true;
                правоToolStripMenuItem.Checked = false;
                левыйToolStripMenuItem.Checked = true;
                центрToolStripMenuItem.Checked = false;
            }

            else
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Center;
               
  CeterToolStripButton.Checked = true;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = false;
                правоToolStripMenuItem.Checked = false;
                левыйToolStripMenuItem.Checked = false;
                центрToolStripMenuItem.Checked = true;
            }

            
        }

        private void RightToolStripButton_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionAlignment == HorizontalAlignment.Right)
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Left;
                 CeterToolStripButton.Checked = false;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = true;
                правоToolStripMenuItem.Checked = false;
                левыйToolStripMenuItem.Checked = true;
                центрToolStripMenuItem.Checked = false;
            }
            else
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Right;
               CeterToolStripButton.Checked = false;
                RightToolStripButton.Checked = true;
                LeftToolStripButton.Checked = false;
                правоToolStripMenuItem.Checked = true;
                левыйToolStripMenuItem.Checked = false;
                центрToolStripMenuItem.Checked = false;
            }
        }

        private void LeftToolStripButton_Click(object sender, EventArgs e)
        {
             TextEdit.SelectionAlignment = HorizontalAlignment.Left;
            CeterToolStripButton.Checked = false;
            RightToolStripButton.Checked = false;
            LeftToolStripButton.Checked = true;
            правоToolStripMenuItem.Checked = false;
            левыйToolStripMenuItem.Checked = true;
            центрToolStripMenuItem.Checked = false;
            //  else TextEdit.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void вставкаToolStripButton_Click(object sender, EventArgs e)
        {
            TextEdit.Paste();
        }

        private void копироватьToolStripButton_Click(object sender, EventArgs e)
        {
            TextEdit.Copy();
        }

        private void вырезатьToolStripButton_Click(object sender, EventArgs e)
        {
            TextEdit.Cut();
            
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (izm)
            {
                DialogResult dr = MessageBox.Show("Хотите сохранить изменения в файле?",
                      "Выход", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            if (s != "") TextEdit.SaveFile(s);
                            else
                            {
                                saveFileDialog1.Filter = "RTF files|*.rtf";
                                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                {
                                    TextEdit.SaveFile(saveFileDialog1.FileName);
                                    s = saveFileDialog1.FileName;
                                    izm = true;
                                }
                            }
                        }
                        break;
                    case DialogResult.No: break;

                }
                this.Hide();
                MainForm f = new MainForm();
                f.Show();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (izm)
            {
                DialogResult dr = MessageBox.Show("Хотите сохранить изменения в файле?",
                      "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            if (s != "") TextEdit.SaveFile(s);
                            else
                            {
                                saveFileDialog1.Filter = "RTF files|*.rtf";
                                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                {
                                    TextEdit.SaveFile(saveFileDialog1.FileName);
                                    s = saveFileDialog1.FileName;
                                }
                            }
                        }
                        break;
                    case DialogResult.No: break;
                }
            }
            openFileDialog1.Filter = "RTF files|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //загружаем текст из файла
                TextEdit.LoadFile(openFileDialog1.FileName);
                //отображаем полное имя файла в заголовке формы
                Text = "Text Editor   " + openFileDialog1.FileName;
                s = openFileDialog1.FileName;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (s != "")
            {
                TextEdit.SaveFile(s);
                izm = true;
            }
            else
            {
                saveFileDialog1.Filter = "RTF files|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextEdit.SaveFile(saveFileDialog1.FileName);
                    s = saveFileDialog1.FileName;
                    izm = true;
                }
            }
            
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF files|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextEdit.SaveFile(saveFileDialog1.FileName);
                izm = true;

            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.Paste();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель - Саша");
        }

        private void посмотретьСправкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Руководство пользователя\nЗдесь что-то должно быть");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ////if (TextEdit.CanRedo &&TextEdit.CanUndo)
            //{
            //    DialogResult dr = MessageBox.Show("Хотите сохранить изменения в файле?",
            //          "Mood Test", MessageBoxButtons.YesNo);
            //    switch (dr)
            //    {
            //        case DialogResult.Yes: break;
            //        case DialogResult.No: break;
            //    }
            //}
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( izm)
            {
                DialogResult dr = MessageBox.Show("Хотите сохранить изменения в файле?",
                      "Выход", MessageBoxButtons.YesNoCancel);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            if (s != "") TextEdit.SaveFile(s);
                            else
                            {
                                saveFileDialog1.Filter = "RTF files|*.rtf";
                                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                {
                                    TextEdit.SaveFile(saveFileDialog1.FileName);
                                    s = saveFileDialog1.FileName;
                                    izm = true;
                                }
                            }
                        } break;
                    case DialogResult.No: break;
                    case DialogResult.Cancel: e.Cancel=true ; break;
                }
            }
        }

        private void SizeTSComboBox_Click(object sender, EventArgs e)
        {

        }

        private void SizeTSComboBox_TextChanged(object sender, EventArgs e)
        {
            //        try
            //        {
            //            TextEdit.SelectionFont =
            //new Font(TextEdit.SelectionFont.FontFamily, Convert.ToInt16(SizeTSComboBox.Text.ToString()));
            //            TextEdit.Focus();
            //        }
            //        catch { }
        }

        private void SizeTSComboBox_Enter(object sender, EventArgs e)
        {

//        try
//        {
//            TextEdit.SelectionFont =
//new Font(TextEdit.SelectionFont.FontFamily, Convert.ToInt16(SizeTSComboBox.Text.ToString()));
//            TextEdit.Focus();
////        }
//            catch { }
    }

        private void SizeTSComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int NewSize = Convert.ToInt32(SizeTSComboBox.Text);
                string SelectedText = TextEdit.SelectedText;
                int LengthSelectedText = TextEdit.SelectionLength;
                int SelectionStart = TextEdit.SelectionStart;

                LastSize = NewSize;
                for (int i = 0; i <= LengthSelectedText; i++)
                {
                    if (LengthSelectedText != 0) TextEdit.Select(SelectionStart + i, 1);
                    if (TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    else if (TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic && !TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Bold | FontStyle.Italic);
                    else if (TextEdit.SelectionFont.Bold && !TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Bold | FontStyle.Underline);
                    else if (!TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Italic | FontStyle.Underline);
                    else if (!TextEdit.SelectionFont.Bold && !TextEdit.SelectionFont.Italic && TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Underline);
                    else if (!TextEdit.SelectionFont.Bold && TextEdit.SelectionFont.Italic &&

                    !TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Italic);
                    else if (TextEdit.SelectionFont.Bold && !TextEdit.SelectionFont.Italic && !TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize, FontStyle.Bold);
                    else if (!TextEdit.SelectionFont.Bold && !TextEdit.SelectionFont.Italic && !TextEdit.SelectionFont.Underline)
                        TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, NewSize);
                    if (LengthSelectedText == 0) break;
                }

                TextEdit.Select(SelectionStart, LengthSelectedText);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Число должно находиться в диапазоне от 1 до 1638.", "Текстовый редактор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вводимое значение должно быть числом.", "Текстовый редактор.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel) return;
            TextEdit.SelectionFont = fontDialog1.Font;
            TextEdit.SelectionColor = fontDialog1.Color;
            SizeTSComboBox.Text = Convert.ToString(Convert.ToInt16(TextEdit.SelectionFont.SizeInPoints));//.ToString();  // TextEdit.SelectionFont.FontFamily, 
            izm = TextEdit.CanUndo;
            BoldToolStripButton.Checked = TextEdit.SelectionFont.Bold;
            if (TextEdit.SelectionFont == null) return;
            ItalicToolStripButton.Checked = TextEdit.SelectionFont.Italic;
            if (TextEdit.SelectionFont == null) return;
            UnderLineToolStripButton.Checked = TextEdit.SelectionFont.Underline;
        }

        private void правоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionAlignment == HorizontalAlignment.Right)
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Left;
                CeterToolStripButton.Checked = false;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = true;
                правоToolStripMenuItem.Checked = false;
                левыйToolStripMenuItem.Checked = true;
                центрToolStripMenuItem.Checked = false;
            }
            else
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Right;
                CeterToolStripButton.Checked = false;
                RightToolStripButton.Checked = true;
                LeftToolStripButton.Checked = false;
                правоToolStripMenuItem.Checked = true;
                левыйToolStripMenuItem.Checked = false;
                центрToolStripMenuItem.Checked = false;
            }
        }

        private void центрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionAlignment == HorizontalAlignment.Center)
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Left;
                CeterToolStripButton.Checked = false;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = true;
                правоToolStripMenuItem.Checked = false;
                левыйToolStripMenuItem.Checked = true;
                центрToolStripMenuItem.Checked = false;
            }

            else
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Center;

                CeterToolStripButton.Checked = true;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = false;
                правоToolStripMenuItem.Checked = false;
                левыйToolStripMenuItem.Checked = false;
                центрToolStripMenuItem.Checked = true;
            }
        }

        private void левыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.SelectionAlignment = HorizontalAlignment.Left;
            CeterToolStripButton.Checked = false;
            RightToolStripButton.Checked = false;
            LeftToolStripButton.Checked = true;
            правоToolStripMenuItem.Checked = false;
            левыйToolStripMenuItem.Checked = true;
            центрToolStripMenuItem.Checked = false;
        }

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            if (izm)
            {
                DialogResult dr = MessageBox.Show("Хотите сохранить изменения в файле?",
                      "Выход", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            if (s != "") TextEdit.SaveFile(s);
                            else
                            {
                                saveFileDialog1.Filter = "RTF files|*.rtf";
                                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                {
                                    TextEdit.SaveFile(saveFileDialog1.FileName);
                                    s = saveFileDialog1.FileName;
                                    izm = true;
                                }
                            }
                        }
                        break;
                    case DialogResult.No: break;
               
                }
                this.Hide();
                MainForm f = new MainForm();
                f.Show();
            }
        }
    }
}
