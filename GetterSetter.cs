using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class SetterGetter
    {
        private int _id;
        private string _name;
        private int _salary;
        private string _phone;
        private string _email;

        public void SetId (int id)
        {
            this._id = id;
        }

        public void SetName (string name) 
        {
            this._name = name;
        }

        public void SetSalary(int salary)
        {
            this._salary = salary;
        }

        public void SetPhone (string phone) 
        { 
            this._phone = phone;
        }

        public void SetEmail (string email)
        {
            this._email = email;
        }
        
        public int GetId()
        {
            return this._id;
        }

        public string GetName() 
        {
            return this._name;
        }

        public int GetSalary()
        {
            return this._salary;
        }

        public string GetPhone()
        {
            return this._phone;
        }

        public string GetEmail()
        {
            return this._email;
        }


    }
}
internal class GetterSetterTest
{
    public static void Main(string[] args)
    {

SetterGetter setgetValues = new SetterGetter();
setgetValues.SetId(5);
setgetValues.SetName("Rizwan");
setgetValues.SetSalary(80000);
setgetValues.SetPhone("9697956788");
setgetValues.SetEmail("rizwandar33@gmail.com");
int id = setgetValues.GetId();
string name = setgetValues.GetName();
int salary = setgetValues.GetSalary();
string phone = setgetValues.GetPhone();
string email = setgetValues.GetEmail();
Console.WriteLine($"Id is {id}\n Name is {name} \n Salary is {salary}\n Phone Number is {phone}\nEmail is {email}");
    }
}
