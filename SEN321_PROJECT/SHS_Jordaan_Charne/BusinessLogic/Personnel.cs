using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Personnel : Person
    {
        private int employeeNumber;

        public int EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }


        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        private string hireDate;

        public string HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }


        public Personnel(string idNumber, string firstName, string lastName, string email, string phoneNumber, int employeeNumber, string username, string password, string jobTitle, int addressID) : base(idNumber, firstName, lastName, email, phoneNumber, addressID)
        {
            this.employeeNumber = employeeNumber;
            this.username = username;
            this.password = password;
            this.jobTitle = jobTitle;
            
        }
        public Personnel(string idNumber, string firstName, string lastName, string email, string phoneNumber,int employeeNumber,string jobTitle, int addressID) : base(idNumber, firstName, lastName, email, phoneNumber, addressID)
        {
            this.employeeNumber = employeeNumber;
            this.jobTitle = jobTitle;           
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}",EmployeeNumber, FirstName, LastName );
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static List<Personnel> GetTechnicians()
        {
            DataTable dt = Data.GetTechnicians();
            List<Personnel> technicianList = new List<Personnel>();
            foreach (DataRow item in dt.Rows)
            {
                technicianList.Add(new Personnel(item["IDNumber"].ToString(),item["FirstName"].ToString(),item["LastName"].ToString(), item["Email"].ToString(), item["PhoneNumber"].ToString(),Convert.ToInt32(item["PersonnelID"]), item["JobTitle"].ToString(), Convert.ToInt32(item["AddressID"])));
            }
            return technicianList;
        }

        public static List<Personnel> GetEmployeesLogin()
        {
            DataTable dt = Data.GetEmployees();
            List<Personnel> employeeList = new List<Personnel>();
            foreach (DataRow item in dt.Rows)
            {
                employeeList.Add(new Personnel(item["IDNumber"].ToString(), item["FirstName"].ToString(), item["LastName"].ToString(), item["Email"].ToString(), item["PhoneNumber"].ToString(), Convert.ToInt32(item["PersonnelID"]),item["Username"].ToString(),item["Password"].ToString(), item["JobTitle"].ToString(), Convert.ToInt32(item["AddressID"])));
            }
            return employeeList;
        }
       
        public static List<Personnel> FindAvailableTechnicians(DateTime appointmentDate)
        {
            string theDate = appointmentDate.ToString("yyyy-MM-dd");
            DataTable dt = Data.GetAvailableTechnicians(theDate);
            List<Personnel> technicianList = new List<Personnel>();
            foreach (DataRow item in dt.Rows)
            {
                technicianList.Add(new Personnel(item["IDNumber"].ToString(), item["FirstName"].ToString(), item["LastName"].ToString(), item["Email"].ToString(), item["PhoneNumber"].ToString(), Convert.ToInt32(item["PersonnelID"]), item["JobTitle"].ToString(), Convert.ToInt32(item["AddressID"])));
            }
            return technicianList;
        }

        public static int Login(string username, string password)
        {
            int personnelID = 0;
            List<Personnel> personnelList = GetEmployeesLogin();
            //bool errors = false;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username!","Enter username",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //errors = true;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password!", "Enter password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (Personnel item in personnelList)
            {
                if (item.username == username && item.password == password)
                {
                    personnelID = item.EmployeeNumber;
                    MessageBox.Show("Success!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return personnelID;
                }
                else
                {
                    MessageBox.Show("Incorrect login details!","Login denied",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            //MessageBox.Show("Succes!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return personnelID;

        }
    }
}