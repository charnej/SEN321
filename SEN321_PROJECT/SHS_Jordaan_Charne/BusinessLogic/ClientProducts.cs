using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class ClientProducts
    {
        private int clientProductsID;

        public int ClientProductsID
        {
            get { return clientProductsID; }
            set { clientProductsID = value; }
        }

        private DateTime cancelDate;

        public DateTime CancelDate
        {
            get { return cancelDate; }
            set { cancelDate = value; }
        }

        private string clientID;

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        private int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public ClientProducts(int clientProductsID, string clientID, int productID)
        {
            this.clientProductsID = clientProductsID;           
            this.clientID = clientID;
            this.productID = productID;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", clientProductsID, cancelDate, clientID, productID);
        }

        public static void CancelProduct(string clientid, int cpID)
        {
            Data.CancelProduct(clientid, DateTime.Today,cpID);
            MessageBox.Show("The contract/product has been cancelled as of today.", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static List<ClientProducts> GetCP()
        {
            List<ClientProducts> clientProducts = new List<ClientProducts>();
            DataTable dt = Data.GetClientProducts();

            foreach (DataRow item in dt.Rows)
            {
                clientProducts.Add(new ClientProducts(Convert.ToInt32(item["ClientProductsID"]),  item["ClientID"].ToString(), Convert.ToInt32(item["ProductID"])));
            }

            return clientProducts;
        }

        public static bool CheckClientProducts(string clientid)
        {
            List<ClientProducts> clientProducts = ClientProducts.GetCP();
            foreach (ClientProducts item in clientProducts)
            {
                if (item.ClientID == clientid)
                {
                    MessageBox.Show("Client already has a contract. Only one contract is allowed per client.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;                   
                }              
                               
            }
            return false;
        }

        public static bool CheckClientProducts1(string clientid)
        {
            List<ClientProducts> clientProducts = ClientProducts.GetCP();
            foreach (ClientProducts item in clientProducts)
            {
                if (item.ClientID == clientid)
                {                   
                    return true;
                }

            }
            return false;
        }
    }
}