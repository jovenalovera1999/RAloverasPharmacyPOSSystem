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
        public string serverPass = "admin";
        public string port = "3307";
        public string database = "raloveraspharmacy_db";

        // My values

        private static long myUserId;
        public long MyUserId {
            get { return myUserId; }
            set { myUserId = value; }
        }

        private static byte[] myProfilePicture;
        public byte[] MyProfilePicture {
            get { return myProfilePicture; }
            set { myProfilePicture = value; }
        }

        private static string myFirstName;
        public string MyFirstName {
            get { return myFirstName; }
            set { myFirstName = value; }
        }

        private static string myMiddleName;
        public string MyMiddleName {
            get { return myMiddleName; }
            set { myMiddleName = value; }
        }

        private static string myLastName;
        public string MyLastName {
            get { return myLastName; }
            set { myLastName = value; }
        }

        private static string myAddress;
        public string MyAddress {
            get { return myAddress; }
            set { myAddress = value; }
        }

        private static string myContactNumber;
        public string MyContactNumber {
            get { return myContactNumber; }
            set { myContactNumber = value; }
        }

        private static string myEmail;
        public string MyEmail {
            get { return myEmail; }
            set { myEmail = value; }
        }

        private static string myUsername;
        public string MyUsername {
            get { return myUsername; }
            set { myUsername = value; }
        }

        private static string myPassword;
        public string MyPassword {
            get { return myPassword; }
            set { myPassword = value; }
        }

        private static string myUserLevel;
        public string MyUserLevel {
            get { return myUserLevel; }
            set { myUserLevel = value; }
        }

        public string MyFullName {
            get {
                if (String.IsNullOrWhiteSpace(myMiddleName)) {
                    return string.Format("{0} {1}", myFirstName, myLastName);
                } else {
                    return string.Format("{0} {1}. {2}", myFirstName, myMiddleName[0], myLastName);
                }
            }
        }

        // Get description id values

        private static long descriptionId;
        public long DescriptionId {
            get { return descriptionId; }
            set { descriptionId = value; }
        }

        // Get packaging unit id values

        private static long packagingUnitId;
        public long PackagingUnitId {
            get { return packagingUnitId; }
            set { packagingUnitId = value; }
        }

        // Get discount id values

        private static long discountId;
        public long DiscountId {
            get { return discountId; }
            set { discountId = value; }
        }

        // Get generic id values

        private static long? genericId;
        public long? GenericId {
            get { return genericId; }
            set { genericId = value; }
        }

        // Get supplier id values
        private static long? supplierId;
        public long? SupplierId { 
            get { return supplierId; }
            set { supplierId = value; }
        }

        // Get user for payment id values

        private static long userForPaymentId;
        public long UserForPaymentId {
            get { return userForPaymentId; }
            set { userForPaymentId = value; }
        }

        // Get transaction id values

        private static long transactionId;
        public long TransactionId {
            get { return transactionId; }
            set { transactionId = value; }
        }

        // Get user level id values

        private static long userLevelId;
        public long UserLevelId {
            get { return userLevelId; }
            set { userLevelId = value; }
        }

        // Product values

        private static long productId;
        public long ProductId {
            get { return productId; }
            set { productId = value; }
        }

        private static string productCode;
        public string ProductCode {
            get { return productCode; }
            set { productCode = value; }
        }

        private static string productDescription;
        public string ProductDescription {
            get { return productDescription; }
            set { productDescription = value; }
        }

        private static string productPackagingUnit;
        public string ProductPackagingUnit {
            get { return productPackagingUnit; }
            set { productPackagingUnit = value; }
        }

        private static int productQuantity;
        public int ProductQuantity {
            get { return productQuantity; }
            set { productQuantity = value; }
        }

        private static double productPrice;
        public double ProductPrice {
            get { return productPrice; }
            set { productPrice = value; }
        }

        private static double productDiscount;
        public double ProductDiscount {
            get { return productDiscount; }
            set { productDiscount = value; }
        }

        private static double productDiscounted;
        public double ProductDiscounted {
            get { return productDiscounted; }
            set { productDiscounted = value; }
        }

        private static string productGeneric;
        public string ProductGeneric {
            get { return productGeneric; }
            set { productGeneric = value; }
        }

        private static string productSupplier;
        public string ProductSupplier {
            get { return productSupplier; }
            set { productSupplier = value; }
        }

        private static double productPriceFromSupplier;
        public double ProductPriceFromSupplier {
            get { return productPriceFromSupplier; }
            set { productPriceFromSupplier = value; }
        }

        // Quantity values

        private static int productCartQuantity;
        public int ProductCartQuantity {
            get { return productCartQuantity; }
            set { productCartQuantity = value; }
        }

        // Return product values

        private static long returnProductId;
        public long ReturnProductId {
            get { return returnProductId; }
            set { returnProductId = value; }
        }

        private static string returnProductDescription;
        public string ReturnProductDescription { 
            get { return returnProductDescription; }
            set { returnProductDescription = value; }
        }

        private static int returnProductQuantity;
        public int ReturnProductQuantity {
            get { return returnProductQuantity; }
            set { returnProductQuantity = value; }
        }

        private static double returnProductAmountReturned;
        public double ReturnProductAmountReturned
        {
            get { return returnProductAmountReturned; }
            set { returnProductAmountReturned = value; }
        }
    }
}
