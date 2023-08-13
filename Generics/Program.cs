using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            list.Add("Fatih Mehmet");
            list.Add("Fatih1 Mehmet1");
            list.Add("Fatih2 Mehmet2");
            Console.WriteLine(list.Count);

            ////////////////////////////////////
            MyList<string> list1 = new MyList<string>();
            list1.Add("OKTAY");
            list1.Add("Fatih2 Mehmet2");
            list1.Add("Fatih3 Mehmet3");
            list1.Add("Fatih4 Mehmet4");
            Console.WriteLine(list1.Count);
        }
    }
    class MyList<T>
    {
        T[] array;
        T[] temparray;
        public MyList()//CONSTRUCTOR YENİ BİR ARRAY OLUŞTURMA..
        {
            
            array = new T[0];
        }
        public void Add(T item)
        {
            //Kaybolmaması için yedekle.
            temparray = array;
            array=new T[array.Length+1];

            for (int i = 0; i < temparray.Length; i++)
            {
                array[i] = temparray[i];         
            }
            array[temparray.Length] = item;
           // array[array.Length-1] = item;
            
        }
        
        //Count Kullanma Modeli
        public int Count
        {
            get { return array.Length; }
            
        }

    }
}
