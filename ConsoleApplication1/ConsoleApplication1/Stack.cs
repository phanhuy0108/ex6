using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Stack
    {
        private string [] Buffer;
        private int Top;
        public Stack()
        {
            Buffer = new string [1000];
            Top = -1;
        }

        
        public void Push (string v)
        {
            Buffer[Top + 1]=v;
            Top++;
        }
        public string Pop()
        {
            string n = Buffer[Top];
            Top--;
            return n;
        }
        public string Peek()
        {
          return Buffer[Top];
        }
        public int Count()
        {
          return Top + 1;
        }
        public void Clear()
        {
            Top = -1;
        }
    }
}
