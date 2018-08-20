using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHS
{
    public partial class InvoiceForm : Form
    {
        BindingSource b = new BindingSource();
        BindingSource c = new BindingSource();
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
           
            textBox2.Text = Form1.clientNumber;


            b.DataSource = Invoice.clientInvDetails(textBox2.Text);
            c.DataSource = Invoice.compInvDetails(textBox2.Text);

            dataGridView1.DataSource = c;

            textBox1.DataBindings.Add("Text", b, "Client Name");
            textBox3.DataBindings.Add("Text", b, "OrderNumber");
            textBox4.DataBindings.Add("Text", b, "OrderDate");
            textBox5.DataBindings.Add("Text", b, "ProductName");



            //bool clientFound = ClientProducts.CheckClientProducts1(textBox2.Text);

            //if (clientFound == false)
            //{
            //    ClearBindings();
            //}
            //else
            //{
            //    b.DataSource = Invoice.clientInvDetails(textBox2.Text);
            //    c.DataSource = Invoice.compInvDetails(textBox2.Text);

            //    dataGridView1.DataSource = c;

            //    textBox1.DataBindings.Add("Text", b, "Client Name");
            //    textBox3.DataBindings.Add("Text", b, "OrderNumber");
            //    textBox4.DataBindings.Add("Text", b, "OrderDate");
            //    textBox5.DataBindings.Add("Text", b, "ProductName");
            //}

            //b.DataSource = Invoice.clientInvDetails(textBox2.Text);
            //c.DataSource = Invoice.compInvDetails(textBox2.Text);

            //dataGridView1.DataSource = c;

            //textBox1.DataBindings.Add("Text", b, "Client Name");
            //textBox3.DataBindings.Add("Text", b, "OrderNumber");
            //textBox4.DataBindings.Add("Text", b, "OrderDate");
            //textBox5.DataBindings.Add("Text", b, "ProductName");

        }

        private void btnEmailInvoice_Click(object sender, EventArgs e)
        {
            Invoice.InvSend();
        }

        private void ClearBindings()
        {
            // clientnr.DataBindings.Clear();
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
