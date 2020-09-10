using System;
using ClassProject.abstractions;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new While();

            w.OutputToConsole(3);

            Console.ReadLine();
        }
    }
}
