using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Invoice
    {
        private string clientName;

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        private string clientNumber;

        public string ClientNumber
        {
            get { return clientNumber; }
            set { clientNumber = value; }
        }

        private int orderNumber;

        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        private string product;

        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        private string component;

        public string Component
        {
            get { return component; }
            set { component = value; }
        }

        private int compQty;

        public int CompQty
        {
            get { return compQty; }
            set { compQty = value; }
        }

        private double compCost;

        public double CompCost
        {
            get { return compCost; }
            set { compCost = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public static void InvSend()
        {
            Invoice inv = new Invoice();
            InvoiceSender invSender = new InvoiceSender(); //publisher
            MailService mailservice = new MailService(); //subscriber

            invSender.InvoiceSent += mailservice.OnInvoiceSent;

            invSender.SendInvoice(inv);
        }

        public static void PrintInvoice(string clientid)
        {
           // DataHandler.Data.InvoiceTest(clientid);
        }

        public static DataTable clientInvDetails (string clientid)
        {
            bool clientIDFound = ClientProducts.CheckClientProducts1(clientid);

            if (clientIDFound == false)
            {
                return null;
            }

            DataTable dt = Data.GetClientInvoiceDetails(clientid);
            return dt;
        }

        //this method checks to see if a client already has a product to their name
        public static DataTable compInvDetails(string clientid)
        {
            bool clientIDFound = ClientProducts.CheckClientProducts1(clientid);

            if (clientIDFound == false)
            {
                return null;
            }

            DataTable dt = Data.GetCompInvoiceDetails(clientid);
                return dt;
            
            
        }

    }
}
