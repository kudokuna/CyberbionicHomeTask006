using System;

namespace HomeTask_006_MainPart
{
    class Program
    {
        static void Main(string[] args)
        {
            // user decision select method
            DefineUserInput();
        }
        // user decision select logic method
        public static void DefineUserInput()
        {
            bool isWantToExit = false;

            while (!isWantToExit)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hi, Please choose task (2-5) or type exit for exit...");
                string userChoise = Console.ReadLine();

                switch (userChoise)
                {
                    case "2":
                        ShowSumAndOddValues();
                        break;
                    case "3":
                        DrawFigures();
                        break;
                    case "4":
                        CalculatePossibleRoots();
                        break;
                    case "5":
                        DrawViaSpiderCycle();
                        break;
                    case "exit":
                        isWantToExit = true;
                        Console.WriteLine("Thank you for using my program. Have a nice day...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Wrong choise...Please hit enter to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        // Task2 logic
        public static void ShowSumAndOddValues(){
            Console.ForegroundColor = ConsoleColor.Green;
            bool isCorrectNumber = false;
            int userFirstValue = default(int);
            int userSecondValue = default(int);
            int summOfValues = default(int);

            while (!isCorrectNumber)
            {
                Console.WriteLine("Please enter first integer value...");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = int.TryParse(userInputString, out userFirstValue);
                if (isConvertCorrect)
                {
                    userFirstValue = int.Parse(userInputString);
                    isCorrectNumber = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

            isCorrectNumber = false;

            while (!isCorrectNumber)
            {
                Console.WriteLine("Please enter second integer value...");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = int.TryParse(userInputString, out userSecondValue);
                if (isConvertCorrect)
                {
                    userSecondValue = int.Parse(userInputString);
                    if (userSecondValue < userFirstValue) { Console.WriteLine($"Second value must be more than {userFirstValue} -- your selected value as first"); } else isCorrectNumber = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }
            
            for (int i = userFirstValue+1; i < userSecondValue; i++)
            {
                summOfValues += i;
            }

            Console.WriteLine($"Summ of values is {summOfValues}");
            Console.WriteLine($"odd values between {userFirstValue} and {userSecondValue} are ...");

            for (int i = userFirstValue + 1; i < userSecondValue; i++)
            {
                if (i % 2 != 0) 
                {
                    Console.Write(i + " ");
                }
            }
        
            Console.ReadKey();
        }
        // Task3 logic
        public static void DrawFigures()
        {

        }
        // Task4 logic
        public static void CalculatePossibleRoots()
        {

        }
        // Task5 logic
        public static void DrawViaSpiderCycle()
        {

        }
    }
}
