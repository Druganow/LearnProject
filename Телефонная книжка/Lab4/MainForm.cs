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

namespace Lab4
{
    public partial class MainForm : Form
    {
        bool change = false;
        private List<Note> PhoneNote;
        private int current;
        public MainForm()
        {
            InitializeComponent();
            PhoneNote = new List<Note>();
            current = -1;
            
            OpenFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            SaveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void PrintElement()
        {
            if ((current >= 0) && (current < PhoneNote.Count))
            {
                //если есть что выводить
                //MyRecord - запись списка PhoneNote
                //с номером current
                Note MyRecord = PhoneNote[current];
                //записываем в соответствующие элементы на форме
                //поля из записи MyRecord
                LastNameTextBox.Text = MyRecord.LastName;
                NameTextBox.Text = MyRecord.Name;
                PatronymicTextBox.Text = MyRecord.Patronymic;
                PhoneMaskedTextBox.Text = MyRecord.Phone;
                StreetTextBox.Text = MyRecord.Street;
                HouseNumericUpDown.Value = MyRecord.House;
                FlatNumericUpDown.Value = MyRecord.Flat;
            }
            else //если current равно -1, т. е. список пуст
            {
                //очистить поля формы
                LastNameTextBox.Text = "";
                NameTextBox.Text = "";
                PatronymicTextBox.Text = "";
                PhoneMaskedTextBox.Text = "";
                StreetTextBox.Text = "";
                HouseNumericUpDown.Value = 1;
                FlatNumericUpDown.Value = 1;
            }
            //обновление строки состояния
            NumberToolStripStatusLabel.Text = (current + 1).ToString();
            QuantityToolStripStatusLabel.Text = PhoneNote.Count.ToString();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change = true;
            //создаем запись - экземпляр класса Note
            Note MyRecord = new Note();
            //создаем экземпляр формы AddForm
            //AddForm _AddForm = new AddForm(MyRecord);
            AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Add, PhoneNote);
            //открываем форму для добавления записи
            _AddForm.ShowDialog();
            //текущей записью становится последняя
            current = PhoneNote.Count;
            //добавляем к списку PhoneNote новый элемент -
            //запись MyRecord, взятую из формы AddForm
                if(_AddForm.MyRecord.Phone!=null)
            {
             PhoneNote.Add(_AddForm.MyRecord);
            //выводим текущий элемент
            PrintElement();
                if (PhoneNote.Count != 0)
                {
                    if (current > PhoneNote.Count) current--;
                    PrintElement();
                    if (PhoneNote.Count != 0)
                    {
                        удалитьToolStripMenuItem.Enabled = true;
                        изменитьToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        удалитьToolStripMenuItem.Enabled = false;
                        изменитьToolStripMenuItem.Enabled = false;
                    }
                }
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if(PhoneNote.Count !=0)
            {
if (current == 0)
            {
                current = PhoneNote.Count - 1;
            }
            else
            {
                current--; //уменьшаем номер текущей записи на 1
            }
            PrintElement(); //выводим элемент с номером current
            }
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count != 0)
            {
if (current == PhoneNote.Count - 1)
            {
                current = 0;
                PrintElement();
            }
            else
            {
                current++; //уменьшаем номер текущей записи на 1
                PrintElement(); //выводим элемент с номером current
            }
            }
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            //если в диалоговом окне нажали ОК
            {
                try //обработчик исключительных ситуаций
                {
                    //используя sw (экземпляр класса StreamWriter),
                    //создаем файл с заданным
                    //в диалоговом окне именем
                    using (StreamWriter sw = new StreamWriter(SaveFileDialog.FileName))
                    {
                        //проходим по всем элементам списка
                        foreach (Note MyRecord in PhoneNote)
                        {
                            //записываем каждое поле
                            //в отдельной строке
                            sw.WriteLine(MyRecord.LastName);
                            sw.WriteLine(MyRecord.Name);
                            sw.WriteLine(MyRecord.Patronymic);
                            sw.WriteLine(MyRecord.Street);
                            sw.WriteLine(MyRecord.House);
                            sw.WriteLine(MyRecord.Flat);
                            sw.WriteLine(MyRecord.Phone);
                        }
                    }
                    change = false;
                }
                catch (Exception ex) //перехватываем ошибку
                {
                    //выводим информацию об ошибке
                    MessageBox.Show("Не удалось сохранить данные! Ошибка: " + ex.Message);
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note MyRecord;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            { //если в диалоговом окне нажали ОК
                try //обработчик исключительных ситуаций
                {
                    //считываем из указанного в диалоговом окне файла
                    using (StreamReader sr = new StreamReader(OpenFileDialog.FileName))
                    {
                        //пока не дошли до конца файла
                        while (!sr.EndOfStream)
                        {
                            bool b = true;
                            MyRecord = new Note();
                            //считываем значения полей записи
                            MyRecord.LastName = sr.ReadLine();
                            MyRecord.Name = sr.ReadLine();
                            MyRecord.Patronymic = sr.ReadLine();
                            MyRecord.Street = sr.ReadLine();
                            MyRecord.House = ushort.Parse(sr.ReadLine());
                            MyRecord.Flat = ushort.Parse(sr.ReadLine());
                            MyRecord.Phone = sr.ReadLine();
                            //добавляем запись в список
                            //PhoneNote.Add(MyRecord);
                          
                            foreach (Note Record in PhoneNote)
                            {
                                if (Record.Phone.Contains(MyRecord.Phone)) b = false;
                            }
                            if (b)
                            {
                                PhoneNote.Add(MyRecord);
                            }
                        }
                    }
                    //если список пуст, current устанавливаем в -1,
                    //иначе текущей является первая с начала запись
                    //(номер 0)
                    if (PhoneNote.Count == 0) current = -1;
                    else current = 0;
                    //выводим текущий элемент
                    PrintElement();
                }
                catch (Exception ex) //если произошла ошибка
                {
                    //выводим сообщение об ошибке
                    MessageBox.Show("При открытии файла произошла ошибка: " + ex.Message);
                }

            }
            if (PhoneNote.Count != 0)
            {
                if (current > PhoneNote.Count) current--;
                PrintElement();
                if (PhoneNote.Count != 0)
                {
                    удалитьToolStripMenuItem.Enabled = true;
                    изменитьToolStripMenuItem.Enabled = true;
                }
                else
                {
                    удалитьToolStripMenuItem.Enabled = false;
                    изменитьToolStripMenuItem.Enabled = false;
                }
            }
            поФамилииToolStripMenuItem.Checked = false;
            поИмениToolStripMenuItem.Checked = false;
            поОтчествуToolStripMenuItem.Checked = false;
            поУлицеToolStripMenuItem.Checked = false;
            поДомуToolStripMenuItem.Checked = false;
            поКвартиреToolStripMenuItem.Checked = false;
            поТелефонуToolStripMenuItem1.Checked = false;

            поФамилииToolStripMenuItem.Text = "по Фамилии";
            поИмениToolStripMenuItem.Text = "по Имени";
            поОтчествуToolStripMenuItem.Text = "по Отчеству";
            поУлицеToolStripMenuItem.Text = "по Улице";
            поДомуToolStripMenuItem.Text = "по Дому";
            поКвартиреToolStripMenuItem.Text = "по Квартире";
            поТелефонуToolStripMenuItem1.Text = "по Телефону";
        }

        private void поФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchNameForm _Search = new SearchNameForm(PhoneNote);
            _Search.ShowDialog();
        }

        private void поФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!поФамилииToolStripMenuItem.Checked == true)
            {
                поФамилииToolStripMenuItem.Checked = true;
                поИмениToolStripMenuItem.Checked = false;
                поОтчествуToolStripMenuItem.Checked = false;
                поУлицеToolStripMenuItem.Checked = false;
                поДомуToolStripMenuItem.Checked = false;
                поКвартиреToolStripMenuItem.Checked = false;
                поТелефонуToolStripMenuItem1.Checked = false;

                поФамилииToolStripMenuItem.Text = "по Фамилии ↓";
                поИмениToolStripMenuItem.Text = "по Имени";
                поОтчествуToolStripMenuItem.Text = "по Отчеству";
                поУлицеToolStripMenuItem.Text = "по Улице";
                поДомуToolStripMenuItem.Text = "по Дому";
                поКвартиреToolStripMenuItem.Text = "по Квартире";
                поТелефонуToolStripMenuItem1.Text = "по Телефону";

                if (PhoneNote.Count > 0) //если список не пуст
                {
                   change = true;
                   //сортировка списка по фамилии
                   PhoneNote.Sort(new CompareByLastName());
                   current = 0; //задаем номер текущего элемента
                   PrintElement(); //вывод текущего элемента
                }
            }
            else
            {
if (поФамилииToolStripMenuItem.Text == "по Фамилии ↓")
            {
                поФамилииToolStripMenuItem.Text = "по Фамилии ↑";
            }
            else поФамилииToolStripMenuItem.Text = "по Фамилии ↓";
            PhoneNote.Reverse();
            }
            PrintElement();
        }

