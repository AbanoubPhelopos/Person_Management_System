namespace PersonManagementSystem;

public static class Operations
{
/*  
    4. Print All
    5. Delete Person By ID
    6. Delete All
    7. Edit Person
*/
    public static void AddPerson()
    {
        string name, phone, city;
        int age;
        Console.Clear();
        Console.Write("Enter your Name : ");
        name = Console.ReadLine();
        Console.Write("Enter your Age : ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Enter your city : ");
        city = Console.ReadLine();
        Console.Write("Enter your phone : ");
        phone = Console.ReadLine();
        Person person = new(name, age, city, phone);
    }
    
    public static void ViewPerson()
    {
        string IdOrName = Console.ReadLine();
        int Id;
    
        if (int.TryParse(IdOrName, out Id))
        {
            if (StaticInfo.Ids.Contains(Id))
                Console.WriteLine(StaticInfo.findById[Id]);
            else
                Console.WriteLine("Your Id does not refer to any person");
        }
        else
        {
            if (StaticInfo.Names.Contains(IdOrName))
                Console.WriteLine(StaticInfo.findByName[IdOrName]);
            else
                Console.WriteLine("Your Name does not refer to any person");
        }
    
        Console.ReadKey();
    }

}