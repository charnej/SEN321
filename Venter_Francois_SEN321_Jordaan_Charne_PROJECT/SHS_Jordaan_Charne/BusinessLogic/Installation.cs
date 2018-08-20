using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Installation
    {
        private int installationID;

        public int InstallationID
        {
            get { return installationID; }
            set { installationID = value; }
        }

        private DateTime installationDate;

        public DateTime InstallationDate
        {
            get { return installationDate; }
            set { installationDate = value; }
        }

        private int technician;

        public int Technician
        {
            get { return technician; }
            set { technician = value; }
        }

        private int clientProductsID;

        public int ClientProductsID
        {
            get { return clientProductsID; }
            set { clientProductsID = value; }
        }

        public Installation(int installationID, DateTime installationDate, int technician, int clientProductsID)
        {
            this.installationID = installationID;
            this.installationDate = installationDate;
            this.technician = technician;
            this.clientProductsID = clientProductsID;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", InstallationDate, Technician, ClientProductsID);
        }

        public static void AddInstallation(/*DateTime installdate*/ string technicianName /*, int clientproductid*/)
        {
            int technician = 0;
            List<Personnel> technicianList = Personnel.GetTechnicians();
            foreach (Personnel item in technicianList)
            {
                if (technicianName.Contains(item.FirstName) && technicianName.Contains(item.LastName))
                {
                    technician = item.EmployeeNumber;
                    MessageBox.Show(technician.ToString());
                }
            }

            //Data.AddInstallation(installdate, technician, clientproductid);
        }

        public static List<Installation> InstallationList()
        {
            DataTable dt = Data.GetInstallations();
            List<Installation> installationList = new List<Installation>();
            foreach (DataRow item in dt.Rows)
            {
                installationList.Add(new Installation(Convert.ToInt32(item["InstallationID"]), Convert.ToDateTime(item["InstallationDate"]), Convert.ToInt32(item["Technician"]), Convert.ToInt32(item["ClientProductsID"])));
            }
            return installationList;
        }
    }
}