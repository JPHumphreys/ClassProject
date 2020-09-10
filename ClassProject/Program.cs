using System;
using ClassProject.abstractions;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            Console.WriteLine(cat.LegCount);

            Animal sg = cat;
            Console.WriteLine(sg.LegCount);

            sg = new Seagull();
            Console.WriteLine(sg.LegCount);

            var cat2 = new Cat(3);

            Console.ReadLine();
        }
    }
}
