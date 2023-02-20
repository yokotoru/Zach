using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary2.Class1 class1 = new ClassLibrary2.Class1();
            Console.WriteLine(class1.CheckVIN("2C4GJ453XYR693697"));
            Console.WriteLine(class1.GetVINCountry("X9FMXXEEBMBM38625"));
            Console.ReadKey();
        }
    }
}
