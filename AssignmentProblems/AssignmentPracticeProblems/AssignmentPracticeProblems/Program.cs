using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input for the array
            Console.WriteLine("Enter the elements of the array separated by spaces:");
            string[] inputArray = Console.ReadLine().Split(' ');
            // Step 1: Concatenate all elements of the array into a single string
            string concatenatedString = string.Concat(inputArray); // Complete this part
            Console.WriteLine($"Concatenated String: {concatenatedString}");
            //Step 2: Extract all numeric characters from the concatenated string
            List<int> extractedNumbers = new List<int>();
            foreach (char c in concatenatedString)
            {
                // Extract numeric characters and add them to the list
                // Complete this part
                if (char.IsDigit(c))
                {
                    extractedNumbers.Add(int.Parse(c.ToString()));
                }

            }
            // Display extracted numbers
            Console.WriteLine("Extracted Numbers: [" + string.Join(", ", extractedNumbers) + "]");
        }
    }
}
