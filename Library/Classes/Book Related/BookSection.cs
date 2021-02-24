using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Book_Related
{
    [Serializable]
    class BookSection
    {
        //Book info
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Library_Cipher { get; set; }
        public int Publishing_Year { get; set; }
        public string Publishing_Place { get; set; }
        public string Publisher_Name { get; set; }
        //Copies number info
        public int Copies_Amount { get; set; }
        public int Copies_Available { get; set; }
        //List of books
        private List<Book> Books_Copies;


        
        public BookSection(string title, string authors, string library_cipher, int publishing_year, string publishing_place, string publisher_name, int copies_amount, int copies_available)
        {
            Title = title;
            Authors = authors;
            Library_Cipher = library_cipher;
            Publishing_Year = publishing_year;
            Publishing_Place = publishing_place;
            Publisher_Name = publisher_name;
            Copies_Amount = copies_amount;
            Copies_Available = copies_available;

            Books_Copies = new List<Book>();
            Add_Books_Copies(Copies_Amount);
        }


        public Book Get_Book(int number)
        {
            Book book_to_return = Books_Copies.Find(getInfo => getInfo.Number == number);

            return book_to_return;
        }


        public List<Book> Get_Books_Copies()
        {
            return Books_Copies;
        }


        public void Add_Books_Copies(int count_of_books)
        {
            //if there are some copies in the list
            if (Books_Copies.Count == 0)
            {
                for (int i = 1; i <= count_of_books; i++)
                {
                    Book Book_To_Add = new Book(Title, Authors, Library_Cipher, Publishing_Year, Publishing_Place, Publisher_Name, i);

                    Books_Copies.Add(Book_To_Add);
                }
            }
            
            //if there is NO copies in the list
            else
            {
                Copies_Amount += count_of_books;

                for (int i = Books_Copies.Count + 1; i <= Copies_Amount; i++)
                {
                    Book Book_To_Add = new Book(Title, Authors, Library_Cipher, Publishing_Year, Publishing_Place, Publisher_Name, Books_Copies[i-2].Number + 1);

                    Books_Copies.Add(Book_To_Add);
                }
            }

            this.Copies_Available = Count_Available_Books();
        }


        public void Delete_Book(int number)
        {
            Book book_to_delete = Books_Copies.Find(getInfo => getInfo.Number == number);

            Books_Copies.Remove(book_to_delete);

            this.Copies_Amount = this.Copies_Amount - 1;

            this.Copies_Available = Count_Available_Books();
        }


        public int Count_Available_Books()
        {
            int counter = 0;
            foreach(Book b in Books_Copies)
            {
                if(b.Is_Available == true)
                {
                    counter++;
                }
            }
            return counter;
        }


        public void Take_Book(int number, string reader_name, int reader_number)
        {
            int rnum = reader_number;

            Book Got_Book = Books_Copies[Books_Copies.FindIndex(getInfo => getInfo.Number == number)];

            if(Got_Book.Story_Card == null)
            {
                Got_Book.Story_Card = new Card();
            }

            Got_Book.Story_Card.Add_Record(reader_name, rnum, DateTime.Now);

            Got_Book.Is_Available = false;

            this.Copies_Available = Count_Available_Books();
        }


        public void Return_Book(int number)
        {
            Book Got_Book = Books_Copies[Books_Copies.FindIndex(getInfo => getInfo.Number == number)];

            Got_Book.Story_Card.Get_Last_Record().Return_Date = DateTime.Now;

            Got_Book.Is_Available = true;

            this.Copies_Available = Count_Available_Books();
        }
    }
}
