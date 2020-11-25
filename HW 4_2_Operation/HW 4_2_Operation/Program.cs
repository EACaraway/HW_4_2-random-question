using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_2_Operation
{
    class Program
    { // Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
        static void Main(string[] args)
        {   // randomly generate 2 int between 1-15 called "a" and "b" and 1 int called "operation" between 1-4.
            var rand = new Random();
            var a = rand.Next(1, 16);
            var b = rand.Next(1, 16);
            var operation = rand.Next(1, 5);

            // variable to hold corrct answer.
            int answer;

            // Give the user different expressions based on the random value of "operation" 
            if (operation == 1)
            {
                Console.Write($"Enter the result of {a} + {b}: ");
                // store correct answer to "answer"
                answer = a + b;
            }

            else if (operation == 2)
            {
                Console.Write($"Enter the result of {a} * {b}: ");
                answer = a * b;
            }

            else if (operation == 3)
            {
                Console.Write($"Enter the result of {a} - {b}: ");
                answer = a - b;
            }

            else
            {
                Console.Write($"Enter the result of {a} / {b}: ");
                answer = a / b;
            }

            // convert user input to int and store in variable "userInput" 
            int.TryParse(Console.ReadLine(), out int userInput); 

            // compare value in "userInput to value in "answer"
            if (userInput == answer)
            {
                Console.WriteLine("Congratulations!!! That is correct.");
            }

            else
            {
                Console.WriteLine("Sorry, That is not correct.");
            }
        }
    }
}
