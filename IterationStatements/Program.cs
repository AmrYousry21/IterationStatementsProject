using System;
using System.Collections.Generic;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();

            program.ExerciseOne();
            program.ExerciseTwo();
            Console.WriteLine("Exercise Three \n");
            program.NumbersThousand();
            program.ByThree();
            program.Equal();
            program.OddOrEven();
            program.PositiveNegative();
            program.Vote();
        }
        
        public void ExerciseOne() 
        {
            for (int i = 0; i < 16; i++) 
            {
                Console.WriteLine(i);
            } 
        }
        
        public void ExerciseTwo()
        {
            Console.WriteLine("Exercise 2:\n");
            var numbers = new List<int>();

            int number = 0;

            do
            {
                number++;
                numbers.Add(number);

            } while (number < 100);

            while (number < 200)
            {
                number++;
                numbers.Add(number);
            }

            Console.WriteLine("Increase:");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void NumbersThousand() 
        {
            for (int i = -1000; i <= 1000; i++) 
            {
                Console.WriteLine(i);
            }    
        }

        public void ByThree() 
        {
            for(int i = 3; i < 1000; i += 3) 
            {
                Console.WriteLine(i);
            }  
        }

        public void Equal() 
        {
            int numA = 0;
            int numB = 0;

            Console.WriteLine("Enter a number:");
            numA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Second number:");
            numB = int.Parse(Console.ReadLine());

            string result = (numA == numB) ? "They are equal" : "They are not equal";
            Console.WriteLine(result);
        }

        public void OddOrEven() 
        {
            int number = 0;

            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());

            string result = (number % 2 == 0) ? "The number is even" : "The number is odd";
            Console.WriteLine(result);
        }

        public void PositiveNegative()
        {
            int number = 0;

            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());

            string result = (number > 0) ? "The number is positive" : "The number is negative";
            Console.WriteLine(result);
        }

        public void Vote()
        {
            int age = 0;

            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());

            string result = (age < 18) ? $"Voting age is 18. Please try agian in {18 - age} year/years" : "You may vote. Choose carefully";
            Console.WriteLine(result);
        }

    }

    
        
    
}
