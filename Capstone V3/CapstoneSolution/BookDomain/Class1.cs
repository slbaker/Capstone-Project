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
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string Subject { get; set; }
        public int YearPublished { get; set; }
    }
}
