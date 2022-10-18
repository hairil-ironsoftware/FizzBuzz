using System;
using System.Diagnostics;

namespace FizzBuzz
{
    public class Fizzbuzz
    {
        public static void Main(String[] args)
        {
            //the program detect the numbers that are divisible by 3 and 5
            for (int i = 1; i <= 15; i++) //for loops to loop over number starting from 1 to 15, the program will exit at 15
            {
                if(i % 15 == 0) //if it is divisible by 3 and 5, the number will be replaced with FizBuzz
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0) //else, if the number is only divisible by 3, the number will be replaced by Fizz
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0) //else, if the number is only divisible by 5, the num will be replaced by Buzz
                {
                    Console.WriteLine("Buzz");
                }
                else //other numbers that are not divisible by either 3 or 5, will return the number
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
 }
