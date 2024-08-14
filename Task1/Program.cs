using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Console.WriteLine("Enter lines of text ('exit' to quit):");

            while (true)
            {
                Console.Write("Enter a line: ");
                string input = Console.ReadLine();

                if (input == null)
                {
                    continue;
                }

                try
                {
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new ArgumentException("Input cannot be empty or whitespace.");
                    }
                    Console.WriteLine("First character: " + input[0]);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Next input");
                }
            }
        }
    }
}