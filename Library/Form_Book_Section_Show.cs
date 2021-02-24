using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Classes.Book_Related;

namespace Library
{
    partial class Form_Book_Section_Show : Form
    {
        public LibraryGUI MainForm { get; set; }
        public List<Book> Books_List { get; set; }



        public Form_Book_Section_Show()
        {
            InitializeComponent();
        }


        public void Set_Data(BookSection Displayed_Book_Section)
        {
            richTextBox_Title.Text = Displayed_Book_Section.Title;
            richTextBox_Author.Text = Displayed_Book_Section.Authors;
            richTextBox_Cipher.Text = Displayed_Book_Section.Library_Cipher;
            richTextBox_Year.Text = Convert.ToString(Displayed_Book_Section.Publishing_Year);
            textBox_Amount.Text = Convert.ToString(Displayed_Book_Section.Copies_Amount);
            textBox_Available.Text = Convert.ToString(Displayed_Book_Section.Copies_Available);

            dataGridView_Copies.Rows.Clear();

            Books_List = Displayed_Book_Section.Get_Books_Copies();

            Set_dataGridView_Copies();
        }


        public void Set_dataGridView_Copies()
        {
            dataGridView_Copies.Rows.Clear();

            int Books_List_Size = Books_List.Count;

            for (int i = 0; i < Books_List_Size; i++)
            {
                dataGridView_Copies.Rows.Add();

                dataGridView_Copies.Rows[i].Cells[0].Value = Books_List[i].Number;

                if (Books_List[i].Is_Available == true)
                {
                    dataGridView_Copies.Rows[i].Cells[1].Value = "В бібліотеці";
                    dataGridView_Copies.Rows[i].Cells[2].Value = "-";
                    dataGridView_Copies.Rows[i].Cells[3].Value = "-";
                    dataGridView_Copies.Rows[i].Cells[4].Value = "-";
                }
                else
                {
                    dataGridView_Copies.Rows[i].Cells[1].Value = "Запозичена";

                    var Card_Record = Books_List[i].Story_Card.Get_Last_Record();

                    dataGridView_Copies.Rows[i].Cells[2].Value = Card_Record.Issue_Date.ToShortDateString();
                    dataGridView_Copies.Rows[i].Cells[3].Value = Card_Record.Term_Date.ToShortDateString();
                    dataGridView_Copies.Rows[i].Cells[4].Value = Card_Record.Reader_Card_Number;
                }
            }
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_Add_Book FAD = new Form_Add_Book();

            FAD.StartPosition = FormStartPosition.CenterParent;

            FAD.ShowDialog();

            if(FAD.DialogResult == DialogResult.OK)
            {
                MainForm.Add_Book(richTextBox_Cipher.Text, Convert.ToInt32(FAD.textBox1.Text));

                textBox_Amount.Text = Convert.ToString(MainForm.Get_Amount_Of_Books(richTextBox_Cipher.Text));
                textBox_Available.Text = Convert.ToString(MainForm.Get_Amount_Of_Available_Books(richTextBox_Cipher.Text));

                Set_dataGridView_Copies();
            }
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Copies.SelectedRows.Count > 0)
            {
                var selected = dataGridView_Copies.SelectedCells;
                string id = Convert.ToString(selected[0].Value);

                MainForm.Delete_Book(richTextBox_Cipher.Text, Convert.ToInt32(id));

                textBox_Amount.Text = Convert.ToString(MainForm.Get_Amount_Of_Books(richTextBox_Cipher.Text));
                textBox_Available.Text = Convert.ToString(MainForm.Get_Amount_Of_Available_Books(richTextBox_Cipher.Text));

                Set_dataGridView_Copies();
            }
        }


        private void button_Review_Click(object sender, EventArgs e)
        {
            if (dataGridView_Copies.SelectedRows.Count > 0)
            {
                var selected = dataGridView_Copies.SelectedCells;
                string id = Convert.ToString(selected[0].Value);
                string cipher = richTextBox_Cipher.Text;

                var card = Books_List.Find(getInfo => getInfo.Number == Convert.ToInt32(id)).Story_Card;

                Form_Card FC = new Form_Card();

                FC.StartPosition = FormStartPosition.CenterParent;

                if (card != null)
                {
                    FC.Set_Data(card, cipher, Convert.ToInt32(id));
                }

                FC.Show();
            }
        }

        private void button_Take_Click(object sender, EventArgs e)
        {
            var selected = dataGridView_Copies.SelectedCells;
            string id = Convert.ToString(selected[0].Value);
            string cipher = richTextBox_Cipher.Text;

            var card = Books_List.Find(getInfo => getInfo.Number == Convert.ToInt32(id)).Story_Card;

            if (card == null || card.Get_Record_List().Count == 0 || card.Get_Last_Record().Return_Date != DateTime.MinValue)
            {
                Form_Take_Book FTB = new Form_Take_Book();

                FTB.MainForm = this;
                FTB.StartPosition = FormStartPosition.CenterParent;

                FTB.ShowDialog();

                if(FTB.DialogResult == DialogResult.OK)
                {
                    MainForm.Take_Book(cipher, Convert.ToInt32(id), MainForm.Get_MainLibraryContainer().Get_Main_Registration_List().Get_Reader(Convert.ToInt32(FTB.textBox1.Text)).Surname, Convert.ToInt32(FTB.textBox1.Text));

                    Set_dataGridView_Copies();

                    textBox_Amount.Text = Convert.ToString(MainForm.Get_Amount_Of_Books(richTextBox_Cipher.Text));
                    textBox_Available.Text = Convert.ToString(MainForm.Get_Amount_Of_Available_Books(richTextBox_Cipher.Text));
                }
            }
            else
            {
                MessageBox.Show(
                    "Ця книга вже зайнята!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            var selected = dataGridView_Copies.SelectedCells;
            string id = Convert.ToString(selected[0].Value);
            string cipher = richTextBox_Cipher.Text;

            var card = Books_List.Find(getInfo => getInfo.Number == Convert.ToInt32(id)).Story_Card;

            if (card != null && card.Get_Record_List().Count != 0 && card.Get_Last_Record().Return_Date == DateTime.MinValue)
            {
                MainForm.Return_Book(cipher, Convert.ToInt32(id), MainForm.Get_MainLibraryContainer().Get_Main_Registration_List().Get_Reader(Convert.ToInt32(Convert.ToString(selected[4].Value))).Surname, Convert.ToInt32(Convert.ToString(selected[4].Value)));

                Set_dataGridView_Copies();

                textBox_Amount.Text = Convert.ToString(MainForm.Get_Amount_Of_Books(richTextBox_Cipher.Text));
                textBox_Available.Text = Convert.ToString(MainForm.Get_Amount_Of_Available_Books(richTextBox_Cipher.Text));           
            }
            else
            {
                MessageBox.Show(
                    "Ця книга не зайнята!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void Form_Book_Section_Show_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_Author_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Available_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
