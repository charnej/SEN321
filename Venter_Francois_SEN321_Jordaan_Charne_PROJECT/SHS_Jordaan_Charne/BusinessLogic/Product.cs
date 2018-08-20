using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Product
    {
        private int productNumber;

        public int ProductNumber
        {
            get { return productNumber; }
            set { productNumber = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public Product(int productNumber, string productName, string description)
        {
            this.productName = productName;
            this.productNumber = productNumber;
            this.description = description;
        }

        public override string ToString()
        {
            return string.Format("{0} ", productName);
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static List<Product> GetProducts()
        {
            DataTable dt = Data.GetProducts();
            List<Product> productsList = new List<Product>();
            foreach (DataRow item in dt.Rows)
            {
                productsList.Add(new Product(Convert.ToInt32(item["ProductID"]), item["ProductName"].ToString(),item["ProductDescription"].ToString()));
            }
            return productsList;
        }

        public static void UpdateProducts(int productid, string productname, string description)
        {
            bool errors = false;
            if (string.IsNullOrEmpty(productname))
            {
                MessageBox.Show("Product name cannot be empty.", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errors = true;
            }
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Product description cannot be empty.", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errors = true;
            }

            if (errors ==false)
            {
                MessageBox.Show("The product has been updated!", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Data.UpdateProductSP(productid, productname, description);
            }

            
        }

        public static void AddProducts(string productname, string description)
        {            
            List<Product> productList = GetProducts();
            bool errors = false;

            if (string.IsNullOrEmpty(productname))
            {
                MessageBox.Show("Product name cannot be empty.", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errors = true;
            }
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Product description cannot be empty.", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errors = true;
            }

            foreach (Product item in productList)
            {
                if (item.ProductName == productname)
                {
                    MessageBox.Show("Product already exists", "Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errors = true;
                }
            }
            if (errors == false)
            {
                Data.AddProductSP(productname, description);
                MessageBox.Show("The product has been added!", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}