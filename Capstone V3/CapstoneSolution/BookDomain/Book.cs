using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDomain
{
    public class Book
    {
        public int ID { get; set; }
        public string ISBN 
        {
            get
            {
                return m_ISBN;
            }
            set
            {
                if (value.Length >= 25)
                    throw new Exception("Cannot be more than 25 Characters");
                m_ISBN = value;
            }

        }
        public string Title 
        {   
            get
            {
                return m_Title;
            }
            set
            {
                if (value.Length >= 30)
                    throw new Exception("Cannot be more than 30 Characters")
                m_Title = value;
            }   
        }

        //TODO: finish adding all the limitations of the properties defined by the database
        public int AuthorID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public int YearPublished 
        { 
            get
            {
                return m_YearPublished;
            }
            set
            {
                if (value < 1400 || value > DateTime.Now.Year)
                    throw new Exception("Cannot be before 1400 or after today");

                m_YearPublished = value;
            }
        }
        public string Language { get; set; }
        public int NumberofCopies { get; set; }

        private string m_ISBN;
        private string m_Title;
        private int m_YearPublished;
    }
}
