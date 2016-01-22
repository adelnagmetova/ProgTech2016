using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStruct
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person (string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;

        }
        public override string ToString()
        {
            return firstName + " " + lastName + ", age" + age;
        }
        static void Main(string[] args)
        {
            Person p = new Person("Adel", "Nagmetova", 19);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
