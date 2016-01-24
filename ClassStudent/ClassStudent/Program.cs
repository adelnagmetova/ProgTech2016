using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public string id;
        public Student (string _firstName, string _lastName, int _age, string _id)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            id = _id;
        }
        public override string ToString()
        {
            return firstName + " " + lastName  + " " + "age - " + age + " ," + "id -" + id;
        }
        static void Main(string[] args)
        {
            Student s = new Student("Adel", "Nagmetova", 19, "15BD02069");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
