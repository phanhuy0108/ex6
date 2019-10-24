﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Stack
    {
        private int[] Buffer;
        private int Top;
        public Stack(int size)
        {
            Buffer = new int[size];
            Top = -1;
        }
        public void Push (int v)
        {
            Buffer[Top + 1]=v;
            Top++;
        }
        public int Pop()
        {
            int n = Buffer[Top];
            Top--;
            return n;
        }
        public int Peek()
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
