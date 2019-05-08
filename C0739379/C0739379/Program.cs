using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0739379
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1098;
            Method m = new Method();
            int sum = m.Result(n);

            Console.WriteLine("Sum is " + sum);

            Console.ReadKey();
        }
    }

    class Method
    {
        public int Result(int n)
        {
            int sum = 0;
            while (n >= 514)
            {
                Console.WriteLine(n);
                sum = sum + n;
                n -= 33;
            }



            return sum;
        }
    }
}
