using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandler;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class CallInformation
    {
        private int callID;

        public int CallID
        {
            get { return callID; }
            set { callID = value; }
        }
        private string clientID;

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        private string callStart;

        public string CallStart
        {
            get { return callStart; }
            set { callStart = value; }
        }

        private string callEnd;

        public string CallEnd
        {
            get { return callEnd; }
            set { callEnd = value; }
        }

        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        private DateTime callDate;
       
        public DateTime CallDate
        {
            get { return callDate; }
            set { callDate = value; }
        }
        public CallInformation(int callID, string clientID, string callStart, string callEnd, string notes, DateTime callDate)
        {
            this.callID = callID;
            this.clientID = clientID;
            this.callStart = callStart;
            this.callEnd = callEnd;
            this.notes = notes;
            this.callDate = callDate;
        }
        
        public static void AddCallInfo(string clientid, string callstart, string callend, string notes, DateTime calldate)
        {
            bool error = false;
            if (string.IsNullOrEmpty(clientid))
            {
                error = true;
                MessageBox.Show("Please search for a client in the client details tab", "Call Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(notes))
            {
                error = true;
                MessageBox.Show("Please enter call notes.","Call Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(callend.ToString()))
            {
                error = true;
                MessageBox.Show("Please end the call before submitting call information.", "Call Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (error == false)
            {
                Data.AddCallInfo(clientid, callstart, callend, notes, calldate);
                MessageBox.Show("Call Information added", "Call Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                               

            }
            
        }

    }
}
