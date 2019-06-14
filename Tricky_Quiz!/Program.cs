using System;

namespace Tricky_Quiz_
{
    class Program
    {
        private static int Incorrect = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! And welcome to my Tricky Quiz!");
            Console.WriteLine("Please press any Key to continue!");
            Console.ReadLine();
            while (Incorrect < 6)
            {
                Random random = new Random();
                int questionNumber = random.Next(1, 3);
                Console.Clear();
                Console.WriteLine(RandomQuestion(questionNumber));
                Console.WriteLine();
                Console.WriteLine("Answer the question");
                var answer = Console.ReadLine().ToLower();
                Console.WriteLine(CheckAnswer(answer));
                Console.ReadLine();
            }

        }

        static string RandomQuestion(int num)
        {
            switch(num)
            {
                case 1: return "Which is correct? “Penguins flies” or “A penguin flies.”";
                case 2: return "If you jump off the roof of a three-story building, where would you land?";
            }
            return "null";
        }

        static string CheckAnswer(string answer)
        {
            switch (answer)
            {
                case "Penguins dont fly": return "Correct";
                case "penguins can't fly": return "Correct";
                case "none": return "Correct";
                case "hospital": return "Correct!";
                case "the hospital": return "Correct";

            }
            Incorrect++;
            Console.WriteLine($"you have {6 - Incorrect} guesses left!");
            return "Incorrect!";
            
        }
    }
}
