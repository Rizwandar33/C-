using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Properties
    {
        private int _id;
        private string _name ;
        private int  _rollNo;
        private string _email ;
        private string _phone ;

        public void SetValues(int id, string name, int rollNO, string email, string phone)
        {
            _id = id;
            _name = name;
            _rollNo=rollNO;
            _email = email;
            _phone = phone;
             
        }

       public (int, string, int, string, string)GetValues()
        {
            return (_id, _name ,_rollNo, _email, _phone);
        }
    }
}
internal class TupleExample
{
    public static void Main (string[] args)
    {
        Properties properties= new ();
properties.SetValues(10, "Rizwan", 9, "rizwandar33@gmail.com", "9697956788");
int id;
int rollno;
string name;
string email;
string phone;
(id, name, rollno, email, phone) =properties.GetValues();
Console.WriteLine($"The id is {id} \n RollNO is {rollno}\n Name is {name}\n Email is {email}\n PhoneNumber is {phone} ");
    }
}