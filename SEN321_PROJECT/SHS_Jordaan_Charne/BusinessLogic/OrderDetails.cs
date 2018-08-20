using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class OrderDetails
    {
        private int orderDetailsID;

        public int OrderDetailsID
        {
            get { return orderDetailsID; }
            set { orderDetailsID = value; }
        }

        private int orderNumber;

        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        private int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        private int componentID;

        public int ComponentID
        {
            get { return componentID; }
            set { componentID = value; }
        }


        public OrderDetails(int orderDetailsID, int orderNumber, int productID, int componentID)
        {
            this.orderDetailsID = orderDetailsID;
            this.orderNumber = orderNumber;
            this.productID = productID;
            this.componentID = componentID;
        }

        public override string ToString()
        {
            return string.Format("{0} ", orderDetailsID);
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static void GetOrderDetails()
        {

        }
    }
}