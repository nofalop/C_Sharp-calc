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
            string Choise = Console.ReadLine();
            if (string.Equals(Choise, "a".ToLower()))
            {
                Console.WriteLine("Enetr B: ");
                
                Info.b = double.TryParse(Console.ReadLine(), out double Parsed_B) ? Parsed_B : 0;
                
                Console.WriteLine("Enter C: ");
                
                Info.c = double.TryParse(Console.ReadLine() , out double Parsed_C) ? Parsed_C : 0;
                double result = Math.Sqrt(Math.Pow(Info.b, 2) + Math.Pow(Info.c, 2));
                return  result;
            }
            else if (string.Equals(Choise, "b".ToLower()))
            {
                Console.WriteLine("Enetr A: ");
                
                Info.a = double.TryParse(Console.ReadLine(), out double Parsed_B) ? Parsed_B : 0;
                
                Console.WriteLine("Enter C: ");
                
                Info.c = double.TryParse(Console.ReadLine() , out double Parsed_C) ? Parsed_C : 0;
                double result = Math.Sqrt(Math.Pow(Info.a, 2) - Math.Pow(Info.c, 2));
                return  result;
            }
            else if (string.Equals(Choise, "c".ToLower()))
            {
                Console.WriteLine("Enetr A: ");
                
                Info.a = double.TryParse(Console.ReadLine(), out double Parsed_B) ? Parsed_B : 0;
                
                Console.WriteLine("Enter B: ");
                
                Info.b = double.TryParse(Console.ReadLine() , out double Parsed_C) ? Parsed_C : 0;
                double result = Math.Sqrt(Math.Pow(Info.a, 2) - Math.Pow(Info.b, 2));
                return  result;
            }
            else
            {
                Console.WriteLine("Enter a valid Input");
                return 0;
            }
            
        }
        public bool CheckInput(ref string input)
        {
            if(double.TryParse(input, out double _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}