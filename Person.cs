using System.Numerics;
using System.Reflection.Metadata;
namespace PersonManagementSystem;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }

    public Person(string _name, int _age,string _city ,string _phone)
    {
        while (!UniqueName(_name))
        {
            Console.WriteLine("The Name already Used !! Try again ");
            Console.Write("Enter your Name : ");
            _name = Console.ReadLine();
        }

        Name = _name;
        StaticInfo.Names.Add(_name);
        Age = _age;
        City = _city;
        Phone = _phone;
        int Id = GenerateIds.Id();
        Console.WriteLine($"Your Id is {Id}");
        StaticInfo.findById.Add(Id,this);
        StaticInfo.findByName.Add(Name,this);
        Console.ReadKey();
    }

    private bool UniqueName(string name)
        => !StaticInfo.Names.Contains(name);
    
    public override string ToString()
        => $"Name : {Name}, Age : {Age}, City : {City}, Phone : {Phone}";
}