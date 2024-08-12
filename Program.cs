using PersonManagementSystem;

int ans;
do
{
    Console.Clear();
    Operations.ConsoleStart();
    ans = int.Parse(Console.ReadLine());
    switch (ans)
    {
        case 1:
            Operations.AddPerson();
            break;
        case 2:
            Operations.ViewPerson();
            break;
        case 3:
            Operations.PrintAll();
            break;
        case 4:
            Operations.DeletePerson();
            break;
        case 5:
            Operations.DeleteAll();
            break;
        case 6:
            Operations.EditPerson();
            break;
    }
} while (ans != 7);