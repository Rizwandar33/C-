using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Parent
    {
        public virtual void display()
        {
            Console.WriteLine("you are in base class");
        }
    }
    public class Child : Parent
    {
        public override void display()
        {
            Console.WriteLine("you are in child class");
        }

        public static void Main(string[] args)
        {
            Parent parent = new Child();
            parent.display();
        }
    }

}




