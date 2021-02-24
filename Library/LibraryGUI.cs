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
using Library.Classes.Book_Related;
using Library.Classes.Reader_Related;

namespace Library
{
    partial class LibraryGUI : Form
    {
        private LibraryContainer MainLibraryContainer;
        private LibraryController MainLibraryController;



        public LibraryGUI()
        {
            MainLibraryContainer = new LibraryContainer();
            MainLibraryController = new LibraryController();
            InitializeComponent();

            MainLibraryContainer.Load_Main_Registration_List();
            MainLibraryContainer.Load_Main_Catalog();

            Set_dataGridView_Register();
            Set_dataGridView_Catalog();
        }

        public LibraryContainer Get_MainLibraryContainer()
        {
            return MainLibraryContainer;
        }


        public  LibraryController Get_MainLibraryController()
        {
            return MainLibraryController;
        }


        public void Set_dataGridView_Register()
        {
            dataGridView_Register.Rows.Clear();           

            List<Reader> list = MainLibraryContainer.Get_Main_Registration_List().Get_List_Of_Readers();

            int list_size = list.Count;

            for (int i = 0; i < list_size; i++)
            {
                dataGridView_Register.Rows.Add();

                dataGridView_Register.Rows[i].Cells[0].Value = list[i].Surname;
                dataGridView_Register.Rows[i].Cells[1].Value = list[i].Name;
                dataGridView_Register.Rows[i].Cells[2].Value = list[i].Patronymic;
                dataGridView_Register.Rows[i].Cells[3].Value = list[i].Card_Number;
                dataGridView_Register.Rows[i].Cells[4].Value = list[i].Issue_Date.ToShortDateString();
            }
        }


        public void Set_dataGridView_Catalog()
        {
            dataGridView_Catalog.Rows.Clear();

            List<BookSection> list = MainLibraryContainer.Get_Main_Catalog().Get_Books_List();

            int list_size = list.Count;

            for (int i = 0; i < list_size; i++)
            {
                dataGridView_Catalog.Rows.Add();

                dataGridView_Catalog.Rows[i].Cells[0].Value = list[i].Title;
                dataGridView_Catalog.Rows[i].Cells[1].Value = list[i].Authors;
                dataGridView_Catalog.Rows[i].Cells[2].Value = list[i].Library_Cipher;
                dataGridView_Catalog.Rows[i].Cells[3].Value = list[i].Publishing_Year;
                dataGridView_Catalog.Rows[i].Cells[4].Value = list[i].Publishing_Place;
                dataGridView_Catalog.Rows[i].Cells[5].Value = list[i].Publisher_Name;
                dataGridView_Catalog.Rows[i].Cells[6].Value = list[i].Copies_Amount;
                dataGridView_Catalog.Rows[i].Cells[7].Value = list[i].Copies_Available;
            }
        }


        private void button_Add_Reader_Click(object sender, EventArgs e)
        {
            Form_Add_Reader FAR = new Form_Add_Reader();

            MainLibraryController.Add_Reader(FAR, ref MainLibraryContainer);

            Set_dataGridView_Register();
        }


        private void button_Edit_Reader_Click(object sender, EventArgs e)
        {
            if (dataGridView_Register.SelectedRows.Count > 0)
            {
                var selected = dataGridView_Register.SelectedCells;
                int id = Convert.ToInt32(selected[3].Value);

                Form_Add_Reader FAR = new Form_Add_Reader();

                MainLibraryController.Edit_Reader(FAR, ref MainLibraryContainer, id);

                Set_dataGridView_Register();
            }
        }


        private void button_Delete_Reader_Click(object sender, EventArgs e)
        {
            if (dataGridView_Register.SelectedRows.Count > 0)
            {
                var selected = dataGridView_Register.SelectedCells;
                int id = Convert.ToInt32(selected[3].Value);

                MainLibraryController.Delete_Reader(ref MainLibraryContainer, id);

                Set_dataGridView_Register();
                Set_dataGridView_Catalog();
            }
        }


        private void button_Look_For_Books_Click(object sender, EventArgs e)
        {
            if (dataGridView_Register.SelectedRows.Count > 0)
            {
                var selected = dataGridView_Register.SelectedCells;
                int id = Convert.ToInt32(selected[3].Value);

                Form_Reader_Books FRB = new Form_Reader_Books();

                FRB.label_Card_Number.Text += Convert.ToString(id);

                FRB.dataGridView_Catalog.Rows.Clear();

                List<Book> list = MainLibraryContainer.Get_Main_Registration_List().Get_List_Of_Readers()
                                    [MainLibraryContainer.Get_Main_Registration_List().Get_List_Of_Readers()
                                    .IndexOf(MainLibraryContainer.Get_Main_Registration_List().Get_Reader(id))]
                                    .Get_Reader_Books();

                int list_size = list.Count;

                for (int i = 0; i < list_size; i++)
                {
                    FRB.dataGridView_Catalog.Rows.Add();

                    FRB.dataGridView_Catalog.Rows[i].Cells[0].Value = list[i].Title;
                    FRB.dataGridView_Catalog.Rows[i].Cells[1].Value = list[i].Authors;
                    FRB.dataGridView_Catalog.Rows[i].Cells[2].Value = list[i].Library_Cipher;
                    FRB.dataGridView_Catalog.Rows[i].Cells[3].Value = list[i].Number;
                    FRB.dataGridView_Catalog.Rows[i].Cells[4].Value = list[i].Publishing_Year;
                    FRB.dataGridView_Catalog.Rows[i].Cells[5].Value = list[i].Publishing_Place;
                    FRB.dataGridView_Catalog.Rows[i].Cells[6].Value = list[i].Publisher_Name;
                }

                FRB.ShowDialog();
            }
        }


