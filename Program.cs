using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int score;
             Console.WriteLine("Enter your score: ");
             string scoreAsText = Console.ReadLine();
             score = Convert.ToInt32(scoreAsText);

             if (score == 100)
             {
                 Console.WriteLine("Perfect score!  You win!");
             }
             else if (score == 99)
             {
                 Console.WriteLine("Missed it by THAT much.");
             }
             else if (score == 0)
             {
                 Console.WriteLine("You must have been TRYING to get that bad of a score.");
             }
             else
             {
                 Console.WriteLine("Ah, come on!  That's just boring.");
                 Console.WriteLine("Seriously.  Next time pick a more interesting score.");
             }
             Console.ReadKey();*/


            int score;

            Console.WriteLine("Enter your score: ");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            if (score == 100)
               Console.WriteLine("Perfect score!  You win!");

            else if (score >= 90)
                Console.WriteLine("You got an A");

            else if (score >= 80)
                Console.WriteLine("You got a B");

            else if (score >= 70)
                Console.WriteLine("You got a C");

            else if (score >= 60)
                Console.WriteLine("You got a D");

            else
                Console.WriteLine("You got an F");

            Console.ReadKey();


        }
    }
}
