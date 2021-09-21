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
            Console.WriteLine(Test1.IsAllergicTo(Allergen.Cats));
            Console.WriteLine(Test1.IsAllergicTo("Cats"));
            Allergies Test2 = new Allergies("Joe", 65);
            Console.WriteLine(Test2.ToString());
            Console.WriteLine(Test2.IsAllergicTo(Allergen.Cats));
            Console.WriteLine(Test2.IsAllergicTo("Chocolate"));
            Allergies Test3 = new Allergies("Rob", "Peanuts Chocolate Cats Strawberries");
            Console.WriteLine(Test3.ToString());
            Console.WriteLine(Test3.IsAllergicTo(Allergen.Cats));
            Console.WriteLine(Test3.IsAllergicTo("Eggs"));
            Console.ReadLine();
        }
    }
}
