using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Upgrades
    {
        private int upgradeID;

        public int UpgradeID
        {
            get { return upgradeID; }
            set { upgradeID = value; }
        }

        private DateTime calloutDate;

        public DateTime CallOutDate
        {
            get { return calloutDate; }
            set { calloutDate = value; }
        }

        private int technician;

        public int Technician
        {
            get { return technician; }
            set { technician = value; }
        }

        private int clientProductsId;

        public int ClientproductsID
        {
            get { return clientProductsId; }
            set { clientProductsId = value; }
        }

    }
}