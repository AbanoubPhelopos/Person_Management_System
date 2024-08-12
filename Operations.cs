namespace PersonManagementSystem;

public static class Operations
{
/*  
    5. Delete Person By ID
    6. Delete All
    7. Edit Person
*/
    public static void ConsoleStart()
    {
        Console.WriteLine("1. Add Person\n2. View Person By ID\n3. View Person By Name\n4. Print All\n5. Delete Person By ID\n6. Delete All\n7. Edit Person\n8. Exit");
    }
    
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
        Console.WriteLine("Enter the person  Name or Id ");
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

    public static void PrintAll()
    {
        foreach (var person in StaticInfo.Names)
            Console.WriteLine(StaticInfo.findByName[person]);
    }
    public static void DeletePerson()
    {
        Console.WriteLine("Enter the person  Name or Id ");
        string IdOrName = Console.ReadLine();
        int Id;
    
        if (int.TryParse(IdOrName, out Id))
        {
            if (StaticInfo.Ids.Contains(Id))
            {
                string name = StaticInfo.findById[Id].Name;
                StaticInfo.Ids.Remove(Id);
                StaticInfo.Names.Remove(name);
                StaticInfo.findByName.Remove(name);
                StaticInfo.NameWithId.Remove(name);
                StaticInfo.findById.Remove(Id);
                Console.WriteLine($"{name} : Deleted Successfully !! ");
            }
            else
                Console.WriteLine("Your Id does not refer to any person");
        }
        else
        {
            if (StaticInfo.Names.Contains(IdOrName))
            {
                Id = StaticInfo.NameWithId[IdOrName];
                StaticInfo.Ids.Remove(Id);
                StaticInfo.Names.Remove(IdOrName);
                StaticInfo.findByName.Remove(IdOrName);
                StaticInfo.NameWithId.Remove(IdOrName);
                StaticInfo.findById.Remove(Id);
                Console.WriteLine($"{IdOrName} : Deleted Successfully !! ");
            }
            else
                Console.WriteLine("Your Name does not refer to any person");
        }
        Console.ReadKey();
    }
}