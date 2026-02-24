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
        }
    }
}
