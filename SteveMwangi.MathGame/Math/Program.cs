using Math;

var date = DateTime.UtcNow;
string? name = GetName();
var querries = QuestionsToAnswer();
var selection = new SelectionMenu();
var levelSelected = QuestionsLevel();
var playRandomGame = RandomGame();

selection.Selection(name, date, querries, levelSelected, playRandomGame);
string? GetName()
{
    Console.WriteLine("Hello! please enter your name to play the game");
    Console.WriteLine("............................................");
    var name = Console.ReadLine();
    while (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Inalid input, please enter your name");
        name = Console.ReadLine();
    }
    return name;
}
int QuestionsToAnswer()
{
    Console.Write("How many questions do you want to answer? ");
    string? questions = Console.ReadLine();

    while (string.IsNullOrEmpty(questions) || !int.TryParse(questions, out _))
    {
        Console.WriteLine("Invalid entry, please enter a numerical entry");
        questions = Console.ReadLine();
    }
    return int.Parse(questions);
}
string QuestionsLevel()
{
    var selectedLevel = "";
    bool level = true;
    do {
    Console.Write("Choose level of difficuly Easy, Medium or Hard: ");
    string? difficultyLevel = Console.ReadLine().Trim().ToLower();
     switch(difficultyLevel)
        {
            case "easy":
                selectedLevel = difficultyLevel;
                level = false;
                break;
            case "medium":
                selectedLevel= difficultyLevel;
                level = false;
                break;
            case "hard":
                selectedLevel= difficultyLevel;
                level = false;
                break;
            default:
                Console.WriteLine("Please enter a valid input");             
                break;
        }   
    
    } while (level);

    return selectedLevel;   
}
string RandomGame()
{
    string randomGame = "";
    bool random = true;
    do
    {
        Console.WriteLine("Do you want to play a random game? Yes/No");
        string? playRandomGame = Console.ReadLine().Trim().ToLower();
        switch (playRandomGame)
        {
            case "yes":
                randomGame = playRandomGame;
                random = false;
                break;
            case "no":
                randomGame = playRandomGame;
                random = false;
                break;
            default:
                Console.WriteLine("Please enter a valid input");
                break;
        }

    } while (random);

    return randomGame;
}

Console.ReadLine();





