using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection230724
{
    internal class StackDemo
    {
        public void showStack()
        {
            Stack st = new Stack();
            st.Push(111);
            st.Push(222);
            st.Push(333);
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Peek());
            //Console.WriteLine("------use pop----------");
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            Console.WriteLine(st.Contains(2222));
        }
    }
}
