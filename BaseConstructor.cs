using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App
{
    public class BaseClass
    {
        protected int Id { get; set; }

        protected string Name { get; set; }
        
        protected string PhoneNo { get; set; }
        
        protected string Address { get; set; }
        
        protected string Email { get; set; }

        protected void Display()
        {
            Console.WriteLine($"Name is {Name}\n Phone Number is {PhoneNo}\n Address is {Address}\n Email is {Email}");
            Console.WriteLine("You are in Base Class");
        }
        public BaseClass(int id,string name,string phoneNo,string address,string email)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.Address = address;
            this.Email = email;
        }
    }
    public class DerivedClass : BaseClass 
    {
        public DerivedClass(int id, string name, string phoneNo, string address, string email): base( id,name,phoneNo, address,email)
        { 
            
            }
        public int RollNO { get; set; }
        public  void Print()
        {
            Console.WriteLine($"The RollNO is {RollNO} and you are in derived class");
        }
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass(101, "Rizwan", "9906123456", "abc", "akkask");
            derivedClass.RollNO = 20;
            derivedClass.Display();
            derivedClass.Print();
        }
       
    }


}
