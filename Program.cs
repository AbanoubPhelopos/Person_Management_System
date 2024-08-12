using PersonManagementSystem;

int ans;
do
{
    Console.Clear();
    StartPoint.ConsoleStart();
    ans = int.Parse(Console.ReadLine());
    switch (ans)
    {
        case 1:
            Operations.AddPerson();
            break;
        case 2:
            Console.Write("Enter the Id : ");
            Operations.ViewPerson();
            break;
        case 3:
            Console.Write("Enter the Name : ");
            Operations.ViewPerson();
            break;
        case 4:
            
            break;
        case 5:
            
            break;
        case 6:
            
            break;
        case 7:
            
            break;
    }
} while (ans!=8);