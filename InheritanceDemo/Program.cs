using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Server("Alvin"));
            Console.WriteLine();
            Console.WriteLine(new Superisor("Jarrod"));
        }
    }
}
