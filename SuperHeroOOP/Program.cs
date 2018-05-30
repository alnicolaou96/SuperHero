using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,superpower;
            int strength, speed;

            Console.WriteLine("whats the name of your super hero");
            name = Console.ReadLine();
            Console.WriteLine("What is your super hero's strength level?");
            strength = int parse(Console.ReadLine());


            SuperHero batman = new SuperHero();
            batman.SetName(name);

        }
    }
}
