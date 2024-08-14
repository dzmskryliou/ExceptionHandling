using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Program
    {
        private static readonly INumberParser _parser = new NumberParser();

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to convert to an integer:");
            string input = Console.ReadLine();

            try
            {
                int result = _parser.Parse(input);
                Console.WriteLine("Converted integer: " + result);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
