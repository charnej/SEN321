using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Address
    {       
            private int addressID;

            public int AddressID
            {
                get { return addressID; }
                set { addressID = value; }
            }

            private string houseNumber;

            public string HouseNumber
            {
                get { return houseNumber; }
                set { houseNumber = value; }
            }
        private string suburb;

        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        private string streetName;

            public string StreetName
            {
                get { return streetName; }
                set { streetName = value; }
            }

            private string city;

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            private string postalCode;

            public string PostalCode
            {
                get { return postalCode; }
                set { postalCode = value; }
            }

            private string province;

            public string Province
            {
                get { return province; }
                set { province = value; }
            }


            public Address(int addressID, string houseNumber, string streetName, string suburb, string city, string province, string postalCode)
            {
            this.addressID = addressID;
            this.houseNumber = houseNumber;
            this.streetName = streetName;
            this.suburb = suburb;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
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
