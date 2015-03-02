using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public partial class Cardholder :People
    {
         public Cardholder (People people, string cardholderPhone, string libraryCardID) : base (people.PersonID, people.FirstName, people.LastName)
        {
            this._Phone = cardholderPhone;
            this._LibraryCardID = libraryCardID;
            
           
        }

        public Cardholder(Cardholder cardholder)
        {
            this._Phone = cardholder._Phone;
            this._LibraryCardID = cardholder._LibraryCardID;
        }


    }
}
