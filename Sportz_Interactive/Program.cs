using System;
using System.Collections.Generic;

namespace Sportz_Interactive
{
    public sealed class Circle
    {
        public double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
    class Geometry
    {
        public double CalculateArea(double sideLength)
        {
            return sideLength * sideLength;
        }

        public double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }
    public class Batsman
    {
        public string Name { get; set; }
        public int RunsScored { get; set; }
        public double StrikeRate { get; set; }

        public double CalculateBattingMomentum()
        {
            return RunsScored * StrikeRate;
        }
    }


    public class Program
    {
        // Question 1: Given an array of integers, write a C# method to total all the values that are even numbers. //
        public static int SumOfEvenNumbers(int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0) 
                {
                    sum += num; 
                }
            }

            return sum;
        }
        // Question 2: 
        public static void NumberIsEven()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("valar morghulis is " + i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("valar is " + i); 
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("morghulis is " + i); 
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
            
        }
        // Question 3: 
        public static void TwoNumberSwap()
        {
            int firstNumber = 5;
            int secondNumber = 10;
            firstNumber = firstNumber * secondNumber;
            secondNumber = firstNumber / secondNumber;
            firstNumber = firstNumber / secondNumber;
            Console.WriteLine("First Number is " + firstNumber);
            Console.WriteLine("Second Number is " + secondNumber);
        }
        // Question 4:
        public static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        // Question 5:
        public static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Invalid input. N must be a positive integer.");
                return -1;
            }
            else if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int a = 0, b = 1;
                for (int i = 3; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }
        }
        // Question 6:
        public static double Power(double baseNumber, int exponent, double result = 1)
        {
            if (exponent == 0)
                return result;

            return Power(baseNumber, exponent - 1, result * baseNumber);
        }
        // Question 7:
        public enum Colors
        {
            Red,
            Blue,
            Green,
            Yellow
        }
        // Question 8:

        static void Main(string[] args)
        {
            // Question 1: Given an array of integers, write a C# method to total all the values that are even numbers. //
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenSum = SumOfEvenNumbers(numbers);
            Console.WriteLine("Sum of even numbers: " + evenSum);

            // Question 2: 
            NumberIsEven();

            // Question 3:
            TwoNumberSwap();

            // Question 4:
            Circle circle = new Circle();
            circle.radius = 10.0;
            double circumference = circle.Calculate(CalculateCircumference);
            string formattedNumber = circumference.ToString("0.00");
            Console.WriteLine("The circumference of the circle is: " + formattedNumber);

            // Question 5:
            Console.Write("Enter the value of N: ");
            int n = int.Parse(Console.ReadLine());
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine($"The {n}th Fibonacci number is: {fibonacciNumber}");

            // Question 6:
            Console.Write("Enter the base number: ");
            double baseNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());
            double result = Power(baseNumber, exponent);
            Console.WriteLine("Result: " + result);

            // Question 7:
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(color);
            }

            // Question 8:
            Geometry geometry = new Geometry();
            double squareArea = geometry.CalculateArea(5.0);
            Console.WriteLine("Area of the square: " + squareArea);

            double rectangleArea = geometry.CalculateArea(3.0, 4.0);
            Console.WriteLine("Area of the rectangle: " + rectangleArea);

            // Question 9:
            List<Batsman> batsmen = new List<Batsman>
            {
                new Batsman { Name = "M.S. Dhoni", RunsScored = 61, StrikeRate = 58.90 },
                new Batsman { Name = "Rohit Sharma", RunsScored = 13, StrikeRate = 124.0 },
                new Batsman { Name = "Virat Kohli", RunsScored = 50, StrikeRate = 78.30 },

            };

            Batsman bestBatsman = null;
            double highestMomentum = 0;

            foreach (Batsman batsman in batsmen)
            {
                double momentum = batsman.CalculateBattingMomentum();

                if (momentum > highestMomentum)
                {
                    highestMomentum = momentum;
                    bestBatsman = batsman;
                }
            }

            if (bestBatsman != null)
            {
                Console.WriteLine("Batsman with the best batting momentum:");
                Console.WriteLine("Name:" + bestBatsman.Name);
                Console.WriteLine("Runs Scored:" + bestBatsman.RunsScored);
                Console.WriteLine("Strike Rate:" + bestBatsman.StrikeRate);
                Console.WriteLine("Batting Momentum:" + highestMomentum);
            }
            else
            {
                Console.WriteLine("No batsman found.");
            }
        }
    }
}
