using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private Address address;

        public Person(string myfirstname, string mylastname)
        {
            firstname = myfirstname;
            lastname = mylastname;
        }
        public void setAddress(Address myAddress)
        {
            address = myAddress;
        }

        public void print()
        {
            Console.WriteLine("Lastname: " + lastname);
            Console.WriteLine("Firstname: " + firstname);
            address.print();
        }
    }

    public class Address
    {
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;

                  
        
        public Address(string mystreet1, string mystreet2, string mycity, string mystate, string myzip)
        {
            street1 = mystreet1;
            street2 = mystreet2;
            city = mycity;
            state = mystate;
            zip = myzip;
        }


        public void print()
        {
            System.Console.WriteLine("Street1 : " + street1);
            System.Console.WriteLine("Street2 : " + street2);
            System.Console.WriteLine("City : " + city);
            System.Console.WriteLine("State :" + state);
            System.Console.WriteLine("Zip : " + zip);
        }
    }
}