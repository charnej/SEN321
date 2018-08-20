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
    public partial class Form1 : Form
    {
        BindingSource b = new BindingSource();
        BindingSource c = new BindingSource();
        public static string clientNumber;
        public static int personnelID;

        string clientNr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            ClearBindings();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            clientNr = Client.GetClientNumber(textBox1.Text);
            b.DataSource = Client.SearchPerson(textBox1.Text);
            c.DataSource = ClientDetailsList.ClientDetailList(clientNr);
            dgvClientProductDetails.DataSource = c;

            dataGridView1.DataSource = b;
            
                      
            clientnr.Text = clientNr;
            clientNumber = clientnr.Text;
            //clientnr.DataBindings.Add("Text", b, "ClientID");
            //clientnr.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtPostal.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtStreetName.Clear();
            txtHouseNr.Clear();
            txtSuburb.Clear();
            txtCity.Clear();
            txtProvince.Clear();
         

            //  this.dataGridView1.DataSource = DataBLL.SearchPerson(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboProvince.SelectedIndex = 0;
            personnelID = Login.sendPersonnelID;

            clientnr.Visible = false;
            comboBox1.DataSource = Product.GetProducts();
            clbComp.DataSource = BusinessLogic.Component.ComponentList();
            serviceComboBox.DataSource = Service.GetService();
            monthCmboBox.SelectedIndex = 0;
            cmboNewsletter.SelectedIndex = 0;
        }

        private void btnAddProductPnl_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {                    
            Client.UpdatePerson(txtName.Text, txtSurname.Text, txtEmail.Text, txtPhone.Text, txtHouseNr.Text, txtStreetName.Text, txtSuburb.Text, txtCity.Text, txtProvince.Text, txtPostal.Text, textBox1.Text);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBindings();

            //clientnr.DataBindings.Add("Text", b, "ClientID");
            txtName.DataBindings.Add("Text", b, "FirstName");
            txtSurname.DataBindings.Add("Text", b, "LastName");
            txtPhone.DataBindings.Add("Text", b, "PhoneNumber");
            txtEmail.DataBindings.Add("Text", b, "Email");
            txtHouseNr.DataBindings.Add("Text", b, "HouseNumber");
            txtStreetName.DataBindings.Add("Text", b, "StreetName");
            txtSuburb.DataBindings.Add("Text", b, "Suburb");
            txtCity.DataBindings.Add("Text", b, "City");
            txtProvince.DataBindings.Add("Text", b, "Province");
            txtPostal.DataBindings.Add("Text", b, "PostalCode");
        }

        private void ClearBindings()
        {
           // clientnr.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtSurname.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtHouseNr.DataBindings.Clear();
            txtStreetName.DataBindings.Clear();
            txtSuburb.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtProvince.DataBindings.Clear();
            txtPostal.DataBindings.Clear();
        }

        

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Client.AddClient(txtAddID.Text, txtAddName.Text, txtAddSurname.Text, txtAddEmail.Text, txtAddCell.Text, txtAddHouseNr.Text, txtAddStreet.Text, txtAddSuburb.Text, txtAddCity.Text, cmboProvince.Text, txtAddPostal.Text, cmboNewsletter.Text);

           // Client.AddClient(txtAddID.Text, txtAddName.Text, txtAddSurname.Text, txtAddEmail.Text, txtAddCell.Text, Convert.ToInt32(txtAddHouseNr.Text), txtAddStreet.Text, txtAddSuburb.Text, txtAddCity.Text, txtAddProvince.Text, txtAddPostal.Text, cmboNewsletter.Text);
        }

        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, int> compIdQuantity = new Dictionary<string, int>();


            foreach (DataGridViewRow row in dgvAddComps.Rows)
            {
                compIdQuantity.Add(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[1].Value));
            }


            Orders.AddOrder(clientNr, comboBox1.Text, compIdQuantity, monthCmboBox.Text, serviceComboBox.Text,personnelID);
            ServiceTicket.AddServiceTicket(clientNr);
            bool clientIDFound = ClientProducts.CheckClientProducts1(clientNr);

            if (clientIDFound == true)
            {
                InvoiceForm invf = new InvoiceForm();
                invf.Show();
            }
        }



        private void btnPM_Click(object sender, EventArgs e)
        {
            ProductManagement PM = new ProductManagement();        
            PM.Show();
            this.Hide();
           
        }

        private void btnAddCompDGV_Click(object sender, EventArgs e)
        {
            dgvAddComps.Rows.Clear();
            dgvAddComps.ColumnCount = 2;
            dgvAddComps.Columns[0].Name = "Component";
            dgvAddComps.Columns[1].Name = "Quantity";

            for (int i = 0; i < clbComp.Items.Count; i++)
            {
                if (clbComp.GetItemChecked(i))
                {
                    dgvAddComps.Rows.Add(clbComp.Items[i],"1");
                }
            }

            
        }

        private void btnClearComps_Click(object sender, EventArgs e)
        {
            dgvAddComps.Rows.Clear();
        }
       

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            CallForm callform = new CallForm();
            callform.Show();
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out and exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }           
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblProductDetailsID.Text))
            {
                MessageBox.Show("Please select contract you want to cancel.","Cancellation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                ClientProducts.CancelProduct(clientNr,Convert.ToInt32(lblProductDetailsID.Text));
                dgvClientProductDetails.Refresh();
            }
           
        }

        private void dgvClientProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProductDetailsID.DataBindings.Clear();
            lblProductDetailsID.DataBindings.Add("Text", c, "ClientProductsID");
        }
    }
}
