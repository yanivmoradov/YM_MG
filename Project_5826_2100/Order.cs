using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using targil2;

namespace Project_5826_2100
{
    class Order
    {
        int HostingUnitKey;
        int GuestRequestKey;
        int OrderKey;
        string Status;
        MyDate CreateDate;
        MyDate OrderDate;
        public override string ToString()
        {
            return null; //Day + "." + Month + "." + Year;
        }
    }
}
