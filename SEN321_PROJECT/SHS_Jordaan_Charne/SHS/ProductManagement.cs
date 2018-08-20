using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SHS
{
    public partial class ProductManagement : Form
    {
        BindingSource b = new BindingSource();
        BindingSource c = new BindingSource();
        BindingSource d = new BindingSource();
        BindingSource bs = new BindingSource();
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {

        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            bs.DataSource = Personnel.GetTechnicians();
            cmboTechnician.DataSource = bs;
            
            b.DataSource = BusinessLogic.Component.ComponentList();
            txtUpdCompName.DataBindings.Add("Text", b, "ComponentName");
            numUpdCompQty.DataBindings.Add("Text", b, "Quantity");
            numUpdCompCost.DataBindings.Add("Text", b, "Cost");
            lblCompID.DataBindings.Add("Text", b, "ComponentNumber");

            dgvStock.DataSource = b;
            dgvAppointments.DataSource = Installation.InstallationList();
            c.DataSource = Product.GetProducts();

            dgvProducts.DataSource = c;
            d.DataSource = Product.GetProducts();
            dgvProductsContract.DataSource = d;

            txtProductName.DataBindings.Add("Text", c, "ProductName");
            txtDescr.DataBindings.Add("Text", c, "Description");
            lblProductID.DataBindings.Add("Text", c, "ProductNumber");



            cmboContract.SelectedIndex = 0;
            
        }

        private void btnUpdateComp_Click(object sender, EventArgs e)
        {
            BusinessLogic.Component.UpdateComponent(txtUpdCompName.Text, Convert.ToInt32(numUpdCompQty.Value), Convert.ToInt32(numUpdCompCost.Value), Convert.ToInt32(lblCompID.Text));
            dgvStock.Refresh();

        }

        private void btnPM_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 CM = new Form1();
            CM.Show();
            this.Hide();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ClearBindings();
            //txtProductName.DataBindings.Add("Text", c, "ProductName");
            //txtDescr.DataBindings.Add("Text", c, "Description");
            //txtProductID.DataBindings.Add("Text", c, "ProductNumber");
           
        }
        private void ClearBindings()
        {
            txtProductName.DataBindings.Clear();
            txtDescr.DataBindings.Clear();
            

        }

        private void ClearBindingsContract()
        {
            txtAddContractName.DataBindings.Clear();
            txtAddContractDescription.DataBindings.Clear();
            lblGetProductName.DataBindings.Clear();
            

        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            
            Product.UpdateProducts(Convert.ToInt32(lblProductID.Text), txtProductName.Text, txtDescr.Text);

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
          Product.AddProducts(txtAddProductName.Text, txtAddPD.Text);
            c.DataSource = Product.GetProducts();

            dgvProducts.DataSource = c;

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            BusinessLogic.Component.AddComponent(txtAddCompName.Text, Convert.ToInt32(numCompQty.Value), Convert.ToDouble(numCompCost.Value));
            b.DataSource = BusinessLogic.Component.ComponentList();
            dgvStock.DataSource = b;
        }

        private void dgvProductsContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBindingsContract();
            lblGetProductName.DataBindings.Add("Text", d, "ProductName");               
            txtAddContractName.Text = Contract.GenerateContractName(lblGetProductName.Text)+" "+cmboContract.Text;
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            Contract.AddNewProductContract(txtAddContractName.Text, txtAddContractDescription.Text);
        }

        private void btnTS_Click(object sender, EventArgs e)
        {
            TechnicalSupport ts = new TechnicalSupport();
            ts.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out and exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSearchApp_Click(object sender, EventArgs e)
        {
           List<Appointments> appList = Appointments.FindTechnicianAppointments(cmboTechnician.Text);
            dgvAppointments.DataSource = appList;
        }

       
    }
}
