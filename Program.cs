using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Git_test;

namespace Nofal_Git
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            while (true)
            {
                double result = Calculations.Shape();
                if (result > 0)
                {
                    Console.WriteLine($"result: {(double)result}");
                    break;
                }
                else
                {
                    
                    Console.Clear();
                    Console.WriteLine("Negative Number result. Try again");
                }
            }
        }
    }
}