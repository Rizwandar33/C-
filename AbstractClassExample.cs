using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Employee
{
    public abstract string Name { get; set; }

    public abstract int Id { get; set; }

    public abstract string Email { get; set; }

    public abstract string Phone { get; set; }

    public abstract void display();
    
    public void Message()
    {
        Console.WriteLine("This method is not abstract method");
    }

}
public class Doctor : Employee
{
    public override string Name { get; set; }
    public override int Id { get; set; }

    public override string Email { get; set; }

    public override string Phone { get; set; }

    public override void display()
    {
        Console.WriteLine("This is abstract method ");
    }
    public void print(string name, int id, string email, string phone)
    {
        Console.WriteLine($"Name is {name},Id is {Id}, Email is {email}, Phone is {phone}");
    }
}
class Test
{
    public static void Main(string[] args)
    {
        Doctor doctor = new Doctor();
        doctor.Name = "Rizwan";
        doctor.Id = 100;
        doctor.Email = "rizwandar33";
        doctor.Phone = "979887879";
        doctor.display();
        doctor.print(doctor.Name, doctor.Id, doctor.Email, doctor.Phone);
        doctor.Message();
    }
}

