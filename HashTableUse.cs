using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collection230724
{
    internal class HashTableUse
    {
        public void method1()
        {
            /*
            Hashtable ht1=new Hashtable();
            ht1.Add("maharashtra", "mumbai");
            ht1.Add("goa", "panjim");
            ht1.Add("karnataka", "Bengaluru");

            Console.WriteLine("count of Ht1 : "+ht1.Count);
            // Console.WriteLine(ht1["goa"]);

            foreach (var item in ht1.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            foreach (var item in ht1.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");
            foreach (var item in ht1.Keys)
            {
                Console.WriteLine(ht1[item]);
            }
            Console.WriteLine("***********************");

            foreach (var item in ht1)
            {
                DictionaryEntry de = (DictionaryEntry)item;
                Console.WriteLine("key = "+de.Key+" value = "+de.Value);
            }
            */

            ArrayList cities= new ArrayList();  
            Hashtable HtIndia= new Hashtable();

            cities.Add("pune");
            cities.Add("nashik");
            cities.Add("mumbai");
            HtIndia.Add("mh", cities);

            cities=new ArrayList();
            cities.Add("panji");
            cities.Add("mhapusa");
            cities.Add("Madgao");
            HtIndia.Add("goa", cities);

            //cities.Clear();
            cities = new ArrayList();
            cities.Add("benguluru");
            cities.Add("vijapur");
            cities.Add("Menglore");
            HtIndia.Add("ka", cities);

            foreach (var item in HtIndia.Keys)
            {
                Console.WriteLine("\nState :"+item);
                var c = HtIndia[item];
                foreach (var myCity in (ArrayList)c)
                {
                    Console.Write("\t"+myCity);
                }

            }

            // how to search city in values section
            string searchCity;
            Console.WriteLine("Enter city name to search and display state name");
            searchCity = Console.ReadLine();
            bool Flag = false;
            foreach (var item in HtIndia.Keys)
            {
                
                var c = HtIndia[item];
                foreach (var myCity in (ArrayList)c)
                {
                    if (string.Compare((string)myCity,searchCity)==0)
                    {
                        Console.Write("\t state :"+item+" city : "+ myCity);
                        Flag = true;
                        break;
                    }
                    
                }
            }
            if (Flag==false)
            {
                Console.WriteLine("City not found!!!!");
            }

            Console.ReadKey();
        }
    }
}
