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
    public partial class TechnicalSupport : Form
    {
        BindingSource b = new BindingSource();
        public TechnicalSupport()
        {
            InitializeComponent();
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            Form1 CM = new Form1();
            CM.Show();
            this.Hide();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            ProductManagement PM = new ProductManagement();
            PM.Show();
            this.Hide();
        }

        private void TechnicalSupport_Load(object sender, EventArgs e)
        {
            pnlOrders.Visible = false;
            List<ServiceTicket> serviceTicketList = ServiceTicket.GetServiceTickets();
            cmboAppType.SelectedIndex = 0;

            b.DataSource = serviceTicketList;
            cmboUnassigned.DataSource = b;

            //List<Personnel> personnelList = Personnel.GetTechnicians();
            //foreach (Personnel item in personnelList)
            //{
            //    tvPersonnel.Nodes.Add(item.FirstName + " " + item.LastName);

            //}

            

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            
            if (tvPersonnel.SelectedNode != null)
            {
                if (string.IsNullOrEmpty(cmboUnassigned.Text))
                {
                    MessageBox.Show("Please select unassigned order", "Select order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tvPersonnel.SelectedNode.Nodes.Add(cmboUnassigned.SelectedItem.ToString());
                    Installation.AddInstallation(tvPersonnel.SelectedNode.Text);
                    Appointments.AddAppointment(dateTimePicker1.Value, cmboAppType.Text, tvPersonnel.SelectedNode.Text);
                }
            }
            else
            {
                MessageBox.Show("Please select technician", "Select Technician", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //tvPersonnel.SelectedNode.Nodes.Add(cmboUnassigned.SelectedItem.ToString());
            //Installation.AddInstallation(tvPersonnel.SelectedNode.Text);
        }

        private void btnFindTechnicians_Click(object sender, EventArgs e)
        {
            tvPersonnel.Nodes.Clear();
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            List<Personnel> availableTechs = Personnel.FindAvailableTechnicians(Convert.ToDateTime(theDate));
            foreach (Personnel item in availableTechs)
            {
                tvPersonnel.Nodes.Add(item.FirstName + " " + item.LastName);

            }
            pnlOrders.Visible = true;

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
    }
}