        private void button_Add_Section_Click(object sender, EventArgs e)
        {
            Form_Add_Book_Section FABS = new Form_Add_Book_Section();

            MainLibraryController.Add_Book_Section(FABS, ref MainLibraryContainer);

            Set_dataGridView_Catalog();
        }


        private void button_Delete_Section_Click(object sender, EventArgs e)
        {
            if (dataGridView_Catalog.SelectedRows.Count > 0)
            {
                var selected = dataGridView_Catalog.SelectedCells;
                string id = Convert.ToString(selected[2].Value);

                MainLibraryController.Delete_Book_Section(ref MainLibraryContainer, id);

                Set_dataGridView_Catalog();
            }
        }


        private void button_Find_Click(object sender, EventArgs e)
        {
            if(textBox_Input_To_Find.TextLength != 0)
            {
                List<BookSection> Found_List = new List<BookSection>();
                Found_List = MainLibraryController.Find_Book(MainLibraryContainer, textBox_Input_To_Find.Text);

                dataGridView_Catalog.Rows.Clear();

                int list_size = Found_List.Count;

                for (int i = 0; i < list_size; i++)
                {
                    dataGridView_Catalog.Rows.Add();

                    dataGridView_Catalog.Rows[i].Cells[0].Value = Found_List[i].Title;
                    dataGridView_Catalog.Rows[i].Cells[1].Value = Found_List[i].Authors;
                    dataGridView_Catalog.Rows[i].Cells[2].Value = Found_List[i].Library_Cipher;
                    dataGridView_Catalog.Rows[i].Cells[3].Value = Found_List[i].Publishing_Year;
                    dataGridView_Catalog.Rows[i].Cells[4].Value = Found_List[i].Publishing_Place;
                    dataGridView_Catalog.Rows[i].Cells[5].Value = Found_List[i].Publisher_Name;
                    dataGridView_Catalog.Rows[i].Cells[6].Value = Found_List[i].Copies_Amount;
                    dataGridView_Catalog.Rows[i].Cells[7].Value = Found_List[i].Copies_Available;
                }
            }

            else
                Set_dataGridView_Catalog();
        }


        private void button_Info_Click(object sender, EventArgs e)
        {
            if (dataGridView_Catalog.SelectedRows.Count > 0)
            {
                Form_Book_Section_Show FBSS = new Form_Book_Section_Show();

                var selected = dataGridView_Catalog.SelectedCells;
                string id = Convert.ToString(selected[2].Value);

                FBSS.Set_Data(MainLibraryContainer.Get_Main_Catalog().Get_Book_Section(id));

                FBSS.MainForm = this;

                FBSS.Show();
            }
        }


        public void Add_Book(string library_cipher, int number)
        {
            MainLibraryController.Add_Book(ref MainLibraryContainer, library_cipher, number);

            Set_dataGridView_Catalog();
        }


        public void Delete_Book(string library_cipher, int number)
        {
            MainLibraryController.Delete_Book(ref MainLibraryContainer, library_cipher, number);

            Set_dataGridView_Catalog();
        }


        public int Get_Amount_Of_Books(string library_cipher)
        {
            return MainLibraryController.Get_Amount_Of_Books(ref MainLibraryContainer, library_cipher);
        }


        public int Get_Amount_Of_Available_Books(string library_cipher)
        {
            return MainLibraryController.Get_Amount_Of_Available_Books(ref MainLibraryContainer, library_cipher);
        }


        public void Take_Book(string library_cipher, int number, string reader_name, int reader_number)
        {
            MainLibraryController.Take_Book(ref MainLibraryContainer, library_cipher, number, reader_name, reader_number);

            Set_dataGridView_Catalog();
        }


        public void Return_Book(string library_cipher, int number, string reader_name, int reader_number)
        {
            MainLibraryController.Return_Book(ref MainLibraryContainer, library_cipher, number, reader_name, reader_number);

            Set_dataGridView_Catalog();
        }


        private void button_Find_Info_Click(object sender, EventArgs e)
        {
            List<Book> found_books = new List<Book>();

            if (radioButton_Issued_Books.Checked)
                found_books = MainLibraryController.Find_Books_By_Date(MainLibraryContainer, Convert.ToDateTime(dateTimePicker_First_Date.Text), Convert.ToDateTime(dateTimePicker_Second_Date.Text), true);

            else if (radioButton_Returned_Books.Checked)
                found_books = MainLibraryController.Find_Books_By_Date(MainLibraryContainer, Convert.ToDateTime(dateTimePicker_First_Date.Text), Convert.ToDateTime(dateTimePicker_Second_Date.Text), false);

            dataGridView_Books_Info.Rows.Clear();

            int list_size = found_books.Count;

            for (int i = 0; i < list_size; i++)
            {
                dataGridView_Books_Info.Rows.Add();

                dataGridView_Books_Info.Rows[i].Cells[0].Value = found_books[i].Title;
                dataGridView_Books_Info.Rows[i].Cells[1].Value = found_books[i].Authors;
                dataGridView_Books_Info.Rows[i].Cells[2].Value = found_books[i].Library_Cipher;
                dataGridView_Books_Info.Rows[i].Cells[3].Value = found_books[i].Number;
                dataGridView_Books_Info.Rows[i].Cells[4].Value = found_books[i].Publishing_Year;
                dataGridView_Books_Info.Rows[i].Cells[5].Value = found_books[i].Publishing_Place;
                dataGridView_Books_Info.Rows[i].Cells[6].Value = found_books[i].Publisher_Name;
            }
        }
    }
}
