using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Klienci_i_zamowienia
{
    public class Order
    {
        [XmlElement("OrderID")]
        public int OrderID;

        [XmlElement("OrderDate")]
        public DateTime OrderDate;

        [XmlElement("Total")]
        public decimal Total; 
    }
}
