using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Orders
    {
        private int orderNumber;

        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        private string orderDate;

        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        //private double orderTotal;

        //public double OrderTotal
        //{
        //    get { return orderTotal; }
        //    set { orderTotal = value; }
        //}

        private int employeeNr;

        public int EmployeeNr
        {
            get { return employeeNr; }
            set { employeeNr = value; }
        }

        private string clientNumber;

        public string ClientNumber
        {
            get { return clientNumber; }
            set { clientNumber = value; }
        }

        public Orders(int orderNumber, string orderDate, int employeeNr, string clientNumber)
        {
            this.orderNumber = orderNumber;
            this.orderDate = orderDate;          
            this.employeeNr = employeeNr;
            this.clientNumber = clientNumber;
        }

        
        public override string ToString()
        {
            return base.ToString();
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static void AddOrder(string clientid, string productName, Dictionary<string, int> compNameQuantity,string months, string importance, int personnelID)
        {
            ////////////////////////////////////////////////////////////////////////////////
            string contractNr = Contract.AddContract(productName, months, importance);
            string sixDigitNr = Contract.SixDigitNumber();

            string CompleteContract = contractNr+sixDigitNr;
            bool errors = false;
            bool isempty = compNameQuantity.Count == 0;


            Object thisLock = new Object();


            ///////////////////////////////////////////////////////////////////////////////

            bool clientIDFound = ClientProducts.CheckClientProducts(clientid);

            if (clientIDFound== true)
            {
                return;
            }

            if (clientid == null)
            {
                MessageBox.Show("Please search for a client!", "Empty Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errors = true;
            }
            else
            {
                if (isempty)
                {
                    MessageBox.Show("No components have been selected!", "Components", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errors = true;
                }
            }


            lock (thisLock)
            {
                if (errors == false)
                {
                    Data.AddOrder(clientid, productName, compNameQuantity, CompleteContract, personnelID);
                    MessageBox.Show("The order has been added!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }

            }

            //if (clientid != null)
            //{
            //    Data.AddOrder(clientid, productName, compNameQuantity, CompleteContract);
            //    MessageBox.Show("Order has been added!");
            //}
            //else
            //{
            //    MessageBox.Show("Please search for a client!");
            //}
        }

        public static List<Orders> GetOrders()
        {
            DataTable dt = Data.GetOrders();
            List<Orders> orderList = new List<Orders>();
            foreach (DataRow item in dt.Rows)
            {
                orderList.Add(new Orders(Convert.ToInt32(item["OrderNumber"]), item["OrderDate"].ToString(), Convert.ToInt32(item["PersonnelID"]), item["ClientID"].ToString()));
            }
            return orderList;
        }
    }
}