        private void поКвартиреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!поКвартиреToolStripMenuItem.Checked == true)
            {
                поФамилииToolStripMenuItem.Checked = false;
                поИмениToolStripMenuItem.Checked = false;
                поОтчествуToolStripMenuItem.Checked = false;
                поУлицеToolStripMenuItem.Checked = false;
                поДомуToolStripMenuItem.Checked = false;
                поКвартиреToolStripMenuItem.Checked = true;
                поТелефонуToolStripMenuItem1.Checked = false;

                поФамилииToolStripMenuItem.Text = "по Фамилии";
                поИмениToolStripMenuItem.Text = "по Имени";
                поОтчествуToolStripMenuItem.Text = "по Отчеству";
                поУлицеToolStripMenuItem.Text = "по Улице";
                поДомуToolStripMenuItem.Text = "по Дому";
                поКвартиреToolStripMenuItem.Text = "по Квартире ↓";
                поТелефонуToolStripMenuItem1.Text = "по Телефону";

                if (PhoneNote.Count > 0) //если список не пуст
                {
                    change = true;
                    //сортировка списка по фамилии
                    PhoneNote.Sort(new CompareByFlat());
                    current = 0; //задаем номер текущего элемента
                    PrintElement(); //вывод текущего элемента
                }
            }
            else
            {
                if (поКвартиреToolStripMenuItem.Text == "по Квартире ↓")
                {
                    поКвартиреToolStripMenuItem.Text = "по Квартире ↑";
                }
                else поКвартиреToolStripMenuItem.Text = "по Квартире ↓";
                PhoneNote.Reverse();
            }
            PrintElement();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                change = true;
                //создаем запись - экземпляр класса Note
                Note MyRecord = new Note();
                //определяем поля записи (берем значения
                //из соответствующих компонентов на форме)
                MyRecord.LastName = LastNameTextBox.Text;
                MyRecord.Name = NameTextBox.Text;
                MyRecord.Patronymic = PatronymicTextBox.Text;
                MyRecord.Phone = PhoneMaskedTextBox.Text;
                MyRecord.Street = StreetTextBox.Text;
                MyRecord.House = (ushort)HouseNumericUpDown.Value;
                MyRecord.Flat = (ushort)FlatNumericUpDown.Value;
                //создаем экземпляр формы и открываем эту форму
                AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Edit, PhoneNote);
                _AddForm.ShowDialog();
                //изменяем текущую запись
                PhoneNote[current] = _AddForm.MyRecord;
            }
            PrintElement();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (change && PhoneNote.Count!=0)
            {
                DialogResult result = MessageBox.Show("Сохранить текущие изменения?", "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) сохранитьToolStripMenuItem_Click(sender, e);
                else if (result == DialogResult.Cancel) e.Cancel = true;
            }

        }

        private void поАдресуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAdresForm _Search = new SearchAdresForm(PhoneNote);
            _Search.ShowDialog();
        }

        private void поТелефонуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPhoneNumber _Search = new SearchPhoneNumber(PhoneNote);
            _Search.ShowDialog();
        }

        private void поИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!поИмениToolStripMenuItem.Checked == true)
            {
                поФамилииToolStripMenuItem.Checked = false;
                поИмениToolStripMenuItem.Checked = true;
                поОтчествуToolStripMenuItem.Checked = false;
                поУлицеToolStripMenuItem.Checked = false;
                поДомуToolStripMenuItem.Checked = false;
                поКвартиреToolStripMenuItem.Checked = false;
                поТелефонуToolStripMenuItem1.Checked = false;

                поФамилииToolStripMenuItem.Text = "по Фамилии";
                поИмениToolStripMenuItem.Text = "по Имени ↓";
                поОтчествуToolStripMenuItem.Text = "по Отчеству";
                поУлицеToolStripMenuItem.Text = "по Улице";
                поДомуToolStripMenuItem.Text = "по Дому";
                поКвартиреToolStripMenuItem.Text = "по Квартире";
                поТелефонуToolStripMenuItem1.Text = "по Телефону";

                if (PhoneNote.Count > 0) //если список не пуст
                {
                    change = true;
                    //сортировка списка по фамилии
                    PhoneNote.Sort(new CompareByName());
                    current = 0; //задаем номер текущего элемента
                    PrintElement(); //вывод текущего элемента
                }
            }
            else
            {
                if (поИмениToolStripMenuItem.Text == "по Имени ↓")
                {
                    поИмениToolStripMenuItem.Text = "по Имени ↑";
                }
                else поИмениToolStripMenuItem.Text = "по Имени ↓";
                PhoneNote.Reverse();
            }
            PrintElement();
            
        }

        private void поУлицеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!поУлицеToolStripMenuItem.Checked == true)
            {
                поФамилииToolStripMenuItem.Checked = false;
                поИмениToolStripMenuItem.Checked = false;
                поОтчествуToolStripMenuItem.Checked = false;
                поУлицеToolStripMenuItem.Checked = true;
                поДомуToolStripMenuItem.Checked = false;
                поКвартиреToolStripMenuItem.Checked = false;
                поТелефонуToolStripMenuItem1.Checked = false;

                поФамилииToolStripMenuItem.Text = "по Фамилии";
                поИмениToolStripMenuItem.Text = "по Имени";
                поОтчествуToolStripMenuItem.Text = "по Отчеству";
                поУлицеToolStripMenuItem.Text = "по Улице ↓";
                поДомуToolStripMenuItem.Text = "по Дому";
                поКвартиреToolStripMenuItem.Text = "по Квартире";
                поТелефонуToolStripMenuItem1.Text = "по Телефону";

                if (PhoneNote.Count > 0) //если список не пуст
                {
                    change = true;
                    //сортировка списка по фамилии
                    PhoneNote.Sort(new CompareByStreet());
                    current = 0; //задаем номер текущего элемента
                    PrintElement(); //вывод текущего элемента
                }
            }
            else
            {
                if (поУлицеToolStripMenuItem.Text == "по Улице ↓")
                {
                    поУлицеToolStripMenuItem.Text = "по Улице ↑";
                }
                else поУлицеToolStripMenuItem.Text = "по Улице ↓";
                PhoneNote.Reverse();
            }
            PrintElement();
            
        }

        private void поДомуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!поДомуToolStripMenuItem.Checked == true)
            {
                поФамилииToolStripMenuItem.Checked = false;
                поИмениToolStripMenuItem.Checked = false;
                поОтчествуToolStripMenuItem.Checked = false;
                поУлицеToolStripMenuItem.Checked = false;
                поДомуToolStripMenuItem.Checked = true;
                поКвартиреToolStripMenuItem.Checked = false;
                поТелефонуToolStripMenuItem1.Checked = false;

                поФамилииToolStripMenuItem.Text = "по Фамилии";
                поИмениToolStripMenuItem.Text = "по Имени";
                поОтчествуToolStripMenuItem.Text = "по Отчеству";
                поУлицеToolStripMenuItem.Text = "по Улице";
                поДомуToolStripMenuItem.Text = "по Дому ↓";
                поКвартиреToolStripMenuItem.Text = "по Квартире";
                поТелефонуToolStripMenuItem1.Text = "по Телефону";

                if (PhoneNote.Count > 0) //если список не пуст
                {
                    change = true;
                    //сортировка списка по фамилии
                    PhoneNote.Sort(new CompareByHouse());
                    current = 0; //задаем номер текущего элемента
                    PrintElement(); //вывод текущего элемента
                }
            }
            else
            {
                if (поДомуToolStripMenuItem.Text == "по Дому ↓")
                {
                    поДомуToolStripMenuItem.Text = "по Дому ↑";
                }
                else поДомуToolStripMenuItem.Text = "по Дому ↓";
                PhoneNote.Reverse();
            }
            PrintElement();
        }

        private void поТелефонуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!поТелефонуToolStripMenuItem1.Checked == true)
            {
                поФамилииToolStripMenuItem.Checked = false;
                поИмениToolStripMenuItem.Checked = false;
                поОтчествуToolStripMenuItem.Checked = false;
                поУлицеToolStripMenuItem.Checked = false;
                поДомуToolStripMenuItem.Checked = false;
                поКвартиреToolStripMenuItem.Checked = false;
                поТелефонуToolStripMenuItem1.Checked = true;

                поФамилииToolStripMenuItem.Text = "по Фамилии";
                поИмениToolStripMenuItem.Text = "по Имени";
                поОтчествуToolStripMenuItem.Text = "по Отчеству";
                поУлицеToolStripMenuItem.Text = "по Улице";
                поДомуToolStripMenuItem.Text = "по Дому";
                поКвартиреToolStripMenuItem.Text = "по Квартире";
                поТелефонуToolStripMenuItem1.Text = "по Телефону ↓";

                if (PhoneNote.Count > 0) //если список не пуст
                {
                    change = true;
                    //сортировка списка по фамилии
                    PhoneNote.Sort(new CompareByPhone());
                    current = 0; //задаем номер текущего элемента
                    PrintElement(); //вывод текущего элемента
                }
            }
            else
            {
                if (поТелефонуToolStripMenuItem1.Text == "по Телефону ↓")
                {
                    поТелефонуToolStripMenuItem1.Text = "по Телефону ↑";
                }
                else поТелефонуToolStripMenuItem1.Text = "по Телефону ↓";
                PhoneNote.Reverse();
            }
            PrintElement();
        }

        private void поОтчествуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!поОтчествуToolStripMenuItem.Checked == true)
            {
                поФамилииToolStripMenuItem.Checked = false;
                поИмениToolStripMenuItem.Checked = false;
                поОтчествуToolStripMenuItem.Checked = true;
                поУлицеToolStripMenuItem.Checked = false;
                поДомуToolStripMenuItem.Checked = false;
                поКвартиреToolStripMenuItem.Checked = false;
                поТелефонуToolStripMenuItem1.Checked = false;

                поФамилииToolStripMenuItem.Text = "по Фамилии";
                поИмениToolStripMenuItem.Text = "по Имени";
                поОтчествуToolStripMenuItem.Text = "по Отчеству ↓";
                поУлицеToolStripMenuItem.Text = "по Улице";
                поДомуToolStripMenuItem.Text = "по Дому";
                поКвартиреToolStripMenuItem.Text = "по Квартире";
                поТелефонуToolStripMenuItem1.Text = "по Телефону";

                if (PhoneNote.Count > 0) //если список не пуст
                {
                    change = true;
                    //сортировка списка по фамилии
                    PhoneNote.Sort(new CompareByPatronymic());
                    current = 0; //задаем номер текущего элемента
                    PrintElement(); //вывод текущего элемента
                }
            }
            else
            {
                if (поОтчествуToolStripMenuItem.Text == "по Отчеству ↓")
                {
                    поОтчествуToolStripMenuItem.Text = "по Отчеству ↑";
                }
                else поОтчествуToolStripMenuItem.Text = "по Отчеству ↓";
                PhoneNote.Reverse();
            }
            PrintElement();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PhoneNote.Count != 0)
            {
                change = true;
                PhoneNote.RemoveAt(current);
                if(current>= PhoneNote.Count)current--;
                PrintElement();
                if (PhoneNote.Count != 0)
                {
                    удалитьToolStripMenuItem.Enabled = true;
                    изменитьToolStripMenuItem.Enabled = true;
                }
                else
                {
                    удалитьToolStripMenuItem.Enabled = false;
                    изменитьToolStripMenuItem.Enabled = false;
                }
            }
            
        }
    }

    class CompareByLastName : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.LastName, y.LastName);
        }
        #endregion
    }

    class CompareByName : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Name, y.Name);
        }
        #endregion
    }

    class CompareByPatronymic : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Patronymic, y.Patronymic);
        }
        #endregion
    }

    class CompareByStreet : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Street, y.Street);
        }
        #endregion
    }

    class CompareByFlat : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return x.Flat.CompareTo(y.Flat);
        }
        #endregion
    }

    class CompareByHouse : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return x.House.CompareTo(y.House);
        }
        #endregion
    }

    class CompareByPhone : IComparer<Note>
    {
        #region IComparer<Note> Members
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Phone, y.Phone);
        }
        #endregion
    }

    public enum AddOrEdit
    {
        Add,
        Edit
    }
}
