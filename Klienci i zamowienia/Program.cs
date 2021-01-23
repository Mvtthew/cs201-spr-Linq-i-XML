using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Klienci_i_zamowienia
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Customers));

            using (FileStream stream = File.OpenRead("Data.xml")) {
                Customers customers = (Customers)serializer.Deserialize(stream);

                int year = int.Parse(Console.ReadLine());

                List<Customer> inThisYear = customers.Customer.Where(c => (c.Orders.Where(o => o.OrderDate.Year == year).ToList().Count) > 0).OrderBy(c => c.Country).ThenBy(c => c.City).ThenBy(c => c.CompanyName).ToList();

                if (inThisYear.Count == 0)
                {
                    Console.WriteLine("empty");
                } else
                {
                    foreach (var c in inThisYear)
                    {
                        Console.WriteLine($"{c.CompanyName}");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
