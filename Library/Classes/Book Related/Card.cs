using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Book_Related
{
    [Serializable]
    class Card
    {
        //List of records
        private List<CardRecord> Records_List;


        
        public Card()
        {
            Records_List = new List<CardRecord>();
        }

        
        public void Add_Record(string reader_name, int reader_card_number, DateTime issue_date)
        {
            Records_List.Add(new CardRecord(reader_name, reader_card_number, issue_date));
        }

        
        public List<CardRecord> Get_Record_List()
        {
            return Records_List;
        }

        
        public CardRecord Get_Last_Record()
        {
            return Records_List[Records_List.Count - 1];
        }
    }
}
