using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Classes;

namespace Library
{
    public partial class Form_Add_Reader : Form
    {
        public Form_Add_Reader()
        {
            InitializeComponent();
        }


        private void button_Apply_Click(object sender, EventArgs e)
        {
            bool ok = true;
            int num;
            DateTime DT;

            foreach(char symbol in textBox_Surname.Text)
            {
                if (char.IsDigit(symbol))
                {
                    ok = false;

                    MessageBox.Show(
                        "Форма 'Прізвище' не може містити цифри!",
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                    break;
                }                   
            }

            foreach (char symbol in textBox_Name.Text)
            {
                if (char.IsDigit(symbol))
                {
                    ok = false;

                    MessageBox.Show(
                        "Форма 'Ім'я' не може містити цифри!",
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                    break;
                }
            }

            foreach (char symbol in textBox_Patronymic.Text)
            {
                if (char.IsDigit(symbol))
                {
                    ok = false;

                    MessageBox.Show(
                        "Форма 'По батькові' не може містити цифри!",
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                    break;
                }
            }

            try
            {
                num = Convert.ToInt32(textBox_Number.Text);
            }
            catch
            {
                ok = false;

                MessageBox.Show(
                    "Номер квитка повинен складатися тільки з цифр!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }

            try
            {
                DT = Convert.ToDateTime(textBox_Issue_Date.Text);
                if(DT.Date > DateTime.Now.Date)
                {
                    ok = false;

                    MessageBox.Show(
                        "Невірно вказана дата!",
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                ok = false;

                MessageBox.Show(
                    "Невірно вказана дата!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }

            if(ok == true)
                this.DialogResult = DialogResult.OK;
        }
    }
}
