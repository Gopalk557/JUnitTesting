using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to the JUnitTesting");
            BinaryConversion binary = new BinaryConversion();
            binary.Conversion();
            Console.ReadKey();
        }
    }
}
