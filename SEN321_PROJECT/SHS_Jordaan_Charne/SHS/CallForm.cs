using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHS
{
    public partial class CallForm : Form
    {
      
        public CallForm()
        {
            InitializeComponent();
           
        }
       

        private void CallForm_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;

            txtCallStart.Text = time.ToString("HH:mm:ss");
        }

        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;

            txtCallEnd.Text = time.ToString("HH:mm:ss");
        }

        private void btnAddCallInfo_Click(object sender, EventArgs e)
        {
            label2.Text = Form1.clientNumber;
            
                BusinessLogic.CallInformation.AddCallInfo(label2.Text, txtCallStart.Text, txtCallEnd.Text, txtCAllNotes.Text, DateTime.Now);
               //MessageBox.Show("Call Information added", "Call Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
