using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Person
    {

        private string idNumber;

        public string IDNumber
        {
            get { return idNumber; }
            set { //idNumber = value;
                idNumber = (value == null) || (value == string.Empty) ? "(no name)" : value;
            }
        }


        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { //firstName = value;
                firstName = (value == null) || (value == string.Empty) ? "(no name)" : value;
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { //lastName = value; 
                lastName = (value == null) || (value == string.Empty) ? "(no name)" : value;
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { //email = value;
                email = (value == null) || (value == string.Empty) ? "(no name)" : value;
            }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { //phoneNumber = value;
                phoneNumber = (value == null) || (value == string.Empty) ? "(no name)" : value;
            }
        }

        private int address;

        public int Address
        {
            get { return address; }
            set { address = value; }
        }

        public Person(string idNumber, string firstName, string lastName, string email, string phoneNumber, int addressID)
        {
            this.idNumber = idNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            
        }

        public static List<Person> GetPerson()
        {
            List<Person> person = new List<Person>();
            DataTable dt = Data.GetPerson();

            foreach (DataRow item in dt.Rows)
            {
                person.Add(new Person(item["IDNumber"].ToString(), item["FirstName"].ToString(), item["LastName"].ToString(), item["Email"].ToString(), item["PhoneNumber"].ToString(), Convert.ToInt32(item["AddressID"])));
            }

            return person;
        }

        public int CalcAge(int year, int DOB)
        {
            return year - DOB;
        }

        public override string ToString()
        {
            return base.ToString();
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
