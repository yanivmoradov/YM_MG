using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    class HostingUnit
    {
        int HostingUnitKey;
        Host Owner;
        string HostingUnitName;
        bool[,] Diary;
        public override string ToString()
        {
            return null; //Day + "." + Month + "." + Year;
        }
    }
}
