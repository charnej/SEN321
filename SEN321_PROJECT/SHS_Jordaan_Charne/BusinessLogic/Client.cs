using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Client : Person
    {              
                
        private string clientNumber;

        public string ClientNumber
        {
            get { return clientNumber; }
            set {// clientNumber = value;
                clientNumber = (value == null) || (value == string.Empty) ? "(no name)" : value;
            }
            
        }
       

        private string newsLetter;

        public string NewsLetter
        {
            get { return newsLetter; }
            set { //newsLetter = value;
                newsLetter = (value == null) || (value == string.Empty) ? "(no name)" : value;
            }
        }

        public Client(string clientNumber, string newsLetter, string idNumber, string firstName, string lastName, string email, string phoneNumber, int addressID) : base(idNumber, firstName, lastName, email, phoneNumber, addressID)
        {
            this.newsLetter = newsLetter;
            this.clientNumber = clientNumber;
        }

        public Client(string idNumber, string firstName, string lastName, string email, string phoneNumber, string newsLetter, int addressID) : base(idNumber, firstName, lastName, email, phoneNumber, addressID)
        {
            this.newsLetter = newsLetter;
            
        }
        public Client(string idNumber, string firstName, string lastName, string email, string phoneNumber, int addressID) : base(idNumber, firstName, lastName, email, phoneNumber, addressID)
        {
            

        }
        

        public override string ToString()
        {
            return string.Format("{0} {1}", clientNumber, newsLetter);
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static DataTable SearchPerson(string id)
        {
            // DataTable dataT = Data.SearchClient(id);
            DataTable dataT = Data.SearchClientSP(id);
            bool exists = dataT.Select().ToList().Exists(row => row["IDNumber"].ToString() == id);

            if (exists)
            {
                MessageBox.Show("Client Found!");
                return dataT;
            }
            else
            {
                MessageBox.Show("Client does not exist!","Client",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }

        }
        
        // this method gets the client number from a datatable, and returns the client number as a string.
        public static string GetClientNumber(string id)
        {
            DataTable dataT = Data.SearchClient(id);
            string clientNumber;

            foreach (DataRow item in dataT.Rows)
            {
                if (item["IDNumber"].Equals(id))
                {
                    clientNumber = item["ClientID"].ToString();
                   // MessageBox.Show(clientNumber);
                    return clientNumber;
                    
                }
                else
                {                  
                    return null;
                }
            }
            
            return null;

        }

        public static void UpdatePerson(string name, string surname, string email, string phonenumber, string housenumber, string streetname, string suburb, string city, string province, string postalcode, string ID)
        {
            bool errors = false;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please search for a client to update!", "Client Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {// this try catch block checks if values are empty, and if they are, an exception is thrown.
                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(phonenumber) || String.IsNullOrEmpty(housenumber.ToString()) || String.IsNullOrEmpty(streetname) || String.IsNullOrEmpty(suburb) || String.IsNullOrEmpty(city) || String.IsNullOrEmpty(province) || String.IsNullOrEmpty(postalcode))
                {
                    errors = true;
                    throw new EmptyFieldsException();
                }
            }
            catch (EmptyFieldsException e)
            {

                MessageBox.Show(e.Message);
            }
            if (phonenumber.All(Char.IsNumber) == false || phonenumber.Length>10)
            {
                errors = true;
                MessageBox.Show("The phone number may only contain numbers, and be no longer than 10 characters!", "Client Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // these if statements checks if the user inout contain either numbers or letters, and gives the user an appropriate message.
            if (name.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The client name may only contain letters!", "Client Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (surname.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The client surname may only contain letters!", "Client Surname", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (streetname.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The street name may only contain letters!", "Street Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (suburb.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The suburb name may only contain letters!", "Suburb Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (city.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The city name may only contain letters!", "City Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (postalcode.All(Char.IsNumber) == false)
            {
                errors = true;
                MessageBox.Show("The postal code may only contain numbers!", "Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (housenumber.All(Char.IsLetterOrDigit) == false)
            {
                errors = true;
                MessageBox.Show("The housenumber may only contain numbers and letters!", "House Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (errors == false)
            {
                Data.UpdateClient(name, surname, email, phonenumber, housenumber, streetname, suburb, city, province, postalcode, ID);
                MessageBox.Show("The client information has been updated!","Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }
        //this method returns a list of clients
        public static List<Client> GetClient()
        {
            List<Client> client = new List<Client>();
            DataTable dt = Data.GetClient();

            foreach (DataRow item in dt.Rows)
            {
                client.Add(new Client(item["ClientID"].ToString(), item["NewsLetters"].ToString(), item["IDNumber"].ToString(), item["FirstName"].ToString(), item["LastName"].ToString(), item["Email"].ToString(), item["PhoneNumber"].ToString(), Convert.ToInt32(item["AddressID"])));
            }

            return client;
        }

        // this method generates a random letter to be used in the client number.
        public static  string ClientNumberRandomLetter()
        {
            string[] myArray = new string[] { "A", "B", "C", "D", "E" };
            Random rng = new Random();
            int id = rng.Next(myArray.Count());

            string name = myArray[id];

            return name;
        }

        public static string EightDigitNumber()
        {
            Random rng = new Random();
            //int number = 1;

            int number = rng.Next(0, 99999999);
            string outputValue = number.ToString().PadLeft(8, '0');
            return outputValue;         
        }

        public static void AddClient( string idnumber, string name, string surname, string email, string phonenumber, string housenumber, string streetname, string suburb, string city, string province, string postalcode, string newsletter)
        {
            bool errors = false;
            string newClientNumber = ClientNumberRandomLetter() + EightDigitNumber();
            List<Person> personlist = Person.GetPerson();
            List<Client> clientList = GetClient();

            //validation starts here
            try
            {
                if (String.IsNullOrEmpty(idnumber) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(phonenumber) || String.IsNullOrEmpty(housenumber.ToString()) || String.IsNullOrEmpty(streetname) || String.IsNullOrEmpty(suburb) || String.IsNullOrEmpty(city) || String.IsNullOrEmpty(province) || String.IsNullOrEmpty(postalcode) || String.IsNullOrEmpty(newsletter))
                {
                    //if fields are empty a message box informs the user and sets errors to true.
                    errors = true;
                    throw new EmptyFieldsException();
                }
            }
            catch (EmptyFieldsException e)
            {

                MessageBox.Show(e.Message);
            }

            foreach (Client item in clientList)
            {
                if (item.clientNumber == newClientNumber)
                {
                    newClientNumber = newClientNumber + 1;
                }
            }

            foreach (Person item in personlist)
            {
                if (item.IDNumber == idnumber)
                {
                    MessageBox.Show("ID already in system");
                    errors = true;
                }
                if (item.Email == email)
                {
                    MessageBox.Show("Email Address already in system");
                    errors = true;
                }
                if (item.PhoneNumber == phonenumber)
                {
                    MessageBox.Show("Phone number already in system");
                    errors = true;
                }
            }
            if (phonenumber.All(Char.IsNumber) == false || phonenumber.Length > 10)
            {
                errors = true;
                MessageBox.Show("The phone number may only contain numbers, and be no longer than 10 characters!", "Client Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (name.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The client name may only contain letters!", "Client Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (surname.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The client surname may only contain letters!", "Client Surname", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (streetname.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The street name may only contain letters!", "Street Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (suburb.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The suburb name may only contain letters!", "Suburb Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (city.All(Char.IsLetter) == false)
            {
                errors = true;
                MessageBox.Show("The city name may only contain letters!", "City Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (postalcode.All(Char.IsNumber) == false)
            {
                errors = true;
                MessageBox.Show("The postal code may only contain numbers!", "Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (housenumber.All(Char.IsLetterOrDigit) == false)
            {
                errors = true;
                MessageBox.Show("The housenumber may only contain numbers and letters!", "House Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //if errors are true then a message box notifies the user to enter all necessary information correctly.
            if (errors == true)
            {
                MessageBox.Show("Please enter correct information");
            }
            //if errors are false then the new client gets added to the database.
            else
            {
                Data.AddClientSP(newClientNumber, idnumber, name, surname, email, phonenumber, housenumber, streetname, suburb, city, province, postalcode, newsletter);                
                MessageBox.Show("The client has been added.","Client Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }
    }
}