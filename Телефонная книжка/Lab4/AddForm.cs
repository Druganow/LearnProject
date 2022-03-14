using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class AddForm : Form
    {
        public Note MyRecord;
        List<Note> PhoneNote;
        string s ;
        public AddForm(Note _MyRecord, AddOrEdit MyType, List<Note> _PhoneNote)
        {
            InitializeComponent();
            MyRecord = _MyRecord;
            PhoneNote = _PhoneNote;
            s = MyRecord.Phone;
            //если форма открыта для добавления
            if (MyType == AddOrEdit.Add)
            {
                Text = "Добавление абонента";
                AddButton.Text = "Добавить";
            }
            else //если форма открыта для изменения записи
            {
                Text = "Изменение абонента";
                AddButton.Text = "Изменить";
                //определяем значение компонентов на форме
                        LastNameTextBox.Text = MyRecord.LastName;
                        NameTextBox.Text = MyRecord.Name;
                        PatronymicTextBox.Text = MyRecord.Patronymic;
                        PhoneMaskedTextBox.Text = MyRecord.Phone;
                        StreetTextBox.Text = MyRecord.Street;
                        HouseNumericUpDown.Value = MyRecord.House;
                        FlatNumericUpDown.Value = MyRecord.Flat;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool b = false;
            if((LastNameTextBox.Text !="" || NameTextBox.Text != "" || PatronymicTextBox.Text != "") && CorrectNumber(PhoneMaskedTextBox.Text))
            {
                foreach (Note MyRecord in PhoneNote)
                {
                    if (MyRecord.Phone.Contains(PhoneMaskedTextBox.Text)) b = true;
                }
                if(b && PhoneMaskedTextBox.Text!=s) ErrorMessange.Text = "Абонент с таким номером уже существует";
                else
                {
                    //определяем поля записи - берем значения
                    //из соответствующих компонентов на форме
                    MyRecord.LastName = LastNameTextBox.Text;
                    MyRecord.Name = NameTextBox.Text;
                    MyRecord.Patronymic = PatronymicTextBox.Text;
                    MyRecord.Phone = PhoneMaskedTextBox.Text;
                    MyRecord.Street = StreetTextBox.Text;
                    MyRecord.House = (ushort)HouseNumericUpDown.Value;
                    MyRecord.Flat = (ushort)FlatNumericUpDown.Value;
                    Close(); //закрываем форму
                }
                
            }
            else
            {
                if (!CorrectNumber(PhoneMaskedTextBox.Text))ErrorMessange.Text = "Проверьте корректность номера телефона";
               else ErrorMessange.Text = "Хотя бы одно поле ФИО должно быть заполнено";

            }
        }
        static bool CorrectNumber(string s)
        {
            bool b = true;
            if (s.Length == 14)
            {
                for (int i = 6; i < 9; i++) if (!Char.IsDigit(s[i])) b = false;
                for (int i = 10; i <= 13; i++) if (!Char.IsDigit(s[i])) b = false;
                if (!((!Char.IsDigit(s[1]) && !Char.IsDigit(s[2]) && !Char.IsDigit(s[3])) || (Char.IsDigit(s[1]) && Char.IsDigit(s[2]) && Char.IsDigit(s[3])))) b = false;
            }
            else b = false;
            return b;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
