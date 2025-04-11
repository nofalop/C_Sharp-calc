using System;
using Git_test;
namespace Git_test
{
    public class Calculations
    {
        public double Shape(Info git_Test)
        {
            Console.WriteLine("Enter Prameter A");
            string Number = Console.ReadLine();
            Info.A = double.TryParse(Number, out double Parsed_A) ? Parsed_A : 0;
            if (!CheckInput(ref Number))
            {
                return 0d;
            }
            if (Info.A == 0)
            {
                Console.WriteLine("Enetr B: ");
                
                Info.B = double.TryParse(Console.ReadLine(), out double Parsed_B) ? Parsed_B : 0;
                
                Console.WriteLine("Enter C: ");
                
                Info.C = double.TryParse(Console.ReadLine() , out double Parsed_C) ? Parsed_C : 0;
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