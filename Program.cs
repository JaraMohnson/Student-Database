bool keepGoing = true;
bool presentingInfo = true;
int student = 0;

string[] names = {"Justin Jones", "Connor Wood", "Kris Pranger", "Joshua Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali AlHashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt",
    "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi"};
string[] foods = { "Baja Blast", "chicken sandwich", "sushi", "Nalesniki", "sushi", "General Tso's", "jerk chicken", "steak", "sushi", "rice and dodo", "bread",
    "steak", "BBQ", "Thai", "tacos", "pasta", "pounded yam" };
string[] hometowns = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI",
    "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };

Console.WriteLine("Welcome to the database!");

while (keepGoing)
{
    Console.WriteLine("Which of our 17 students would you like to learn about? Enter a number or reply ALL to see all students' info.");

    string userChoice = Console.ReadLine();

    if (userChoice.ToLower().Contains("all"))
    {
        Console.WriteLine("Presenting our full class:");
        AllStudents();
    }
    else
    {
        student = int.Parse(userChoice) - 1;

        while (presentingInfo)
        {
            if (student >= names.Length || student < 0 )
            {
                Console.WriteLine("Invalid student number, please choose between 1-17");
                break;
            }
            Console.WriteLine($"Student #{student + 1} is {names[student]}. Would you like to know their hometown, favorite food, or both?"); // separate this to re-ask?

            string choice = Console.ReadLine().ToLower().Trim();

            if (choice.Contains("home"))
            {
                Console.WriteLine($"{names[student]} is from {hometowns[student]}.");
                break;
            }
            else if (choice.Contains("food"))
            {
                Console.WriteLine($"{names[student]}'s favorite food is {foods[student]}.");
                break;
            }
            else if (choice == "both")
            {
                Console.WriteLine($"{names[student]} is from {hometowns[student]} and their favorite food is {foods[student]}.");
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid category; please choose from 'hometown' or 'favorite food'");
                continue;
            }
        }
    }
    while (true)
    {
        Console.WriteLine("Would you like to select another student? Reply 'y' continue, or press any key to exit.");
        if (Console.ReadLine().ToLower().Trim() == "y")
        {
            break;
        }
        else
        {
            Console.WriteLine("Thanks for visiting!");
            keepGoing = false;
            break;
        }
    }
}

static void AllStudents()
{
    string[] names = {"Justin Jones", "Connor Wood", "Kris Pranger", "Joshua Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali AlHashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt",
    "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi"};
    string[] foods = { "Baja Blast", "chicken sandwich", "sushi", "Nalesniki", "sushi", "General Tso's", "jerk chicken", "steak", "sushi", "rice and dodo", "bread",
    "steak", "BBQ", "Thai", "tacos", "pasta", "pounded yam" };
    string[] hometowns = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI",
    "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };

    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine($"{names[i]} is from {hometowns[i]} and their favorite food is {foods[i]}.");
    }
    Console.WriteLine("");
}