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
using System.Data.SqlClient;
using DataHandler;

namespace SHS
{
    public partial class Login : Form
    {
        //SqlDataAdapter adapter;
        //DataSet ds;
        //SqlCommandBuilder cmb;
        public static int sendPersonnelID;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
           


        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                epUsername.SetError(txtUsername, "Please enter username.");
            }

            else
            {
                e.Cancel = false;
                epUsername.SetError(txtUsername, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //MessageBox.Show(txtUsername.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int personnelID = Personnel.Login(txtUsername.Text, txtPassword.Text);

            label1.Text = personnelID.ToString();

            if (personnelID > 0)
            {
                sendPersonnelID = Convert.ToInt32(label1.Text);
                Form1 CM = new Form1();
                CM.Show();
                this.Hide();
               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
