using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Maintenance
    {
        private int maintenanceID;

        public int MaintenanceID
        {
            get { return maintenanceID; }
            set { maintenanceID = value; }
        }

        private DateTime callOutDate;

        public DateTime CallOutDate
        {
            get { return callOutDate; }
            set { callOutDate = value; }
        }

        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
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


    }
}