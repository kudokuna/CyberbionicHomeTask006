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
                        
                        break;
                    case "3":
                       
                        break;
                    case "4":

                        break;
                    case "5":

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
        // Task3 logic
        }
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
