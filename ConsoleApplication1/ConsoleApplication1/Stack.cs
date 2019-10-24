using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyStack
    {
        private string[] Buffer;
        private int Top;
        public MyStack(int size)
        {
            Buffer = new string[size];
            Top = -1;
        }
        /// <summary>
        /// In
        /// </summary>
        public MyStack()
        {
            Buffer = new string[1000];
            Top = -1;

        }
        public void Push(string value)
        {
            Buffer[Top + 1] = value;
            Top++;
        }
        public string Pop()
        {
           
            string value= Buffer[Top];
            Top = Top - 1;
            return value;

        }
        public string Peek()
        {
           
            return Buffer[Top]; 
        }
        public int Count()
        {
            return Top + 1;
        }
        public int clear()
        {
            return Top - 1;
        }

            




        
   
}
}
