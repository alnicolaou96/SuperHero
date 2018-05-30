using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroOOP
{
    class SuperHero
    {
        //declare fields
       private string name, superPower;
       private int strength, speed;


        //declare properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string SuperPower
        {
            get { return this.superPower; }
            set { this.superPower = value; }
        }
        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        //constructors
        public SuperHero()
        {
            //default constructor
        }

        public SuperHero(int strength, int speed)
        {
            //loaded constructor
            this.strength = strength;
            this.speed = speed;
        }

        public SuperHero(string name, string superPower)
        {
            //loaded constructor
            this.name = name;
            this.superPower=superPower;
        }

        public void HowFast()
        {
        }
        public void SetName(string name)
        {
            //this.name = name;
            Console.WriteLine("The Name of the super hero is " + name);
        }


    }
}
