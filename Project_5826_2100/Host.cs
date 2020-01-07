using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA

{
    class Host
    {
       
        int hostKey;
        string PrivateName;
        string FamilyName;
        int FhoneNumber;
        string MailAddress;
        string BankBranchDetails;
        int BankAccountNumber;
        bool CollectionClearance;

        public int HostKey { get => hostKey; set => hostKey = value; }
        public override string ToString()
        {
            return null; //Day + "." + Month + "." + Year;
        }
    }
}
