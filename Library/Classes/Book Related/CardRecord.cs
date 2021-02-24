using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Book_Related
{
    [Serializable]
    class CardRecord
    {
        //Reader info
        public string Reader_Name { get; set; }
        public int Reader_Card_Number { get; set; }
        //Date info
        public DateTime Issue_Date { get; set; }
        public DateTime Term_Date { get; set; }
        public DateTime Return_Date { get; set; }


       
        public CardRecord(string reader_name, int reader_card_number, DateTime issue_date)
        {
            Reader_Name = reader_name;
            Reader_Card_Number = reader_card_number;
            Issue_Date = issue_date;
            Term_Date = Issue_Date.AddDays(30);
            Return_Date = DateTime.MinValue;
        }
    }
}
