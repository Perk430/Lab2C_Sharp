using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input from user
            int num;
            bool inRange;

            Console.WriteLine("Enter an integer between 1 and 100");
            num = int.Parse(Console.ReadLine());
            // Determining whether input is ODD or Even
            if (num % 2 == 1)
            {
                Console.WriteLine(num + "ODD");

            }
            else if (num % 2 == 0) 
            inRange = (2 <= num) && (num <= 25);
            {
                Console.WriteLine("Even and less than 25");
            }
            
        }
    }
}
