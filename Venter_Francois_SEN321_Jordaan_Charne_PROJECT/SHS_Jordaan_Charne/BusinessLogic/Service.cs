using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Service
    {
        private string serviceID;

        public string ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Service(string serviceID, string description)
        {
            this.serviceID = serviceID;
            this.description = description;       
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", serviceID, description);
        }

        public static List<Service> GetService()
        {
            DataTable dt = Data.GetServices();
            List<Service> serviceList = new List<Service>();
            foreach (DataRow item in dt.Rows)
            {
                serviceList.Add(new Service(item["ServiceID"].ToString(),item["Description"].ToString()));
            }
            return serviceList;
        }
    }
}
