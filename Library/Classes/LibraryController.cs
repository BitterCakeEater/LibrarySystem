using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes.Book_Related;
using Library.Classes.Reader_Related;
using System.Windows.Forms;

namespace Library.Classes
{
    class LibraryController
    {
        public void Add_Reader(Form_Add_Reader FAR, ref LibraryContainer LibContainer)
        {
            FAR.StartPosition = FormStartPosition.CenterParent;
            FAR.ShowDialog();

            if(FAR.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //If reader number is already present
                if (LibContainer.Find_Reader(Convert.ToInt32(FAR.textBox_Number.Text)))
                {
                    MessageBox.Show(
                    "Читач з таким номером вже існує!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                    Form_Add_Reader New_FAR = new Form_Add_Reader();

                    New_FAR.textBox_Surname.Text = FAR.textBox_Surname.Text;
                    New_FAR.textBox_Name.Text = FAR.textBox_Name.Text;
                    New_FAR.textBox_Patronymic.Text = FAR.textBox_Patronymic.Text;
                    New_FAR.textBox_Number.Text = FAR.textBox_Number.Text;
                    New_FAR.textBox_Issue_Date.Text = FAR.textBox_Issue_Date.Text;
                    New_FAR.StartPosition = FormStartPosition.CenterParent;

                    Add_Reader(New_FAR, ref LibContainer);
                }
                else
                {
                    LibContainer.Add_Reader(FAR.textBox_Surname.Text, 
                                            FAR.textBox_Name.Text, 
                                            FAR.textBox_Patronymic.Text, 
                                            Convert.ToInt32(FAR.textBox_Number.Text), 
                                            Convert.ToDateTime(FAR.textBox_Issue_Date.Text));
                }
            }

            LibContainer.Save_Main_Registration_List();
        }


        public void Edit_Reader(Form_Add_Reader FAR, ref LibraryContainer LibContainer, int reader_id)
        {
            Reader reader = LibContainer.Get_Reader(reader_id);

            FAR.button_Apply.Text = "Змінити";
            FAR.textBox_Surname.Text = reader.Surname;
            FAR.textBox_Name.Text = reader.Name;
            FAR.textBox_Patronymic.Text = reader.Patronymic;
            FAR.textBox_Number.Text = Convert.ToString(reader.Card_Number);
            FAR.textBox_Issue_Date.Text = Convert.ToString(reader.Issue_Date.ToShortDateString());
            FAR.StartPosition = FormStartPosition.CenterParent;

            FAR.textBox_Number.ReadOnly = true;

            FAR.ShowDialog();

            if (FAR.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                LibContainer.Change_Reader(reader_id, 
                                            FAR.textBox_Surname.Text, 
                                            FAR.textBox_Name.Text, 
                                            FAR.textBox_Patronymic.Text, 
                                            Convert.ToInt32(FAR.textBox_Number.Text), 
                                            Convert.ToDateTime(FAR.textBox_Issue_Date.Text));

                LibContainer.Save_Main_Registration_List();
            }                
        }


        public void Delete_Reader(ref LibraryContainer LibContainer, int reader_id)
        {
            Form_Delete_Attention FDA = new Form_Delete_Attention();

            FDA.StartPosition = FormStartPosition.CenterParent;

            FDA.ShowDialog();
           
            if (FDA.DialogResult == DialogResult.Yes)
            {
                List<Book> found = LibContainer.Get_Main_Registration_List().Get_Reader(reader_id).Get_Reader_Books();
                if (found.Count > 0)
                {

                    foreach (var book in found)
                    {
                        Return_Book(ref LibContainer,
                                    book.Library_Cipher,
                                    book.Number,
                                    LibContainer.Get_Main_Registration_List().Get_Reader(reader_id).Surname,
                                    reader_id);

                        if (found.Count == 0)
                            break;
                    }
                }

                LibContainer.Delete_Reader(reader_id);

                LibContainer.Save_Main_Registration_List();
                LibContainer.Save_Main_Catalog();
            }
        }


        public void Add_Book_Section(Form_Add_Book_Section FABS, ref LibraryContainer LibContainer)
        {
            FABS.StartPosition = FormStartPosition.CenterParent;
            FABS.ShowDialog();

            if (FABS.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (LibContainer.Find_Book_Section(FABS.richTextBox_Title.Text, FABS.richTextBox_Authors.Text, Convert.ToInt32(FABS.richTextBox__Date.Text), FABS.richTextBox_Palce.Text, FABS.richTextBox_Publisher.Text))
                {
                    MessageBox.Show(
                    "Ідентична книга вже існує!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                    Form_Add_Book_Section New_FABS = new Form_Add_Book_Section();

                    New_FABS.richTextBox_Amount.Text = FABS.richTextBox_Amount.Text;
                    New_FABS.richTextBox_Authors.Text = FABS.richTextBox_Authors.Text;
                    New_FABS.richTextBox_Cipher.Text = FABS.richTextBox_Cipher.Text;
                    New_FABS.richTextBox_Palce.Text = FABS.richTextBox_Palce.Text;
                    New_FABS.richTextBox_Publisher.Text = FABS.richTextBox_Publisher.Text;
                    New_FABS.richTextBox_Title.Text = FABS.richTextBox_Title.Text;
                    New_FABS.richTextBox__Date.Text = FABS.richTextBox__Date.Text;
                    New_FABS.StartPosition = FormStartPosition.CenterParent;

                    Add_Book_Section(New_FABS, ref LibContainer);
                }

                else if(LibContainer.Get_Main_Catalog().Get_Book_Section(FABS.richTextBox_Cipher.Text) != null)
                {
                    MessageBox.Show(
                    "Книга з таким шифром вже існує!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                    Form_Add_Book_Section New_FABS = new Form_Add_Book_Section();

                    New_FABS.richTextBox_Amount.Text = FABS.richTextBox_Amount.Text;
                    New_FABS.richTextBox_Authors.Text = FABS.richTextBox_Authors.Text;
                    New_FABS.richTextBox_Cipher.Text = FABS.richTextBox_Cipher.Text;
                    New_FABS.richTextBox_Palce.Text = FABS.richTextBox_Palce.Text;
                    New_FABS.richTextBox_Publisher.Text = FABS.richTextBox_Publisher.Text;
                    New_FABS.richTextBox_Title.Text = FABS.richTextBox_Title.Text;
                    New_FABS.richTextBox__Date.Text = FABS.richTextBox__Date.Text;
                    New_FABS.StartPosition = FormStartPosition.CenterParent;

                    Add_Book_Section(New_FABS, ref LibContainer);
                }

                else
                    LibContainer.Add_Book_Section(FABS.richTextBox_Title.Text, 
                                                  FABS.richTextBox_Authors.Text, 
                                                  FABS.richTextBox_Cipher.Text, 
                                                  Convert.ToInt32(FABS.richTextBox__Date.Text), 
                                                  FABS.richTextBox_Palce.Text, FABS.richTextBox_Publisher.Text, 
                                                  Convert.ToInt32(FABS.richTextBox_Amount.Text), 
                                                  Convert.ToInt32(FABS.richTextBox_Amount.Text));

                LibContainer.Save_Main_Catalog();
            }
        }

        
        public void Delete_Book_Section(ref LibraryContainer LibContainer, string library_cipher)
        {
            Form_Delete_Attention FDA = new Form_Delete_Attention();

            FDA.StartPosition = FormStartPosition.CenterParent;

            FDA.label1.Text = "Ви дійсно бажаете видалити цей розділ книг?";

            FDA.ShowDialog();

            if (FDA.DialogResult == DialogResult.Yes)
            {
                foreach(var book in LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Get_Books_Copies())
                {
                    if (!LibContainer.Get_Main_Catalog().Book_Is_Not_Taken(library_cipher, book.Number))
                    {
                        LibContainer.Get_Main_Catalog().Return_Book(library_cipher, 
                                                                    book.Number, 
                                                                    book.Story_Card.Get_Last_Record().Reader_Name, 
                                                                    book.Story_Card.Get_Last_Record().Reader_Card_Number);

                        LibContainer.Get_Main_Registration_List().Return_Book(LibContainer.Get_Main_Catalog().Get_Book(library_cipher, book.Number), 
                                                                              book.Story_Card.Get_Last_Record().Reader_Card_Number);
                    }
                }

                LibContainer.Delete_Book_Section(library_cipher);

                LibContainer.Save_Main_Catalog();
                LibContainer.Save_Main_Registration_List();
            }
                
        }


        public List<BookSection> Find_Book(LibraryContainer LibContainer, string str_to_find)
        {
            List<BookSection> rez = new List<BookSection>();

            IEnumerable<BookSection> r = LibContainer.Get_Main_Catalog().
                                            Get_Books_List().Where(getInfo => 
                                                Convert.ToString(getInfo.Library_Cipher).Contains(str_to_find) || 
                                                Convert.ToString(getInfo.Title).Contains(str_to_find));

            rez = r.ToList<BookSection>();

            return rez;
        }


        public void Add_Book(ref LibraryContainer LibContainer, string library_cipher, int number)
        {
            LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Add_Books_Copies(number);

            LibContainer.Save_Main_Catalog();
        }


        public void Delete_Book(ref LibraryContainer LibContainer, string library_cipher, int number)
        {
            Form_Delete_Attention FDA = new Form_Delete_Attention();

            FDA.StartPosition = FormStartPosition.CenterParent;
            FDA.label1.Text = "Ви дійсно бажаете видалити цю книгу?";

            FDA.ShowDialog();

            if (FDA.DialogResult == DialogResult.Yes)
            {
                var book = LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Get_Book(number);

                if (!LibContainer.Get_Main_Catalog().Book_Is_Not_Taken(library_cipher, number))
                {
                    LibContainer.Get_Main_Catalog().Return_Book(library_cipher, 
                                                                number, 
                                                                book.Story_Card.Get_Last_Record().Reader_Name, 
                                                                book.Story_Card.Get_Last_Record().Reader_Card_Number);

                    LibContainer.Get_Main_Registration_List().Return_Book(LibContainer.Get_Main_Catalog().Get_Book(library_cipher, number), 
                                                                          book.Story_Card.Get_Last_Record().Reader_Card_Number);
                }

                LibContainer.Get_Main_Catalog().Delete_Book(library_cipher, number);

                LibContainer.Save_Main_Catalog();
                LibContainer.Save_Main_Registration_List();
            }              
        }


        public int Get_Amount_Of_Books(ref LibraryContainer LibContainer, string library_cipher)
        {
            return LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Copies_Amount;
        }


        public int Get_Amount_Of_Available_Books(ref LibraryContainer LibContainer, string library_cipher)
        {
            return LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Copies_Available;
        }


        public void Take_Book(ref LibraryContainer LibContainer, string library_cipher, int number, string reader_name, int reader_number)
        {
            if(LibContainer.Get_Main_Catalog().Book_Is_Not_Taken(library_cipher, number))
            {
                LibContainer.Get_Main_Catalog().Take_Book(library_cipher, number, reader_name, reader_number);

                LibContainer.Get_Main_Registration_List().Take_Book(LibContainer.Get_Main_Catalog().Get_Book(library_cipher, number), reader_number);

                LibContainer.Save_Main_Catalog();
                LibContainer.Save_Main_Registration_List();
            }          
        }

        
        public void Return_Book(ref LibraryContainer LibContainer, string library_cipher, int number, string reader_name, int reader_number)
        {
            if (!LibContainer.Get_Main_Catalog().Book_Is_Not_Taken(library_cipher, number))
            {
                LibContainer.Get_Main_Catalog().Return_Book(library_cipher, number, reader_name, reader_number);

                LibContainer.Get_Main_Registration_List().Return_Book(LibContainer.Get_Main_Catalog().Get_Book(library_cipher, number), reader_number);

                LibContainer.Save_Main_Catalog();
                LibContainer.Save_Main_Registration_List();
            }

        }


        public List<Book> Find_Books_By_Date(LibraryContainer LibContainer, DateTime from, DateTime to, bool taken)
        {
            List<Book> found = new List<Book>();

            foreach (var book_list in LibContainer.Get_Main_Catalog().Get_Books_List())

                foreach (var book in book_list.Get_Books_Copies())

                    foreach (var record in book.Story_Card.Get_Record_List())

                        if (taken == true)
                        {
                            if (record.Issue_Date.Date >= from.Date && record.Issue_Date.Date <= to.Date && !found.Contains(book))
                            {
                                found.Add(book);
                                break;
                            }
                        }
                        else
                            if (record.Return_Date.Date >= from.Date && record.Return_Date.Date <= to.Date && !found.Contains(book))
                            {
                                found.Add(book);
                                break;
                            }

            return found;
        }
    }
}
