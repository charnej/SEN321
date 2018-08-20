using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ClientDetailsList
    {
        public static DataTable ClientDetailList(string id)
        {
            //List<Person> person = Person.GetPerson();
            //List<Client> client = Client.GetClient();
            //List<Product> product = Product.GetProducts();
            //List<ClientProducts> clientProduct = ClientProducts.GetCP();

            //var result = from p in person
            //             join c in client on p.IDNumber equals c.IDNumber
            //             join cp in clientProduct on c.ClientNumber equals cp.ClientID
            //             join pr in product on cp.ProductID equals pr.ProductNumber
            //             select  pr.ProductName;



            //return result.ToList();

            DataTable dt = Data.GetClientProductDetails(id);

            return dt;
        }
    }
}
