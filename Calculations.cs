using System;
namespace Git_test
{
    public class Calculations
    {
        public static double Shape()
        {
            
            Console.WriteLine(
                "Which side do you want to calculate? (a / b / c)\n" +
                "Right-angled triangle diagram:\n\n" +
                "        C\n" +
                "       /|\n" +
                "      / |\n" +
                "   A /  | ← Enter this if you want to find side A\n" +
                "    /   |\n" +
                "   /    |\n" +
                "  /     |\n" +
                " /______|\n" +
                "     B      ← Enter this if you want to find side B\n" +
                "\n        ↑\n" +
                "      Enter 'c' if you want to find the hypotenuse"
            );

            string Choise = Console.ReadLine().ToLower();
            switch(Choise)
            {
                case "a":
                    Info.b = CheckInput("Enter B: ");
                    Info.c = CheckInput("Enter C: ");
                    double resultA = Math.Sqrt(Math.Pow(Info.c, 2) - Math.Pow(Info.b, 2));
                    return resultA > 0 ? resultA : 0;

                case "b":
                    Info.a = CheckInput("Enter A: ");
                    Info.c = CheckInput("Enter C: ");
                    double resultB = Math.Sqrt(Math.Pow(Info.c, 2) - Math.Pow(Info.a, 2));
                    return resultB > 0 ? resultB : 0;

                case "c":
                    Info.a = CheckInput("Enter A: ");
                    Info.b = CheckInput("Enter B: ");
                    double resultC = Math.Sqrt(Math.Pow(Info.a, 2) + Math.Pow(Info.b, 2));
                    return resultC > 0 ? resultC : 0;

                default:
                    Console.WriteLine("Enter a valid Input");
                    return 0d;
            }        
        }
        private static double CheckInput(string prompt)
        {
            double value;
            Console.WriteLine(prompt);
            while (true)
            {
                string? Input = Console.ReadLine();
                if(double.TryParse(Input, out value) && value > 0)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
        }
    }
}
