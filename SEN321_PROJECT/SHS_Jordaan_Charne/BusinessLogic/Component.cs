using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Component
    {
        private int componentNumber;

        public int ComponentNumber
        {
            get { return componentNumber; }
            set { componentNumber = value; }
        }

        private string componentName;

        public string ComponentName
        {
            get { return componentName; }
            set { componentName = value; }
        }

        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public Component(int componentNumber, string componentName, double cost, int quantity)
        {
            this.componentNumber = componentNumber;
            this.componentName = componentName;
            this.cost = cost;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0} ", componentName);
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
         // this method returns a list of components
        public static List<Component> ComponentList()
        {
             
            DataTable dt = Data.GetComponents();
            List<Component> componentList = new List<Component>();
            foreach (DataRow item in dt.Rows)
            {
                componentList.Add(new Component(Convert.ToInt32(item["ComponentID"]),item["ComponentName"].ToString(),Convert.ToDouble(item["ComponentCost"]),Convert.ToInt32(item["Quantity"])));
            }
            return componentList;
        }

        public static void UpdateComponent(string compName, int qty, double compCost,int id)
        {
            bool errors = false;
            try
            {// if the values are empty, an exception is thrown.
                if (String.IsNullOrEmpty(compName) || String.IsNullOrEmpty(qty.ToString()) || String.IsNullOrEmpty(compCost.ToString()))
                {
                    errors = true;
                    throw new EmptyFieldsException();
                }
            }
            catch (EmptyFieldsException e)
            {

                MessageBox.Show(e.Message);
            }
            if (errors == false)
            {
                Data.UpdateComponents(compName, compCost, qty, id);
                MessageBox.Show("The component has been updated!", "Component Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        // this method adds a component
        public static void AddComponent(string compname, int qty, double cost)
        {
            bool errors = false;
            if (String.IsNullOrEmpty(compname))
            {
                errors = true;
                MessageBox.Show("Please add component name.","Component Name",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            // validation - checks whether the name contains letters
            foreach (var item in compname)
            {
                if (!Char.IsLetter(item))
                {
                    MessageBox.Show("Component name may only contain letters.", "Component Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errors = true;
                }
            }
            if (errors == false)
            {
                Data.AddComponentSP(compname, qty, cost);
                MessageBox.Show("The new component has been added!", "Component Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}