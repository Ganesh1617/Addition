using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Program
    {
        public void Add()
        {
            int a,b,c,d;
            Console.Write("Enter First Numebr = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Numebr = ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Addition is = "+c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
            Console.ReadLine();
        }
    }
}
