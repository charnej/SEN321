using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataHandler
{
    public class Data
    {

        public static SqlConnection ConnectDB()
        {
            //string str = "Data Source=USER-PC;Initial Catalog=testSHS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string str = "Data Source=USER-PC;Integrated Security=SSPI;Initial Catalog=SmartHomeSystems";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            return conn;
        }

        //public static SqlConnection ConnectDB()
        //{
        //    string str = "Data Source=USER-PC;Initial Catalog=testSHS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //    SingletonSQLConnection test = SingletonSQLConnection.GetInstance();
        //    SqlConnection conn2;
        //    using (SqlConnection conn = test.GetOrCreateConnection())
        //    {
        //        conn.Open();
        //        conn2 = conn;
        //    }
        //    return conn2;
        //}

        #region CLIENT DETAILS

        //Gets client details and puts it in a datatable
        public static DataTable GetClient()
        {
            string queryString = "SELECT * from Client INNER JOIN Person on Client.IDNumber = Person.IDNumber";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet clients = new DataSet();
            adapter.FillSchema(clients, SchemaType.Source, "Client");
            adapter.Fill(clients, "Client");
            DataTable dt = clients.Tables["Client"];

            return dt;
        }

        // gets all person details and stores it in a datatable
        public static DataTable GetPerson()
        {
            string queryString = "SELECT * FROM Person";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet person = new DataSet();
            adapter.FillSchema(person, SchemaType.Source, "Person");
            adapter.Fill(person, "Person");
            DataTable dt = person.Tables["Person"];

            return dt;
        }

        public static DataTable SearchClient(string id)
        {
            // string query = "SELECT * from Client INNER JOIN Person on Client.IDNumber = Person.IDNumber where Client.IDNumber = '"+id+"'";
            string query = "SELECT  Client.ClientID, Person.IDNumber,Person.FirstName, Person.LastName, Person.PhoneNumber, Person.Email, Client.NewsLetters, Address.HouseNumber, Address.StreetName, Address.Suburb,Address.City, Address.Province,Address.PostalCode from Person INNER JOIN Client on Client.IDNumber = Person.IDNumber INNER JOIN Address on Person.AddressID = Address.AddressID WHERE Person.IDNumber = '" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectDB());
            DataSet clients = new DataSet();
            adapter.FillSchema(clients, SchemaType.Source, "Client");
            adapter.Fill(clients, "Client");
            DataTable dt = clients.Tables["Client"];

            return dt;
        }

        // uses a stored procedure to search for a particular client
        public static DataTable SearchClientSP(string id)
        {
            SqlCommand cmd = new SqlCommand("DisplayClient",ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idnumber", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet clients = new DataSet();
            adapter.FillSchema(clients, SchemaType.Source, "Client");
            adapter.Fill(clients, "Client");
            DataTable dt = clients.Tables["Client"];

            return dt;
        }

        //updates client information
        public static void UpdateClient(string name, string surname, string email, string phonenumber, string housenumber, string streetname, string suburb, string city, string province, string postalcode, string ID)
        {
            string queryString = "UPDATE Person SET FirstName = '" + name + "', LastName = '" + surname + "' WHERE Person.IDNumber = '" + ID + "'";
            SqlCommand command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();
            queryString = @"UPDATE Address SET HouseNumber = '" + housenumber + "', StreetName = '" + streetname + "', Suburb = '" + suburb + "', City = '" + city + "', Province = '" + province + "', PostalCode = '" + postalcode + "' WHERE Address.AddressID = (SELECT Person.AddressID FROM Person WHERE Person.IDNumber = '" + ID + "') ";
            command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();
        }

        public static void AddClient(string clientNumber, string IDNumber, string name, string surname, string email, string phonenumber, int housenumber, string streetname, string suburb, string city, string province, string postalcode, string newsletter)
        {
            string queryString = "INSERT INTO Address (HouseNumber, StreetName, Suburb, City, Province, PostalCode) VALUES ('" + housenumber + "', '" + streetname + "', '" + suburb + "', '" + city + "', '" + province + "', '" + postalcode + "')";
            SqlCommand command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();

            command = new SqlCommand("SELECT TOP(1) AddressID FROM Address ORDER BY 1 DESC", ConnectDB());
            int addressID = Convert.ToInt32(command.ExecuteScalar()); //gets the newest inserted address ID

            queryString = "INSERT INTO Person (IDNumber, FirstName, LastName, Email, PhoneNumber, AddressID) VALUES ('" + IDNumber + "','" + name + "', '" + surname + "', '" + email + "', '" + phonenumber + "', '" + addressID + "')";
            command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();

            command = new SqlCommand("SELECT TOP(1) IDNumber FROM Person ORDER BY 1 DESC", ConnectDB());
            string id = command.ExecuteScalar().ToString(); //gets the newest inserted ID

            queryString = "INSERT INTO Client (ClientID,NewsLetters, IDNumber) VALUES ('" + clientNumber + "', '" + newsletter + "', '" + id + "')";
            command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();

        }

        //adding a client via a stored procedure
        public static void AddClientSP(string clientNumber, string IDNumber, string name, string surname, string email, string phonenumber, string housenumber, string streetname, string suburb, string city, string province, string postalcode, string newsletter)
        {
            SqlCommand cmd = new SqlCommand("AddClient", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            //specifying what the parameters are and their data types
            cmd.Parameters.AddWithValue("@clientnumber", SqlDbType.Char).Value = clientNumber;
            cmd.Parameters.AddWithValue("@idnumber", SqlDbType.VarChar).Value = IDNumber;
            cmd.Parameters.AddWithValue("@fname", SqlDbType.VarChar).Value = name;
            cmd.Parameters.AddWithValue("@surname", SqlDbType.VarChar).Value = surname;
            cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.AddWithValue("@phone", SqlDbType.VarChar).Value = phonenumber;
            cmd.Parameters.AddWithValue("@housenr", SqlDbType.VarChar).Value = housenumber;
            cmd.Parameters.AddWithValue("@streetname", SqlDbType.VarChar).Value = streetname;
            cmd.Parameters.AddWithValue("@suburb", SqlDbType.VarChar).Value = suburb;
            cmd.Parameters.AddWithValue("@city", SqlDbType.VarChar).Value = city;
            cmd.Parameters.AddWithValue("@province", SqlDbType.VarChar).Value = province;
            cmd.Parameters.AddWithValue("@postal", SqlDbType.VarChar).Value = postalcode;
            cmd.Parameters.AddWithValue("@newsletter", SqlDbType.Char).Value = newsletter;

            cmd.ExecuteNonQuery();
        }
        #endregion

        #region PRODUCT DETAILS
        public static DataTable GetProducts() //a method to get all products from the database
        {
            string queryString = "SELECT ProductID, ProductName, ProductDescription FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet products = new DataSet();
            adapter.FillSchema(products, SchemaType.Source, "Product");
            adapter.Fill(products, "Product");
            DataTable dt = products.Tables["Product"];

            return dt;
        }
       
        public static void CancelProduct(string clientid, DateTime canceldate, int cpID)
        {
            string queryString = "UPDATE ClientProducts SET CancelDate = '" + canceldate + "' WHERE ClientID = '" + clientid + "' AND ClientProductsID = '"+cpID+"'";
            SqlCommand command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();
        }

        public static void UpdateProductSP(int productid, string productname, string description)
        {
            SqlCommand cmd = new SqlCommand("UpdateProducts", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productid", SqlDbType.Int).Value = productid;
            cmd.Parameters.AddWithValue("@productname", SqlDbType.VarChar).Value = productname;
            cmd.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = description;
            cmd.ExecuteNonQuery();
        }

        public static void AddProductSP(string productname, string description)
        {
            SqlCommand cmd = new SqlCommand("AddProducts", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productname", SqlDbType.VarChar).Value = productname;
            cmd.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = description;
            cmd.ExecuteNonQuery();
        }

        #endregion

        #region ORDERS
        public static void AddOrder(string clientid, string productName, Dictionary<string, int> compNameQuantity, string contract, int personnelID)
        {
            // inserts orders into the orders table
            string queryString = "INSERT INTO Orders (OrderDate, ClientID, PersonnelID) VALUES ('" + DateTime.Today.ToString("yyyy-MM-dd") + "', '" + clientid + "', '"+personnelID+"')";
            SqlCommand command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();

            //selects the latest inserted ID in order to add it to the order details table
            command = new SqlCommand("SELECT TOP(1) OrderNumber FROM Orders ORDER BY 1 DESC", ConnectDB());
            int ordernr = Convert.ToInt32(command.ExecuteScalar());

            //selects the appropriate product ID by looking for the products name
            command = new SqlCommand("SELECT Product.ProductID FROM Product WHERE Product.ProductName = '"+productName+"'", ConnectDB());
            int prID = Convert.ToInt32(command.ExecuteScalar());

            // the dictionary will contain the component as key, and the quantity as the value
            Dictionary<int, int> compIdQuantity = new Dictionary<int, int>();
            foreach (var item in compNameQuantity.Keys)
            {
                command = new SqlCommand("SELECT ComponentID FROM Component WHERE Component.ComponentName = '" + item + "'", ConnectDB());
                int compID = Convert.ToInt32(command.ExecuteScalar());
                compIdQuantity.Add(compID, compNameQuantity[item]);
            }

            foreach (var compId in compIdQuantity.Keys)
            {
                queryString = "INSERT INTO OrderDetail (OrderNumber, ProductID, ComponentID, ComponentQty) VALUES ('" + ordernr + "', '" + prID + "', '" + compId + "', '" + compIdQuantity[compId] + "')";
                command = new SqlCommand(queryString, ConnectDB());
                command.ExecuteNonQuery();
            }

            queryString = "INSERT INTO ClientProducts (ClientID, ProductID, Contract, ContractStartDate) VALUES ('" + clientid + "', '" + prID + "',  '" + contract + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "')";
            command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();
        }

        public static void AddOrder1(string clientid, string productName, Dictionary<string, int> compNameQuantity)
        {
            string queryString = "INSERT INTO Orders (OrderDate, ClientID, PersonnelID) VALUES ('" + DateTime.Today.ToString("yyyy-MM-dd") + "', '" + clientid + "', '1')";
            SqlCommand command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();

            command = new SqlCommand("SELECT TOP(1) OrderNumber FROM Orders ORDER BY 1 DESC", ConnectDB());
            int ordernr = Convert.ToInt32(command.ExecuteScalar());


            command = new SqlCommand("SELECT Product.ProductID FROM Product WHERE Product.ProductName = '" + productName + "'", ConnectDB());
            int prID = Convert.ToInt32(command.ExecuteScalar());



            Dictionary<int, int> compIdQuantity = new Dictionary<int, int>();

            foreach (var item in compNameQuantity.Keys)
            {
                command = new SqlCommand("SELECT ComponentID FROM Component WHERE Component.ComponentName = '" + item + "'", ConnectDB());
                int compID = Convert.ToInt32(command.ExecuteScalar());
                compIdQuantity.Add(compID, compNameQuantity[item]);
            }

            foreach (var compId in compIdQuantity.Keys)
            {
                queryString = "INSERT INTO OrderDetail (OrderNumber, ProductID, ComponentID, ComponentQty) VALUES ('" + ordernr + "', '" + prID + "', '" + compId + "', '" + compIdQuantity[compId] + "')";
                command = new SqlCommand(queryString, ConnectDB());
                command.ExecuteNonQuery();
            }

            queryString = "INSERT INTO ClientProducts (ClientID, ProductID) VALUES ('" + clientid + "', '" + prID + "')";
            command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();
        }

        public static DataTable GetOrderDetails(string clientid)
        {
            string queryString = @"SELECT DISTINCT Person.FirstName, Person.LastName, Product.ProductName, OrderDate
                                    FROM Orders
                                    INNER JOIN OrderDetail ON Orders.OrderNumber = OrderDetail.OrderNumber
                                    INNER JOIN Product ON OrderDetail.ProductID = Product.ProductID
                                    INNER JOIN Client ON Orders.ClientID = Client.ClientID
                                    INNER JOIN Person ON Client.IDNumber = Person.IDNumber
                                    WHERE Client.ClientID = '" + clientid + "' ";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet orderDetails = new DataSet();
            adapter.FillSchema(orderDetails, SchemaType.Source, "OrderDetail");
            adapter.Fill(orderDetails, "OrderDetail");
            DataTable dt = orderDetails.Tables["OrderDetail"];

            return dt;
        }

        public static DataTable GetOrders()
        {
            string queryString = @"SELECT * FROM Orders";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet orders = new DataSet();
            adapter.FillSchema(orders, SchemaType.Source, "Orders");
            adapter.Fill(orders, "Orders");
            DataTable dt = orders.Tables["Orders"];

            return dt;
        }

        #endregion

        #region COMPONENTS
        public static DataTable GetComponents()
        {
            string queryString = "SELECT * FROM Component";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet products = new DataSet();
            adapter.FillSchema(products, SchemaType.Source, "Component");
            adapter.Fill(products, "Component");
            DataTable dt = products.Tables["Component"];

            return dt;
        }

        public static void UpdateComponents(string componentname, double cost, int qty, int ID)
        {
            string queryString = "UPDATE Component SET ComponentName = '" + componentname + "', ComponentCost = '" + cost + "', Quantity = '" + qty + "' WHERE ComponentID = '" + ID + "'";
            SqlCommand command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();
        }

        public static void ComponentsUpd()
        {
            string queryString = "SELECT * FROM Component";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet comps = new DataSet();
            adapter.FillSchema(comps, SchemaType.Source, "Component");
            adapter.Fill(comps, "Component");
            DataTable dt = comps.Tables["Component"];
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();

            adapter.Fill(dt);
            adapter.Update(dt);
            //adapter.Update(comps, "Component");
            MessageBox.Show("Component updated");

            //SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            //adapter.UpdateCommand = cb.GetUpdateCommand();
            //adapter.Fill(dt);
            //adapter.Update(dt);
        }

        public static void AddComponentSP(string compname, int qty, double cost)
        {
            SqlCommand cmd = new SqlCommand("AddComponent", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@compname", SqlDbType.VarChar).Value = compname;
            cmd.Parameters.AddWithValue("@compcost", SqlDbType.Money).Value = cost;
            cmd.Parameters.AddWithValue("@compqty", SqlDbType.Int).Value = qty;
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region CLIENT PRODUCTS
        public static DataTable GetClientProducts1()
        {
            string queryString = "SELECT ClientProductsID, ClientID, ProductID FROM ClientProducts";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet clientProduct = new DataSet();
            adapter.FillSchema(clientProduct, SchemaType.Source, "ClientProducts");
            adapter.Fill(clientProduct, "ClientProducts");
            DataTable dt = clientProduct.Tables["ClientProducts"];

            return dt;
        }

        public static DataTable GetClientProducts()
        {
            string queryString = "SELECT ClientProductsID, ClientID, ProductID FROM ClientProducts WHERE ClientProducts.CancelDate IS NULL ";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet clientProduct = new DataSet();
            adapter.FillSchema(clientProduct, SchemaType.Source, "ClientProducts");
            adapter.Fill(clientProduct, "ClientProducts");
            DataTable dt = clientProduct.Tables["ClientProducts"];

            return dt;
        }

        public static DataTable GetClientProductDetails(string id)
        {


            string queryString = @"SELECT ClientProductsID, Product.ProductName, ClientProducts.ContractStartDate, ClientProducts.CancelDate
            FROM Client
            INNER JOIN Person on Client.IDNumber = Person.IDNumber
            INNER JOIN ClientProducts on Client.ClientID = ClientProducts.ClientID
            INNER JOIN Product ON ClientProducts.ProductID = Product.ProductID
            WHERE Client.ClientID = '" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet clientProduct = new DataSet();
            adapter.FillSchema(clientProduct, SchemaType.Source, "ClientProducts");
            adapter.Fill(clientProduct, "ClientProducts");
            DataTable dt = clientProduct.Tables["ClientProducts"];

            return dt;
        }
        #endregion

        #region CONTRACTS
        public static DataTable GetContractTypes()
        {
            string queryString = "SELECT * FROM Contract";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet contractTypes = new DataSet();
            adapter.FillSchema(contractTypes, SchemaType.Source, "Contracts");
            adapter.Fill(contractTypes, "Contracts");
            DataTable dt = contractTypes.Tables["Contracts"];

            return dt;
        }

        public static void AddNewProductContract(string contractnum, string contractname, string contractdescr)
        {
            SqlCommand cmd = new SqlCommand("AddContract", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@contractnumber", SqlDbType.Char).Value = contractnum;
            cmd.Parameters.AddWithValue("@contractname", SqlDbType.VarChar).Value = contractname;
            cmd.Parameters.AddWithValue("@contractdescription", SqlDbType.VarChar).Value = contractdescr;
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region SERVICES
        public static DataTable GetServices()
        {
            string queryString = "SELECT * FROM Services";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet serviceTypes = new DataSet();
            adapter.FillSchema(serviceTypes, SchemaType.Source, "Services");
            adapter.Fill(serviceTypes, "Services");
            DataTable dt = serviceTypes.Tables["Services"];

            return dt;
        }
        #endregion
      
        #region EMPLOYEES
        public static DataTable GetTechnicians()
        {
            string queryString = @"SELECT *
                                    FROM Person
                                    INNER JOIN Personnel ON Person.IDNumber = Personnel.IDNumber
                                    WHERE Personnel.JobTitle = 'Technician'";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet personnel = new DataSet();
            adapter.FillSchema(personnel, SchemaType.Source, "Personnel");
            adapter.Fill(personnel, "Personnel");
            DataTable dt = personnel.Tables["Personnel"];
            return dt;

        }

        public static DataTable GetEmployees()
        {
            
                string queryString = @"SELECT *
                                    FROM Person
                                    INNER JOIN Personnel ON Person.IDNumber = Personnel.IDNumber
                                    WHERE Personnel.JobTitle = 'Call Agent'";

                SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
                DataSet personnel = new DataSet();
                adapter.FillSchema(personnel, SchemaType.Source, "Personnel");
                adapter.Fill(personnel, "Personnel");
                DataTable dt = personnel.Tables["Personnel"];
                return dt;
            

        }



        //public static DataTable GetEmployees()
        //{
        //    using (SqlConnection connection = ConnectDB())
        //    {
        //        string queryString = @"SELECT *
        //                            FROM Person
        //                            INNER JOIN Personnel ON Person.IDNumber = Personnel.IDNumber
        //                            WHERE Personnel.JobTitle = 'Call Agent'";

        //        SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
        //        DataSet personnel = new DataSet();
        //        adapter.FillSchema(personnel, SchemaType.Source, "Personnel");
        //        adapter.Fill(personnel, "Personnel");
        //        DataTable dt = personnel.Tables["Personnel"];
        //        return dt;
        //    }

        //}


        public static DataTable GetAvailableTechnicians(string appdate)
        {
            string queryString = @"SELECT *
                                FROM Person
                                INNER JOIN Personnel ON Person.IDNumber = Personnel.IDNumber
                                WHERE Personnel.JobTitle = 'Technician' AND
                                Personnel.PersonnelID NOT IN
		                                (SELECT TechnicianID
		                                FROM Appointments
		                                WHERE AppointmentDate = '" + appdate + "')";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet availableTechs = new DataSet();
            adapter.FillSchema(availableTechs, SchemaType.Source, "Personnel");
            adapter.Fill(availableTechs, "Personnel");
            DataTable dt = availableTechs.Tables["Personnel"];
            return dt;

        }

        #endregion

        #region APPOINTMENTS
        public static DataTable GetAppointments()
        {
            string queryString = @"SELECT AppointmentID ,AppointmentType, Appointments.AppointmentDate, Appointments.TechnicianID, Person.FirstName,Person.LastName, Appointments.ClientID
                                FROM Appointments
                                INNER JOIN Personnel ON Appointments.TechnicianID = Personnel.PersonnelID
                                INNER JOIN Person ON Personnel.IDNumber = Person.IDNumber";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet appointments = new DataSet();
            adapter.FillSchema(appointments, SchemaType.Source, "Appointments");
            adapter.Fill(appointments, "Appointments");
            DataTable dt = appointments.Tables["Appointments"];
            return dt;

        }

        public static void AddAppointment(string clientid, int technicianID, DateTime appdate, string appType)
        {
            SqlCommand cmd = new SqlCommand("AddAppointment", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@clientid", SqlDbType.Char).Value = clientid;
            cmd.Parameters.AddWithValue("@technicianid", SqlDbType.Int).Value = technicianID;
            cmd.Parameters.AddWithValue("@appdate", SqlDbType.Date).Value = appdate;
            cmd.Parameters.AddWithValue("@apptype", SqlDbType.Date).Value = appType;
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region INSTALLATIONS
        public static void AddInstallation(DateTime installdate, int technician, int clientproductid)
        {
            SqlCommand cmd = new SqlCommand("AddInstallation", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@instaldate", SqlDbType.Date).Value = installdate;
            cmd.Parameters.AddWithValue("@technician", SqlDbType.Int).Value = technician;
            cmd.Parameters.AddWithValue("@clientproductsid", SqlDbType.Int).Value = clientproductid;
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetInstallations()
        {
            string queryString = @"SELECT Installation.InstallationDate 'Installation Date', Person.FirstName +' ' + Person.LastName AS Technician
                                FROM Installation
                                INNER JOIN Personnel ON Installation.Technician = Personnel.PersonnelID
                                INNER JOIN Person ON Personnel.IDNumber = Person.IDNumber
                                INNER JOIN ClientProducts ON Installation.ClientProductsID = ClientProducts.ClientProductsID
                                INNER JOIN Client ON Client.ClientID = ClientProducts.ClientID";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet installation = new DataSet();
            adapter.FillSchema(installation, SchemaType.Source, "Installation");
            adapter.Fill(installation, "Installation");
            DataTable dt = installation.Tables["Installation"];

            return dt;
        }
        #endregion

        #region INVOICE

        public static void InvoiceTest(string clientid)
        {
            SqlCommand cmd = new SqlCommand("Invoice", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@client", SqlDbType.Char).Value = clientid;            
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetClientInvoiceDetails(string clientid)
        {


            string queryString = @"SELECT DISTINCT FirstName+' '+LastName AS 'Client Name', Client.ClientID, Orders.OrderDate, Product.ProductName, Orders.OrderNumber
                                FROM Person
                                INNER JOIN Client ON Person.IDNumber = Client.IDNumber
                                INNER JOIN Orders ON Client.ClientID = Orders.ClientID
                                INNER JOIN OrderDetail ON Orders.OrderNumber = OrderDetail.OrderNumber
                                INNER JOIN Product ON OrderDetail.ProductID = Product.ProductID
                                INNER JOIN Component ON OrderDetail.ComponentID = Component.ComponentID
                                WHERE Client.ClientID = '" + clientid + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet clientdetails = new DataSet();
            adapter.FillSchema(clientdetails, SchemaType.Source, "Client");
            adapter.Fill(clientdetails, "Client");
            DataTable dt = clientdetails.Tables["Client"];

            return dt;


        }

        public static DataTable GetCompInvoiceDetails(string clientid)
        {


            string queryString = @"SELECT  Component.ComponentName, Component.ComponentCost AS 'Unit Price', OrderDetail.ComponentQty, OrderDetail.ComponentQty*Component.ComponentCost AS 'Total Component Cost'
                                FROM Component
                                INNER JOIN OrderDetail ON Component.ComponentID = OrderDetail.ComponentID
                                INNER JOIN Orders ON OrderDetail.OrderNumber = Orders.OrderNumber
                                INNER JOIN Client ON Orders.ClientID = Client.ClientID
                                WHERE Client.ClientID = '" + clientid + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet clientdetails = new DataSet();
            adapter.FillSchema(clientdetails, SchemaType.Source, "Client");
            adapter.Fill(clientdetails, "Client");
            DataTable dt = clientdetails.Tables["Client"];

            return dt;
        }
        #endregion

        #region CLIENT CONFIGURATIONS
        public static DataTable GetClientConfigurations(string clientid)
        {
            string queryString = @"SELECT * FROM ClientConfigurations";

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet clientConfigurations = new DataSet();
            adapter.FillSchema(clientConfigurations, SchemaType.Source, "ClientConfigurations");
            adapter.Fill(clientConfigurations, "ClientConfigurations");
            DataTable dt = clientConfigurations.Tables["ClientConfigurations"];

            return dt;
        }
        #endregion

        #region SERVICE TICKETS
        public static void AddServiceTicket(string clientid)
        {
            SqlCommand cmd = new SqlCommand("AddServiceTicket", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@clientid", SqlDbType.VarChar).Value = clientid;            
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetServiceTicket()
        {
            string queryString = @"SELECT * FROM ServiceTickets WHERE Complete NOT IN ('yes')";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectDB());
            DataSet serviceTickets = new DataSet();
            adapter.FillSchema(serviceTickets, SchemaType.Source, "ServiceTickets");
            adapter.Fill(serviceTickets, "ServiceTickets");
            DataTable dt = serviceTickets.Tables["ServiceTickets"];

            return dt;
        }

        public static void UpdateServiceTicket(string complete, int ID)
        {
            string queryString = "UPDATE ServiceTickets SET Complete = '" + complete + "' WHERE ServiceTicketID = '" + ID + "'";
            SqlCommand command = new SqlCommand(queryString, ConnectDB());
            command.ExecuteNonQuery();
        }
        #endregion

        #region CALL INFORMATION
        public static void AddCallInfo(string clientid, string callStart, string callend, string notes, DateTime calldate)
        {
            SqlCommand cmd = new SqlCommand("AddCallInfo", ConnectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@clientid", SqlDbType.Char).Value = clientid;
            cmd.Parameters.AddWithValue("@callstart", SqlDbType.VarChar).Value = callStart;
            cmd.Parameters.AddWithValue("@callend", SqlDbType.VarChar).Value = callend;
            cmd.Parameters.AddWithValue("@callnotes", SqlDbType.VarChar).Value = notes;
            cmd.Parameters.AddWithValue("@calldate", SqlDbType.Date).Value = calldate;
            cmd.ExecuteNonQuery();
        }

        #endregion

        

    }      
}
