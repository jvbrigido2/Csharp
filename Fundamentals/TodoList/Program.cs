// Todolist assignment

Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

switch (userChoice)
{
    case "S":
    case "s":
        Console.WriteLine("See a TODO");
        break;
    case "A":
    case "a":
        Console.WriteLine("Add a TODO");
        break;
    case "R":
    case "r":
        Console.WriteLine("Remove a TODO");
        break;
    case "E":
    case "e":
        Console.WriteLine("Exit");
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;
}


Console.WriteLine("Press any key to exit.");
Console.ReadKey();


