using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    
    public partial class Librarian : People
    {
        public Librarian (People people, string phone, string librarianUserID , string password) : base (people.PersonID, people.FirstName, 
            people.LastName)
        {
            
            this._Phone = phone;
            this._UserID = librarianUserID;
            this._Password = password;
        }


        //TODO: might be issue with _names  - - look that up - verify it works. 


        //public Librarian(string phone, string librarianUserID, string password)  
        //{

        //    this._Phone = phone;
        //    this._UserID = librarianUserID;
        //    this._Password = password;
        //    }

    }
}
