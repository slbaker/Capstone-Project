using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public partial class CheckOutLog
    {
        public CheckOutLog (int CheckOutLogID, int CardholderID, int BookID, DateTime DateCheckedOut, DateTime DateCheckedIn)
        {
            this._CheckOutLogID = CheckOutLogID;
            this._CardholderID = CardholderID;
            this._BookID = BookID;
            this._CheckOutDate = DateCheckedOut;
            this._CheckInDate = DateCheckedIn;
        }

        public CheckOutLog(CheckOutLog checkOutLog)
        {
            this._CheckOutLogID = checkOutLog._CheckOutLogID;
            this._CardholderID = checkOutLog._CardholderID;
            this._BookID = checkOutLog._BookID;
            this._CheckOutDate = checkOutLog.CheckOutDate;
            this._CheckInDate = checkOutLog.CheckInDate;
        }



    }
}
