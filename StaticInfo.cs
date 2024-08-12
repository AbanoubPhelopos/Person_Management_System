using System.Collections;

namespace PersonManagementSystem;

public static class StaticInfo
{
    public static HashSet<string> Names = new();
    public static HashSet<int> Ids = new();
    public static Dictionary<int, Person> findById = new();
    public static Dictionary<string, Person> findByName = new();

}