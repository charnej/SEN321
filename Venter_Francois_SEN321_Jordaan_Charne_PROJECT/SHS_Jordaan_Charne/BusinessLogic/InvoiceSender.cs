using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    class InvoiceSender
    {
        // define a delegate
        // define event based on delegate
        // raise event

        public delegate void InvoiceSentEventHandler(object source, InvoiceEventArgs args);

        public event InvoiceSentEventHandler InvoiceSent;

        public void SendInvoice(Invoice invoice)
        {
            MessageBox.Show("Sending Invoice..");

            OnInvoiceSent(invoice);
        }

        protected virtual void OnInvoiceSent(Invoice invoice)
        {
            if (InvoiceSent != null)         
                InvoiceSent(this, new InvoiceEventArgs() {Invoice = invoice});
            
        }
    }
}
