namespace PersonManagementSystem;

public class Person
{
    public string Name { get; set; }
    public int Age { get; private set; }
    public string City { get; private set; }
    public string Phone { get; private set; }
    public int Id { get; }

    public Person(string name, int age, string city, string phone)
    {
        if (!UniqueName(name))
        {
            throw new ArgumentException("Name already used. Please try a different name.");
        }

        Name = name;
        Age = age;
        City = city;
        Phone = phone;
        Id = GenerateIds.GenerateId();

        StaticInfo.AddPerson(this);
    }

    private bool UniqueName(string name) => !StaticInfo.Names.Contains(name);

    public void UpdateDetails(string name, int age, string city, string phone)
    {
        if (!UniqueName(name) && name != this.Name)
        {
            throw new ArgumentException("Name already used. Please try a different name.");
        }

        StaticInfo.UpdatePersonName(this, name);

        Name = name;
        Age = age;
        City = city;
        Phone = phone;
    }

    public override string ToString() => $"ID: {Id}, Name: {Name}, Age: {Age}, City: {City}, Phone: {Phone}";
}