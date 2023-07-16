using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAloverasPharmacyPOSSystem.Components
{
    class Value
    {
        public string serverName = "localhost";
        public string serverUser = "root";
        public string serverPass = "";
        public string port = "3307";
        public string database = "raloveraspharmacy_db";

        // My values

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
                if (String.IsNullOrWhiteSpace(myMiddleName))
                {
                    return string.Format("{0} {1}", myFirstName, myLastName);
                }
                else
                {
                    return string.Format("{0} {1}. {2}", myFirstName, myMiddleName[0], myLastName);
                }
            }
        }

        // Get description id values

        private static long descriptionId;
        public long DescriptionId
        {
            get { return descriptionId; }
            set { descriptionId = value; }
        }

        // Get packaging unit id values

        private static long packagingUnitId;
        public long PackagingUnitId
        {
            get { return packagingUnitId; }
            set { packagingUnitId = value; }
        }

        // Get generic id values

        private static long genericId;
        public long GenericId
        {
            get { return genericId; }
            set { genericId = value; }
        }

        // Product values

        private static long productId;
        public long ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private static string productCode;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        private static string productDescription;
        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        private static string productPackagingUnit;
        public string ProductPackagingUnit
        {
            get { return productPackagingUnit; }
            set { productPackagingUnit = value; }
        }

        private static int productQuantity;
        public int ProductQuantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }

        private static double productPrice;
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        private static double productDiscount;
        public double ProductDiscount
        {
            get { return productDiscount; }
            set { productDiscount = value; }
        }

        private static double productDiscounted;
        public double ProductDiscounted
        {
            get { return productDiscounted; }
            set { productDiscounted = value; }
        }

        private static string productGeneric;
        public string ProductGeneric
        {
            get { return productGeneric; }
            set { productGeneric = value; }
        }
    }
}
