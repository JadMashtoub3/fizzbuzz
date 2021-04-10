using System;

namespace fizzbuzz
{

    class Program
    {
        static void Main(String[] args) 
        {
        int number;
            
            for (number = 1; number <= 100; number++) {
            if (number % 3 == 0 && number % 5 == 0) 
            {
               Console.WriteLine("FizzBuzz");
            } 
            else if (number % 3 == 0) 
            {
               Console.WriteLine("Fizz");
            } 
            else if (number % 5 == 0) 
            {
               Console.WriteLine("Buzz");
            } 
            //had to look up what to do on these two lines below
            else {
               Console.WriteLine(number);
            }
         }
      }
   }
}