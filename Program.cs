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
        case 3:
            Operations.ViewPerson();
            break;
        case 4:
            Operations.PrintAll();
            break;
        case 5:
            Operations.DeletePerson();
            break;
        case 6:
            
            break;
        case 7:
            
            break;
    }
} while (ans!=8);