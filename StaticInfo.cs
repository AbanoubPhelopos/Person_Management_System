namespace PersonManagementSystem;

public static class StaticInfo
{
    public static HashSet<string> Names { get; private set; } = new();
    public static HashSet<int> Ids { get; private set; } = new();
    public static Dictionary<int, Person> findById { get; private set; } = new();
    public static Dictionary<string, Person> findByName { get; private set; } = new();

    public static void AddPerson(Person person)
    {
        Names.Add(person.Name);
        Ids.Add(person.Id);
        findById[person.Id] = person;
        findByName[person.Name] = person;
    }

    public static Person GetPersonById(int id) => findById.TryGetValue(id, out var person) ? person : null;
    public static Person GetPersonByName(string name) => findByName.TryGetValue(name, out var person) ? person : null;

    public static IEnumerable<Person> GetAllPersons() => findById.Values;

    public static bool RemovePersonById(int id)
    {
        if (findById.TryGetValue(id, out var person))
        {
            Names.Remove(person.Name);
            Ids.Remove(id);
            findByName.Remove(person.Name);
            findById.Remove(id);
            return true;
        }
        return false;
    }

    public static bool RemovePersonByName(string name)
    {
        if (findByName.TryGetValue(name, out var person))
        {
            Names.Remove(name);
            Ids.Remove(person.Id);
            findById.Remove(person.Id);
            findByName.Remove(name);
            return true;
        }
        return false;
    }

    public static void UpdatePersonName(Person person, string newName)
    {
        if (person.Name != newName)
        {
            Names.Remove(person.Name);
            findByName.Remove(person.Name);
            person.Name = newName;
            Names.Add(newName);
            findByName[newName] = person;
        }
    }

    public static void ClearAll()
    {
        Names.Clear();
        Ids.Clear();
        findById.Clear();
        findByName.Clear();
    }
}
