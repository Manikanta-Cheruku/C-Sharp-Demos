using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int x = 1;
            int y = 5;
            int z = 10;
            int noofnotes = 0;
            while (sum < 480)
            {
                sum = x + y + z;
                noofnotes++;
                x = x + 1;
                y = y + 5;
                z = z + 10;
            }
            Console.WriteLine($"No of notes {noofnotes} and total nontes {3 * noofnotes}");
        }
    }
}
