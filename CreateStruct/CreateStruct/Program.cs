using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStruct
{
    class Person
    {
        public enum Genders: int {Male, Female};
        public string firstName;
        public string lastName;
        public int age;
        public Genders gender;
        public Person (string _firstName, string _lastName, int _age, Genders _gender)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            gender = _gender;

        }
        public override string ToString()
        {
            return firstName + " " + lastName + "( " + gender + ")" +", age" + age;
        }
        static void Main(string[] args)
        {
            Person p = new Person("Adel", "Nagmetova", 19, Person.Genders.Female);
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
