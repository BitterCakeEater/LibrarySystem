using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes.Book_Related;
using Library.Classes.Reader_Related;
using Library.Classes;

namespace Library.Classes
{
    class LibraryContainer
    {
        private RegistrationList Main_Registration_List;
        private Catalog Main_Catalog;



        public LibraryContainer()
        {
            Main_Registration_List = new RegistrationList();
            Main_Catalog = new Catalog();
        }


        public bool Save_Main_Registration_List()
        {
            return FileSystem.Save_Registration_List(Main_Registration_List);
        }


        public bool Load_Main_Registration_List()
        {
            return FileSystem.Load_Registration_List(ref Main_Registration_List);
        }


        public RegistrationList Get_Main_Registration_List()
        {
            return Main_Registration_List;
        }


        public Reader Get_Reader(int card_number)
        {
            return Main_Registration_List.Get_Reader(card_number);
        }


        public void Add_Reader(string surname, string name, string patronymic, int card_number, DateTime issue_date)//
        {
            Main_Registration_List.Add_Reader(surname, name, patronymic, card_number, issue_date);
        }

        
        public void Change_Reader(int cur_card_number, string surname, string name, string patronymic, int card_number, DateTime issue_date)
        {
            Main_Registration_List.Repalce_Reader(cur_card_number, surname, name, patronymic, card_number, issue_date);
        }


        public void Delete_Reader(int card_number)
        {
            Main_Registration_List.Delete_Reader(card_number);
        }


        public bool Find_Reader(int card_number)
        {
            return Main_Registration_List.Find_Reader(card_number);
        }


        public bool Save_Main_Catalog()
        {
            return FileSystem.Save_Catalog(Main_Catalog);
        }


        public bool Load_Main_Catalog()
        {
            return FileSystem.Load_Catalog(ref Main_Catalog);
        }


        public Catalog Get_Main_Catalog()
        {
            return Main_Catalog;
        }

        
        public bool Find_Book_Section(string title, string authors, int publishing_year, string publishing_place, string publisher_name)
        {
            return Main_Catalog.Find_Book_Section(title, authors, publishing_year, publishing_place, publisher_name);
        }

        
        public void Add_Book_Section(string title, string authors, string library_cipher, int publishing_year, string publishing_place, string publisher_name, int copies_amount, int copies_available)
        {
            Main_Catalog.Add_Book_Section(title, authors, library_cipher, publishing_year, publishing_place, publisher_name, copies_amount, copies_available);
        }

        
        public void Delete_Book_Section(string library_cipher)
        {
            Main_Catalog.Delete_Book_Section(library_cipher);
        }
    }
}
