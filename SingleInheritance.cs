using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Employee
    {
        internal int Id { get; set; }

        internal string Name { get; set; }

        internal string Address { get; set; }

        internal string PhoneNO { get; set; }

        internal string Email { get; set; }

        internal void Display()
        {
            Console.WriteLine($"The Name is {Name}\nAddress is {Address}\nPhone NO is {PhoneNO}\nEmail is {Email}");
        }
    }
    public class Teacher : Employee
    {
        internal string Department { get; set; }
        public void Print()
        {
            Console.WriteLine("You are in Teacher class");
        }

    }
    public class Doctor : Employee
    {
        public void Message()
        {
            Console.WriteLine("you are in Doctor section");
        }
    }
    internal class Test
    {
        public static void Main(string[] args)
        {
           Teacher hod = new Teacher() { Id = 111, Name = "Rizwan Ahmad", Address = "Barzulla", Email = "rizwandar33@gmail.com", PhoneNO = "9906666", Department = "Computer Science" };
           hod.Display();
           hod.Print();

        }
    }


