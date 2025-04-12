using System;
using Git_test;
namespace Git_test
{
    public class Calculations
    {
        public double Shape()
        {
            Console.WriteLine
            (
                "Enter a side to calculate:\n" +
                "        C\n" +
                "       /|\n" +
                "      / |\n" +
                "   A /  |\n" +
                "    /   |\n" +
                "   /    |\n" +
                "  /     |\n" +
                " /______|\n" +
                "     B"
            );
            string Choise = Console.ReadLine().ToLower();
            switch(Choise)
            {
                case "A":
                    Info.b = CheckInput("Enter B: ");
                    Info.c = CheckInput("Enter C: ");
                    return Math.Sqrt(Math.Pow(Info.b, 2) + Math.Pow(Info.c, 2));
                
                case "B":
                    Info.a = CheckInput("Enter A: ");
                    Info.c = CheckInput("Enter C: ");
                    return Math.Sqrt(Math.Pow(Info.a, 2) - Math.Pow(Info.c, 2));
                
                case "C":
                    Info.b = CheckInput("Enter A: ");
                    Info.c = CheckInput("Enter B: ");
                    return Math.Sqrt(Math.Pow(Info.a, 2) - Math.Pow(Info.b, 2));
                
                default:
                    Console.WriteLine("Enter a valid Input");
                    return 0d;
            }
            
        }
        private double CheckInput(string prompt)
        {
            double value;
            Console.WriteLine(prompt);
            while (true)
            {
                string Input = Console.ReadLine();
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
