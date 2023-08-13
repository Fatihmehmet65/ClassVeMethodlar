using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Fatih Mehmet", 13, "Van");
            Customer customer1 = new Customer { Id = 14, City = "Van", Name = "Mehmet Fatih" };
            Console.WriteLine(customer.Name + " " + customer.Id + " " + customer.City);

            Customer[] customers = new Customer[] {customer1,customer };
            int sayac = customers.Length;
            foreach (var item in customers)
            {
                Console.WriteLine("{sayac} "+ " " +item.Id+" "+item.Name+" "+item.City);
                Console.WriteLine(" ------------------------------------");
                Console.WriteLine(sayac);
            }
        }
       
    }
    class Customer
    {
        public Customer(string Name,int Id,string City)
        {
            this.Name = Name;
            this.Id = Id;
            this.City = City;   
            
        }
        public Customer()
        {
            
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string City { get; set; }
        public void Listeleme()
        {

        }
    }
}
