using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please Enter a value for A");
           int a = Convert.ToInt32(ReadLine());
            WriteLine("Please Enter a value for B");
           int b = Convert.ToInt32(ReadLine());
           int sum = a + b;
            WriteLine("The result is: "+ sum);
            ReadKey();

        }
    }
}
