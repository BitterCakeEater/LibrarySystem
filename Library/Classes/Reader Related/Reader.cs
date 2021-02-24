using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes.Book_Related;

namespace Library.Classes.Reader_Related
{
    [Serializable]
    class Reader
    {
        //Reader's info
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Card_Number { get; set; }
        public DateTime Issue_Date { get; set; }
        //Reader's books list
        private List<Book> Reader_Books;

       

        public Reader(string surname, string name, string patronymic, int card_number, DateTime issue_date)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Card_Number = card_number;
            Issue_Date = issue_date;

            Reader_Books = new List<Book>();
        }


        public List<Book> Get_Reader_Books()
        {
            return Reader_Books;
        }


        public void Add_Reader_Books(string title, string authors, string library_cipher, int publishing_year, string publishing_place, string publisher_name, int number)
        {
            Reader_Books.Add(new Book(title, authors, library_cipher, publishing_year, publishing_place, publisher_name, number));
        }
        

        public void Delete_Reader_Book(string library_cipher, int number)
        {
            Reader_Books.Remove(Reader_Books.Find(getInfo => getInfo.Library_Cipher == library_cipher &&  getInfo.Number == number));
        }


        public void Delete_Reader_Book(Book Book_To_Delete)
        {
            Reader_Books.Remove(Book_To_Delete);
        }
    }
}
