namespace PersonManagementSystem;

public static class GenerateIds
{
    private static int MaxValue = 1;
    private static Random random = new Random();

    public static int Id()
    {
        int newId;
        do
        {
            newId = random.Next(MaxValue, MaxValue + 1000);
        } while (StaticInfo.Ids.Contains(newId));
        
        MaxValue = newId + 1;
        
        StaticInfo.Ids.Add(newId);

        return newId;
    }
}
