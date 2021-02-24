using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Book_Related
{
    [Serializable]
    class Catalog
    {
        private List<BookSection> Books_List;



        public Catalog()
        {
            Books_List = new List<BookSection>();
        }


        public List<BookSection> Get_Books_List()
        {
            return Books_List;
        }


        public BookSection Get_Book_Section(string library_cipher)
        {
            BookSection found = Books_List.Find(getinfo => getinfo.Library_Cipher == library_cipher);

            return found;
        }


        public Book Get_Book(string library_cipher, int number)
        {
            return Books_List[Books_List.FindIndex(getinfo => getinfo.Library_Cipher == library_cipher)].Get_Book(number);
        }


        public void Add_Book_Section(string title, string authors, string library_cipher, int publishing_year, string publishing_place, string publisher_name, int copies_amount, int copies_available)
        {
            Books_List.Add(new BookSection(title, authors, library_cipher, publishing_year, publishing_place, publisher_name, copies_amount, copies_available));
        }

        //Adds some book copies to certain book section
        public void Add_Books_Copies(string library_cipher, int amount_to_add)
        {
            Books_List[Books_List.FindIndex(getinfo => getinfo.Library_Cipher == library_cipher)].Add_Books_Copies(amount_to_add);
        }

        //Finds book title
        public bool Find_Book_Section(string title, string authors, int publishing_year, string publishing_place, string publisher_name)
        {
            BookSection found = Books_List.Find(getinfo => getinfo.Title == title && 
                                                           getinfo.Authors == authors && 
                                                           getinfo.Publishing_Year == publishing_year && 
                                                           getinfo.Publishing_Place == publishing_place && 
                                                           getinfo.Publisher_Name == publisher_name);

            if (found != null)
                return true;

            else
                return false;
        }

        
        public void Delete_Book_Section(string library_cipher)
        {
            BookSection section_to_remove = Books_List.Find(getinfo => getinfo.Library_Cipher == library_cipher);

            Books_List.Remove(section_to_remove);
        }

        
        public void Delete_Book(string library_cipher, int number)
        {
            Books_List[Books_List.FindIndex(getinfo => getinfo.Library_Cipher == library_cipher)].Delete_Book(number);
        }


        public bool Book_Is_Not_Taken(string library_cipher, int number)
        {
            var list = Books_List[Books_List.FindIndex(getinfo => getinfo.Library_Cipher == library_cipher)].Get_Books_Copies();

            return list[list.FindIndex(getInfo => getInfo.Number == number)].Is_Available;
        }


        public void Take_Book(string library_cipher, int number, string reader_name, int reader_number)
        {
            Books_List[Books_List.FindIndex(getInfo => getInfo.Library_Cipher == library_cipher)].Take_Book(number, reader_name, reader_number);              
        }


        public void Return_Book(string library_cipher, int number, string reader_name, int reader_number)
        {
            Books_List[Books_List.FindIndex(getInfo => getInfo.Library_Cipher == library_cipher)].Return_Book(number);
        }
    }
}
