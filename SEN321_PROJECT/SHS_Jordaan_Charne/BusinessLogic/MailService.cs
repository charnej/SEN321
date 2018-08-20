using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    class MailService
    {
        public void OnInvoiceSent(object source, InvoiceEventArgs e)
        {
            MessageBox.Show("Mailservice: Emailing invoice" + e.Invoice.ClientName);
        }
    }
}
