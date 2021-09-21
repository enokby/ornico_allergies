using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allergies
{
    class Program
    {
        static void Main(string[] args)
        {
            Allergies Test1 = new Allergies("Mary");
            Console.WriteLine(Test1.ToString());
            Allergies Test2 = new Allergies("Joe", 65);
            Console.WriteLine(Test2.ToString());
            Allergies Test3 = new Allergies("Rob", "Peanuts Chocolate Cats Strawberries");
            Console.WriteLine(Test3.ToString());
            Console.ReadLine();
        }
    }
}
