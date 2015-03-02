using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public partial class People
    {

       public People (int ID, string Firstname, string Lastname) : this()
        {
           this.PersonID = ID;
           this.FirstName = Firstname;
           this.LastName = Lastname;

       }

    }
}
