using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Vao Size Mang");
            int size = int.Parse(Console.ReadLine());
            Stack s = new Stack(size);
            s.Push(5);
            s.Push(3);
            s.Push(6);
            s.Push(5);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Count());
            s.Clear();

        }
    }
}
