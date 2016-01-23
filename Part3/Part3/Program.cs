using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Person
    {
        public enum Genders : int { Male, Female };
        public string firstName;
        public string lastName;
        public int age;
        public Genders gender;
        public string phoneNumber;
        public string officeLocation;
        public Person(string _firstName, string _lastName, int _age, Genders _gender)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            gender = _gender;


        }
        class Manager : Person
        {
           
            public Manager(string _firstName, string _lastName, int _age, Genders _gender, string _phoneNumber, string _officeLocation) : base(_firstName, _lastName, _age, _gender)
            {
                phoneNumber = _phoneNumber;
                officeLocation = _officeLocation;
            }
            public override string ToString()
            {
                return firstName + " " + lastName + "( " + gender + ")" + ", age" + age + ", " + phoneNumber + ", " + officeLocation;
            }


        }
        static void Main(string[] args)
        {
            Manager m = new Manager("Adel", "Nagmetova", 19, Person.Manager.Genders.Female, "87057961686", "ToleBi");
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
