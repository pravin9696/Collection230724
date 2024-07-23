using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collection230724
{
    class student
    {
        public int roll { get; set; }
        public string name { get; set; }
        public int totalMarks { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList demo
            //ArrayList arl1 = new ArrayList();
            //Console.WriteLine(arl1.Capacity);
            //Console.WriteLine("Count = "+arl1.Count);
            //arl1.Add(111);
            //Console.WriteLine(arl1.Capacity);
            //Console.WriteLine("Count = " + arl1.Count);
            //arl1.Add(222);
            //arl1.Add(333);
            //arl1.Add(444);
            //Console.WriteLine(arl1.Capacity);
            //Console.WriteLine("Count = " + arl1.Count);

            //Console.WriteLine(arl1[0]);

            ////ArrayList ArlB = new ArrayList();
            //ArlB.AddRange(arl1);

            //ArlB.Add(999);
            //Console.WriteLine(ArlB.Capacity);
            //Console.WriteLine("Count = " + ArlB.Count);
            //Console.WriteLine("---------------");
            //for (int i = 0; i <ArlB.Count; i++)
            //{
            //    Console.WriteLine(ArlB[i]+" ***");
            //}
            //ArlB.Clear();
            //Console.WriteLine(ArlB.Capacity);
            //Console.WriteLine("Count = " + ArlB.Count);
            #endregion

            //ArrayList al1=new ArrayList();
            //al1.Add(11.1);
            //al1.Add(22.2);
            //al1.Add(33.3);
            //al1.Add(44.4);
            //al1.Add(55.4);

            //Console.WriteLine(al1.Contains(444.4));

            ArrayList al1 = new ArrayList();
            al1.Add("111");
            al1.Add("333");//0
            al1.Add("555");//1
            al1.Add("222");//2
            al1.Add("444");//3
                           // al1.Insert(2,"999");//0
                           //al1.RemoveRange(2,2);
                           //al1.RemoveAt(0);//
                           // al1.Reverse();
            al1.Sort();
            foreach (object item in al1)
            {
               
                Console.WriteLine(int.Parse((string)item));
            }
           


            Console.WriteLine(al1.Contains("kolhapur"));
            Console.WriteLine("indexOf="+al1.IndexOf("kolhapur"));
            #region ArrayList With Student obj
           // ArrayList studArList = new ArrayList();
           // student s1 = new student() { name = "rajesh", roll = 1, totalMarks = 780 };
           // studArList.Add(s1);
           // student s3 = new student() { roll = 3, name = "darshan", totalMarks = 888 };
           ////short cut
           //studArList.Add(new student() { roll = 2,name = "pavan", totalMarks = 567 });
           // studArList.Add(s3);
           // Console.WriteLine("capacity= "+studArList.Capacity+" count= "+studArList.Count);

           // Console.WriteLine("--Student record----");
           // for (int i = 0; i < studArList.Count; i++)
           // {
           //     student temp =(student) studArList[i];//1
           //           Console.WriteLine(temp.roll+"\t"+temp.name+"\t"+temp.totalMarks);//2
           //    // Console.WriteLine(((student)studArList[i]).roll);//1+2                
           // }
           // student st2 = new student() { roll = 3, name = "darshan", totalMarks = 888 };
           // // Console.WriteLine("contains = "+studArList.Contains(st2));
           // Console.WriteLine("contains = " + studArList.Contains(s3));
           // Console.WriteLine("s1 hash code= "+s1.GetHashCode());
           // Console.WriteLine("s1 hash code= " + s3.GetHashCode());
           // for (int i = 0; i < studArList.Count; i++)
           // {
           //     Console.WriteLine("####hash code= " + studArList[i].GetHashCode());
           // }
            #endregion
            Console.ReadKey();
        }
    }
}
