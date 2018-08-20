using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Contract
    {
        private int contractID;

        public int ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }

       
        private string contractName;

        public string ContractName
        {
            get { return contractName; }
            set { contractName = value; }
        }
        private string contractNumber;

        public string ContractNumber
        {
            get { return contractNumber; }
            set { contractNumber = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Contract(int contractID, string contractName, string contractNumber, string description)
        {
            this.contractID = contractID;        
            this.contractName = contractName;
            this.contractNumber = contractNumber;
            this.description = description;
        }

        public Contract(string contractName, string contractNumber)
        {
            
            this.contractName = contractName;
            this.contractNumber = contractNumber;
            
        }

        public override string ToString()
        {
            return string.Format("{0}", contractNumber);
        }

        public static List<Contract> GetContract()
        {
            DataTable dt = Data.GetContractTypes();
            List<Contract> contractList = new List<Contract>();
            foreach (DataRow item in dt.Rows)
            {
                contractList.Add(new Contract(Convert.ToInt32(item["ContractID"]),item["ContractName"].ToString(),item["ContractNumber"].ToString(),item["ContractDescription"].ToString()));
            }
            return contractList;
        }

        public static bool SearchContract(string nameContract)
        {
       
            List<Contract> contractList = GetContract();
            foreach (Contract item in contractList)
            {
                if (item.contractName == nameContract)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddNewProductContract(string nameContract, string contractdesc)
        {
            
            List<Contract> contractList = GetContract();
            List<Contract> SortedList = contractList.OrderByDescending(o => o.contractNumber).ToList();
            
            string[] alpha = new string[] {"F","G","H","I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U","V","W","X","Y","Z" };           
            string currentNum = SortedList[0].contractNumber;
            string nextNum = "z";

            // checks to see if contract number already exists, if it does, it goes to the next element in the array.
            for (int i = 0; i < alpha.Length; i++)
            {
                if (alpha[i] == currentNum)
                {
                    nextNum = alpha[i + 1];                                    
                    break;
                }
            }

            bool contractExist = SearchContract(nameContract);

            // if the contract already exists, the user will be notified via a message box. If the contract does not exist, the new contract will be added do the database and the user will be notified.
            if (contractExist == true)
            {
                MessageBox.Show("A contract for this product already exists! Please choose a different product.", "Contract Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(nameContract) || string.IsNullOrEmpty(contractdesc))
                {
                    MessageBox.Show("Please enter all values", "Enter Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Data.AddNewProductContract(nextNum, nameContract, contractdesc);
                    MessageBox.Show("Contract has been added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }                         
            
        }

        public static string AddContract(string productname, string months, string importance)
        {
            List<Contract> contracts = GetContract();
            List<Contract> contractNew = new List<Contract>();

            string year = DateTime.Today.Year.ToString();
            string contractType;
            string contractNr;

            string startProduct = productname.Substring(5);
            string [] splits = startProduct.Split();
            string startWord = splits[0].ToString();

            string[] monthSplit = months.Split();
            string startMonth = monthSplit[0].ToString();

            foreach (Contract item in contracts)
            {
                if (item.ContractName.StartsWith(startWord))
                {
                    contractNew.Add(item);
                }
            }

            foreach (Contract item in contractNew)
            {
                if (item.ContractName.EndsWith(startMonth))
                {
                    contractType = item.ToString();
                    contractNr = year + contractType + importance.TrimEnd();
                    return contractNr;
                }

            }
            return null;
        }

        //public static string AddContractTest(string productname, string months, string importance)
        //{
        //    List<Contract> contracts = GetContract();
        //    List<Contract> contractNew = new List<Contract>();
        //    List<Product> productList = Product.GetProducts();

        //    foreach (Contract item in contracts)
        //    {
        //        foreach (Product productitem in productList)
        //        {
        //            if (item.ProductID == productitem.ProductNumber)
        //            {
        //                contractNew.Add(item);
        //            }
        //        }
        //    }

           
        //}
        
        public static string SixDigitNumber()
        {
            Random rng = new Random();
            //int number = 1;
            int number = rng.Next(0, 999999);
            string outputValue = number.ToString().PadLeft(6, '0');
            return outputValue;
        }

        public static string GenerateContractName (string productname)
        {
            string product = productname;

            string contract;
            string[] words = product.Split(' ');
            contract = words[1];

            return contract;
        }
    }
}
