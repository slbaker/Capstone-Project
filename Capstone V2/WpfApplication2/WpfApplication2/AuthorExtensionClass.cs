using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    //public partial class Author that Inherits from People Class
    public partial class Author : People
    {

        //In class author there are 2 parameters.  People inherits from base class and gets personal ID, FirstName and LastName. 
        public Author(People people, string authorBio) : base(people.PersonID, people.FirstName, people.LastName)
        {
            this._Bio = authorBio;
        }

        public Author(Author author)
        {
            this._Bio = author._Bio;
        }



    }
}
