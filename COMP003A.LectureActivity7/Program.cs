using System.Collections.Generic;
namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 85, 90, 78, 92, 88 };
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(score[i]);
            }

            List<string> names = new List<string>();
            names.Add("Sam");
            names.Add("Haylee");
            names.Add("Jiji");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.Write("Please enter a number between 1 and 3: ");
            string user = Console.ReadLine();

            int number;

            bool userInput = int.TryParse(user, out number);

            if (userInput && number > 1 && number is < 3)
            {
                Console.WriteLine("Valid Number.");
            } 
            else
            {
                Console.WriteLine("Invalid Number.");
            }

            try
            {
                number = int.Parse(user);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number Entered.");
            }
        } /* I feel input validation is prefered due to try catch does not always catch a users error 
           * when inputing an answer, with input validation we can have it loop to try again as a fail safe
           * vs for me at least the program was not working properly using the catch method, did not crash.
           */

         /* try catch can handle unexpected exceptions better, which will help the 
          * entire program from crashing completely.
         */

         /* During the debugging I was able to see the differences in using a foreach loop 
          * as well as the for loop. We see the index control during the running of the for loop vs 
          * the foreach loop it just smoothly goes past that step.
          */
    }
}
