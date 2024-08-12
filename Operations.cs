namespace PersonManagementSystem;

public static class Operations
{
    public static void ConsoleStart()
    {
        Console.WriteLine("1. Add Person\n2. View Person\n3. Print All\n4. Delete Person\n5. Delete All\n6. Edit Person\n7. Exit");
    }

    public static void AddPerson()
    {
        var (name, age, city, phone) = GetPersonData();
        try
        {
            var person = new Person(name, age, city, phone);
            Console.WriteLine($"Person added with ID: {person.Id}");
            Console.ReadKey();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void ViewPerson()
    {
        Console.Clear();
        Console.WriteLine("Enter the person Name or ID: ");
        string idOrName = Console.ReadLine();
        if (int.TryParse(idOrName, out int id))
        {
            if (StaticInfo.GetPersonById(id) is Person person)
            {
                Console.WriteLine(person);
            }
            else
            {
                Console.WriteLine("No person found with the given ID.");
            }
        }
        else
        {
            if (StaticInfo.GetPersonByName(idOrName) is Person person)
            {
                Console.WriteLine(person);
            }
            else
            {
                Console.WriteLine("No person found with the given name.");
            }
        }
        Console.ReadKey();
    }

    public static void PrintAll()
    {
        Console.Clear();
        foreach (var person in StaticInfo.GetAllPersons())
        {
            Console.WriteLine(person);
        }
    }

    public static void DeletePerson()
    {
        Console.Clear();
        Console.WriteLine("Enter the person Name or ID: ");
        string idOrName = Console.ReadLine();
        if (int.TryParse(idOrName, out int id))
        {
            if (StaticInfo.RemovePersonById(id))
            {
                Console.WriteLine("Person deleted successfully.");
            }
            else
            {
                Console.WriteLine("No person found with the given ID.");
            }
        }
        else
        {
            if (StaticInfo.RemovePersonByName(idOrName))
            {
                Console.WriteLine("Person deleted successfully.");
            }
            else
            {
                Console.WriteLine("No person found with the given name.");
            }
        }
        Console.ReadKey();
    }

    public static void DeleteAll()
    {
        StaticInfo.ClearAll();
        Console.WriteLine("All persons deleted successfully.");
    }

    public static void EditPerson()
    {
        Console.Clear();
        Console.WriteLine("Enter the person Name or ID: ");
        string idOrName = Console.ReadLine();
        var (name, age, city, phone) = GetPersonData();

        if (int.TryParse(idOrName, out int id))
        {
            if (StaticInfo.GetPersonById(id) is Person person)
            {
                try
                {
                    person.UpdateDetails(name, age, city, phone);
                    Console.WriteLine("Person details updated successfully.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("No person found with the given ID.");
            }
        }
        else
        {
            if (StaticInfo.GetPersonByName(idOrName) is Person person)
            {
                try
                {
                    person.UpdateDetails(name, age, city, phone);
                    Console.WriteLine("Person details updated successfully.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("No person found with the given name.");
            }
        }
    }

    private static (string name, int age, string city, string phone) GetPersonData()
    {
        Console.Clear();
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter City: ");
        string city = Console.ReadLine();
        Console.Write("Enter Phone: ");
        string phone = Console.ReadLine();
        return (name, age, city, phone);
    }
}
