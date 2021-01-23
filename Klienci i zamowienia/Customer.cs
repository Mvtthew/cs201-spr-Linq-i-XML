using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Klienci_i_zamowienia
{
    public class Customer
    {
        [XmlElement("CustomerID")]
        public string CustomerID;

        [XmlElement("CompanyName")]
        public string CompanyName;

        [XmlElement("City")]
        public string City;

        [XmlElement("Country")]
        public string Country;

        [XmlElement("Orders", typeof(List<Order>))]
        public List<Order> Orders;
    }

    [XmlRoot("Customers")]
    public class Customers
    {
        [XmlElement("Customer", typeof(Customer))]
        public List<Customer> Customer;
    }
}
