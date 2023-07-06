using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAloverasPharmacyPOSSystem.Components
{
    class Values
    {
        public string serverName = "localhost";
        public string serverUser = "root";
        public string serverPass = "";
        public string port = "3307";
        public string database = "raloveraspharmacy_db";

        private static long myId;
        public long MyId
        {
            get { return myId; }
            set { myId = value; }
        }

        private static string myFirstName;
        public string MyFirstName
        {
            get { return myFirstName; }
            set { myFirstName = value; }
        }

        private static string myMiddleName;
        public string MyMiddleName
        {
            get { return myMiddleName; }
            set { myMiddleName = value; }
        }

        private static string myLastName;
        public string MyLastName
        {
            get { return myLastName; }
            set { myLastName = value; }
        }

        private static string myAddress;
        public string MyAddress
        {
            get { return myAddress; }
            set { myAddress = value; }
        }

        private static string myContactNumber;
        public string MyContactNumber
        {
            get { return myContactNumber; }
            set { myContactNumber = value; }
        }

        private static string myEmail;
        public string MyEmail
        {
            get { return myEmail; }
            set { myEmail = value; }
        }

        private static string myUsername;
        public string MyUsername
        {
            get { return myUsername; }
            set { myUsername = value; }
        }

        private static string myPassword;
        public string MyPassword
        {
            get { return myPassword; }
            set { myPassword = value; }
        }

        public string MyFullName
        {
            get
            {
                if(String.IsNullOrWhiteSpace(myMiddleName))
                {
                    return string.Format("{0} {1}", myFirstName, myLastName);
                }
                else
                {
                    return string.Format("{0} {1}. {2}", myFirstName, myMiddleName[0], myLastName);
                }
            }
        }
    }
}
