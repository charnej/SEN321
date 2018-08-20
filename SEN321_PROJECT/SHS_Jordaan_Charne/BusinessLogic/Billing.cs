using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Billing
    {
        private int billingID;

        public int BillingID
        {
            get { return billingID; }
            set { billingID = value; }
        }
        private double billingAmount;

        public double BillingAmount
        {
            get { return billingAmount; }
            set { billingAmount = value; }
        }
        private int clientID;

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        public Billing()
        {

        }
    }
}
