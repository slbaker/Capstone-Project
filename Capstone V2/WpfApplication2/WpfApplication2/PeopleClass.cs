using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class PeopleClass
    {

        private List<People> people = new List<People>();

        public People this[int index]
        {
            get { return people[index]; }
            set { people.Add(value); }
        }

        public List<People> PeopleList
        {
            get { return people; }
        }



    }
}
