using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class ClientConfiguration
    {
        private int ccID;

        public int CCID
        {
            get { return ccID; }
            set { ccID = value; }
        }
       
        private int component;

        public int Component
        {
            get { return component; }
            set { component = value; }
        }

        private string range;

        public string Range
        {
            get { return range; }
            set { range = value; }
        }

        private int clientProductsID;

        public int ClientProductsID
        {
            get { return clientProductsID; }
            set { clientProductsID = value; }
        }

        public ClientConfiguration()
        {

        }
        public ClientConfiguration(int ccID, int component, string range, int clientProductsID)
        {
            this.ccID = ccID;
            this.component = component;
            this.range = range;
            this.clientProductsID = clientProductsID;
        }


    }
}