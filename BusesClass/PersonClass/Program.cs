using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", "Smith", 32, "32 Timothy Way", 0212345678);
            Console.WriteLine(person1.GetDetails());
        }
    }
}
