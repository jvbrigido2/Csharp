// Todolist assignment

var todoList = new List<string>();
bool isExitPressed = false;

Console.WriteLine("Hello!");


do
{
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
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        case "E":
        case "e":
            isExitPressed = true;
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
} while (!isExitPressed);


void SeeAllTodos()
{
    if (todoList.Count == 0)
    {
        NoTodosAddedMessage();
        return;
    }
    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todoList[i]}");
    }
}

void AddTodo()
{
    string userInput;
    do
    {
        Console.WriteLine("Enter a TODO description");
        userInput = Console.ReadLine();
    } while (!isDescriptionValid(userInput));

    todoList.Add(userInput);

    Console.WriteLine($"TODO successfully added: {userInput}");
}

void RemoveTodo()
{
    bool validInput = false;
    string description = "";
    if (todoList.Count == 0)
    {
        NoTodosAddedMessage();
    }
    else
    {

        do
        {
            Console.WriteLine("Select the index of the TODO you want to remove:");

            SeeAllTodos();

            var userInput = Console.ReadLine();
            bool isParsingSuccessful = int.TryParse(userInput, out int index);

            if (userInput == "")
            {
                Console.WriteLine("Selected index cannot be empty");
            }
            else if (isParsingSuccessful == false || (index < 0 || index > todoList.Count || index == 0))
            {
                Console.WriteLine("The given index is not valid.");
            }
            else
            {
                validInput = true;
                description = todoList[index - 1];
                todoList.RemoveAt(index - 1);
            }
        } while (!validInput);

        Console.WriteLine($"TODO removed: {description}");
    }
}

void NoTodosAddedMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}

bool isDescriptionValid(string description)
{
    if (todoList.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }
    if (description == "")
    {
        Console.WriteLine("The description cannot be empty");
        return false;
    }
    return true;
}



