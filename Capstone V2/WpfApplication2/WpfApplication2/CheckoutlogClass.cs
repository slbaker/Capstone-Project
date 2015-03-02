using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class CheckoutlogClass
    {
        private List<CheckOutLog> checkoutlog = new List<CheckOutLog>();

        public CheckOutLog this[int index]
        {
            get {return checkoutlog[index];}
            set {checkoutlog.Add(value);}

        }

        public List<CheckOutLog> CheckOutLog

        {
            get { return checkoutlog; }
        }



    }
}
