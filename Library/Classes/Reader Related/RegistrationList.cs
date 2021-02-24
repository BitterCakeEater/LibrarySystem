using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes.Book_Related;

namespace Library.Classes.Reader_Related
{
    [Serializable]
    class RegistrationList
    {
        private List<Reader> List_Of_Readers;



        public RegistrationList()
        {
            List_Of_Readers = new List<Reader>();
        }


        public List<Reader> Get_List_Of_Readers()
        {
            return List_Of_Readers;
        }


        public Reader Get_Reader(int card_number)
        {
            Reader reader_to_return = List_Of_Readers.Find(getInfo => getInfo.Card_Number == card_number);

            return reader_to_return;
        }


        public void Add_Reader(string surname, string name, string patronymic, int card_number, DateTime issue_date)
        {
            List_Of_Readers.Add(new Reader(surname, name, patronymic, card_number, issue_date));
        }


        public bool Find_Reader(int card_number)
        {
            Reader reader_to_return = List_Of_Readers.Find(getInfo => getInfo.Card_Number == card_number);
            if (reader_to_return != null)
                return true;

            else
                return false;
        }
        

        public void Delete_Reader(int card_number)
        {
            Reader reader_to_remove = List_Of_Readers.Find(getInfo => getInfo.Card_Number == card_number);

            List_Of_Readers.Remove(reader_to_remove);
        }

        
        public void Repalce_Reader(int cur_card_number, string surname, string name, string patronymic, int card_number, DateTime issue_date)
        {
            int reader_id = List_Of_Readers.IndexOf(List_Of_Readers.Find(getInfo => getInfo.Card_Number == cur_card_number));

            List_Of_Readers[reader_id] = new Reader(surname, name, patronymic, card_number, issue_date);
        }

        
        public void Take_Book(Book Taken_Book, int reader_number)
        {
            List_Of_Readers[List_Of_Readers.IndexOf(List_Of_Readers.Find(getInfo => getInfo.Card_Number == reader_number))].Get_Reader_Books().Add(Taken_Book);
        }


        public void Return_Book(Book Taken_Book, int reader_number)
        {
            List_Of_Readers[List_Of_Readers.IndexOf(List_Of_Readers.Find(getInfo => getInfo.Card_Number == reader_number))].Delete_Reader_Book(Taken_Book);
        }
    }
}
