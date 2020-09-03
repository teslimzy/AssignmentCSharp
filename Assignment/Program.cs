using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        private Person person1;
        private Person person2;
        private Address person1Address;
        private Address person2Address;

        private Dog dog1;
        private Dog dog2;

        private Cat cat1;
        private Cat cat2;


        static void Main(string[] args)
        {

            var p = new Program();
            p.runing();


        }
        public void runing()
        {

        


            person1 = new Person("Ian", "White");
            person1Address = new Address("Flat 5 ", " 17 Bluebell Gardens ", "Broughton", "Milton Keynes", "107");
            person1.setAddress(person1Address);

            person2 = new Person("Tez", "Arrow");
            person2Address = new Address("Flat 20", "37 Milton Road", "Broughton", "Milton Keynes", "100078");
            person2.setAddress(person2Address);

            dog1 = new Dog("Lucy", "Mr John");
            dog2 = new Dog("cage", "Mr Henry");

            cat1 = new Cat("jack", 5);
            cat2 = new Cat("luck", 3);

            
            person1.print();
            person2.print();

            dog1.print();
            dog2.print();

            cat1.print();
            cat2.print();
        }
    }
}
