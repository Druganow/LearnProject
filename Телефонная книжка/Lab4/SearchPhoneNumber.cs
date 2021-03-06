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
    public partial class SearchPhoneNumber : Form
    {
        List<Note> PhoneNote;
        public SearchPhoneNumber(List<Note> _PhoneNote)
        {
            InitializeComponent();
            PhoneNote = _PhoneNote;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //очищаем окно для вывода результатов
            ResultsTextBox.Text = "";
            //количество найденных результатов
            int i = 0;
            string s = "";
            for (int j = 0; j < PhoneMaskedTextBox.Text.Length; j++) if (Char.IsDigit(PhoneMaskedTextBox.Text[j])) s += PhoneMaskedTextBox.Text[j];
            //цикл for для каждого элемента списка - foreach
            foreach (Note MyRecord in PhoneNote)
            {
                string h = "";
                for (int j = 0; j < MyRecord.Phone.Length; j++) if (Char.IsDigit(MyRecord.Phone[j])) h += MyRecord.Phone[j];
                //если выполняются условия поиска
                if (h.Contains(s))
                {
                    //увеличиваем счетчик найденных записей
                    i++;
                    //дописываем элемент и его номер к результату
                    ResultsTextBox.Text = ResultsTextBox.Text + i.ToString() + ". " + MyRecord.LastName +
                    " " + MyRecord.Name + " " + MyRecord.Patronymic + ", ул. " +
                    MyRecord.Street + ", д." + MyRecord.House +
                    ", кв. " + MyRecord.Flat + ", тел. " + MyRecord.Phone + "\r\n";
                }
            }
            //если не найдено ни одной записи, выводим сообщение
            if (i == 0) ResultsTextBox.Text = "Записей, удовлетворяющих поставленным условиям, в списке абонентов нет!";
        }

    }
}