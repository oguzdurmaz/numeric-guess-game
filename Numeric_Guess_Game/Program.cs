using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Guess_Game
{
   public class Program
    {
        static void Main(string[] args)
        {
            int number1,number=0;
            a:
            Random randomNumber = new Random();
            for (int i = 0; i < 1; i++)
            {
                number = randomNumber.Next();
                Console.WriteLine(number.ToString());
            }

            Console.Write("Please Enter a Number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 == number)
            {
                Console.WriteLine("You did it!");
                goto a;
            }

            else if (number1 < number)
            {
                Console.WriteLine("Your guess is lower.");
            }

            else
                Console.WriteLine("Your guess is higher.");
                Console.ReadLine();
        }
    }
}
