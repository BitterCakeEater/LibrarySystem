using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Book_Related
{
    [Serializable]
    class Book
    {
        //Book info
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Library_Cipher { get; set; }
        public int Publishing_Year { get; set; }
        public string Publishing_Place { get; set; }
        public string Publisher_Name { get; set; }
        //Serial number
        public int Number { get; set; }
        //Story card
        public Card Story_Card { get; set; }
        //Available/none available flag
        public bool Is_Available { get; set; }


        
        public Book(string title, string authors, string library_cipher, int publishing_year, string publishing_place, string publisher_name, int number)
        {
            Title = title;
            Authors = authors;
            Library_Cipher = library_cipher;
            Publishing_Year = publishing_year;
            Publishing_Place = publishing_place;
            Publisher_Name = publisher_name;
            Number = number;

            Story_Card = new Card();
            Is_Available = true;
        }     

    }
}
