using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Appointments
    {
        private int appointmentID;

        public int AppointmentID
        {
            get { return appointmentID; }
            set { appointmentID = value; }
        }

        private string clientID;

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        private int technicianID;

        public int TechnicianID
        {
            get { return technicianID; }
            set { technicianID = value; }
        }

        private DateTime appDate;

        public DateTime AppDate
        {
            get { return appDate; }
            set { appDate = value; }
        }

        private string appType;


        public string AppType
        {
            get { return appType; }
            set { appType = value; }
        }


        public Appointments(int appointmentID, string clientID, int technicianID, DateTime appDate, string appType)
        {
            this.appointmentID = appointmentID;
            this.clientID = clientID;
            this.technicianID = technicianID;
            this.appDate = appDate;
            this.appType = appType;
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", appointmentID, appType, clientID, technicianID);
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Gets a list of appointments
        public static List<Appointments> GetAppointments()
        {
            DataTable dt = Data.GetAppointments();
            List<Appointments> appointmentList = new List<Appointments>();
            foreach (DataRow item in dt.Rows)
            {
                appointmentList.Add(new Appointments(Convert.ToInt32(item["AppointmentID"]),item["ClientID"].ToString(), Convert.ToInt32(item["TechnicianID"]), Convert.ToDateTime(item["AppointmentDate"]),item["AppointmentType"].ToString()));
            }
            return appointmentList;
        }

        // finds all appointments belonging to a particular technician
        public static List<Appointments> FindTechnicianAppointments(string id)
        {
            List<Appointments> appList = GetAppointments();
            List<Appointments> newAppList = new List<Appointments>();
            string techName = id;
            string[] wordSplit = techName.Split(' ');
            int techID = Convert.ToInt32(wordSplit[0]);

            foreach (Appointments item in appList)
            {
                if (item.technicianID == techID)
                {
                    newAppList.Add(item);
                }
            }
            return newAppList;

        }

        //adds a new appointment
        public static void AddAppointment( DateTime appdate, string appType, string technicianName)
        {
            int technician = 0;
            List<Personnel> technicianList = Personnel.GetTechnicians();
            List<ServiceTicket> serviceTicketList = ServiceTicket.GetServiceTickets();
            List<Orders> orderList = Orders.GetOrders();
            string clientID = "null";

            // gets the employee number from the employee name
            foreach (Personnel item in technicianList)
            {
                if (technicianName.Contains(item.FirstName) && technicianName.Contains(item.LastName))
                {
                    technician = item.EmployeeNumber;
                    //MessageBox.Show(technician.ToString());
                }
            }

            // gets the client number via the order number that is in the service ticket table.
            foreach (ServiceTicket item in serviceTicketList)
            {
                foreach (Orders order in orderList)
                {
                    if (item.OrderNumber == order.OrderNumber)
                    {
                        clientID = order.ClientNumber;
                    }
                }
            }

            Data.AddAppointment(clientID, technician, appdate, appType);
            MessageBox.Show("Appointment Added.", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
