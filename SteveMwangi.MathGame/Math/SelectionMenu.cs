namespace Math
{
    internal class SelectionMenu
    {
        internal void Selection(string? name, DateTime date, int questions, string level, string randomGame)
        {
            bool gameOn = true;

            if(randomGame == "no")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($@"Welcome to the Math's Game {name}, Its {date.DayOfWeek} a proper day for you to test your math skills. Please choose from the operators below:
                        A - Addition
                        S - Subtraction
                        M - Multiplication
                        D - Division
                        Q - Quit the Game
                        V - List Game History");
                    Console.WriteLine("............................................");

                    var gameSelected = Console.ReadLine();

                    switch (gameSelected.Trim().ToLower())
                    {
                        case "a":
                            Operators.
                                Addition("Addition selected", questions, level);
                            break;
                        case "m":
                            Operators.Multiplication("Multiplication selected", questions, level); ;
                            break;
                        case "s":
                            Operators.Subtraction("Subtraction selected", questions,level);
                            break;
                        case "d": 
                            Operators.Division("Division selected", questions,level);
                            break;
                        case "q":
                            Console.WriteLine("Thanks for your time");
                            gameOn = false;
                            Environment.Exit(1);
                            break;
                        case "v":
                            HelperMethods.ListHistory();
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            Environment.Exit(1);
                            break;
                    }

                } while (gameOn);
            }
            else
            {
                string randomOperator = HelperMethods.RandomNumber();
                switch(randomOperator)
                {
                    case "Multiplication":
                        Operators.Multiplication("Multiplication Selected",questions, level);
                        break;
                    case "Addition":
                        Operators.Addition("Addition Selected", questions, level);
                        break;
                    case "Subtraction":
                        Operators.Subtraction("Subtraction Selected", questions, level);
                        break;
                    case "Division":
                        Operators.Division("Division Selected", questions, level);
                        break;
                    default:
                        Environment.Exit(1);
                        break;

                }
            }
        }
    }
}
