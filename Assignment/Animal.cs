using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Dog
    {
        private string name;
        private string owner;

        public Dog(string dogName, string dogOwner)
        {
            name = dogName;
            owner = dogOwner;
        }

        public void print()
        {
            Console.WriteLine("Dogname: " + name);
            Console.WriteLine("Dogowner: " + owner);
        }

        public void printname()
        {
            Console.WriteLine("Dogname: " + name);
            
        }


    }
     
    class Cat
    {
        private string name;
        private int age;

        public Cat(string catName, int catAge)
        {
            name = catName;
            age = catAge;
        }

        public void print()
        {
            Console.WriteLine("Catname: " + name);
            Console.WriteLine("Catage: " + age);
        }

        public void printname()
        {
            Console.WriteLine("Catname: " + name);

        }
    }
}
