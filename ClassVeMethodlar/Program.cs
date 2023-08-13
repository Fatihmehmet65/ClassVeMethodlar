using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassVeMethodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Person person1 = new Person();
            Person person2 = new Person();
            Erkekler erkekler = new Erkekler();
            person1.Name = "Fatih";
            erkekler.Name = person1.Name;
            erkekler.number = 2;
            person1.number=erkekler.number-1;
            //person1 = new Person();
            Console.WriteLine(erkekler.Name);
            Yakısıklılar yakısıklılar = new Yakısıklılar();
            yakısıklılar.number = erkekler.number+1;
            yakısıklılar.Add(person1);
            yakısıklılar.Add(erkekler);
            yakısıklılar.Add(yakısıklılar);
            erkekler.KrediKart = 124;
            person1 = yakısıklılar;
            person1 = erkekler;
            Console.WriteLine(person1.number);
            Console.WriteLine(((Erkekler)person1).KrediKart);
        }
        
    }
    public class Person
    { public string Name { get; set;}
      public int number { get; set; }
    }
    class Erkekler:Person
    {
        public int KrediKart { get; set; }

    }
    class Yakısıklılar:Person
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.number);
        }
    }
    
    
}
