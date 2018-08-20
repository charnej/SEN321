using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ServiceTicket
    {
        private int serviceTicketID;

        public int ServiceTicketID
        {
            get { return serviceTicketID; }
            set { serviceTicketID = value; }
        }

        private string clientName;

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private int orderNumber;

        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        private string complete;

        public string Complete
        {
            get { return complete; }
            set { complete = value; }
        }


        public ServiceTicket(int serviceTicketID, string clientName, string productName, int orderNumber, string complete)
        {
            this.serviceTicketID = serviceTicketID;
            this.clientName = clientName;
            this.productName = productName;
            this.orderNumber = orderNumber;
            this.complete = complete;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}", orderNumber, clientName, productName);
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static void AddServiceTicket(string clientid)
        {
            bool errors = false;
            if (string.IsNullOrEmpty(clientid))
            {
                errors = true;
            }
            if (errors == false)
            {
                Data.AddServiceTicket(clientid);
            }
            
        }

        public static List<ServiceTicket> GetServiceTickets()
        {
            DataTable dt = Data.GetServiceTicket();
            List<ServiceTicket> serviceTicketList = new List<ServiceTicket>();
            foreach (DataRow item in dt.Rows)
            {
                serviceTicketList.Add(new ServiceTicket(Convert.ToInt32(item["ServiceTicketID"]), item["ClientName"].ToString(), item["ProductName"].ToString(), Convert.ToInt32(item["OrderNumber"]),item["Complete"].ToString()));
            }
            return serviceTicketList;
        }

        public static void UpdateServiceTicket(int ID, string complete)
        {
            Data.UpdateServiceTicket(complete,ID);
        }
    }
}
