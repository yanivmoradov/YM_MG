using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using targil2;
//using targil2.MyDate;

namespace BA

{
    class GuestRequest
    {
        int GuestRequestKey;
        string PrivateName;
        string FamilyName;
        string MailAddress;
        int Status;
        MyDate RegistrationDate;
        MyDate EntryDate;
        MyDate ReleaseDate;
        string Area;
        string SubArea;
        string Type;
        int Adults;
        int Children;
        string Pool;
        string Jacuzzi;
        string Garden;
        string ChildrensAttractions;
        public override string ToString()
        {
            return null; //Day + "." + Month + "." + Year;
        }
    }
}
