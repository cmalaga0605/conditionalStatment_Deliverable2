using System;

namespace conditionalStatment_Deliverable2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Hi what grade do you expect to get in ISM 4300 ?");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input >= 98 && input <= 100)
            {
                Console.WriteLine("Congrats you got an A+. ");
            }
            else if (input >= 92 && input <= 97)
            {
                Console.WriteLine("Congrats you got an A. ");
            }
            else if (input >= 90 && input <= 91)
            {
                Console.WriteLine("Congrats you got an A-. ");
            }
            else if (input >= 88 && input <= 89)
            {
                Console.WriteLine("Good job ! you got a B+.");
            }
            else if (input >= 82 && input <= 87)
            {
                Console.WriteLine("Nice ! You got a B. ");
            }
            else if (input >= 81 && input <= 80)
            {
                Console.WriteLine("Nice ! You got a B-. ");
            }
            else if (input >= 78 && input <= 79)
            {
                Console.WriteLine("You got a C+. ");
            }
            else if (input >= 72 && input <= 77)
            {
                Console.WriteLine("You got a C. ");
            }
            else if (input >= 70 && input <= 71)
            {
                Console.WriteLine("You got a C-. ");
            }
            else if (input >= 68 && input <= 69)
            {
                Console.WriteLine("You got a D+. ");
            }
            else if (input >= 62 && input <= 67)
            {
                Console.WriteLine("You got a D ," + "do better next time. ");
            }
            else if (input >= 60 && input <= 61)
            {
                Console.WriteLine("You got a D- ," + "do better next time. ");
            }
            else if (input < 60)
            {
                Console.WriteLine("You got a F ," + "you failed ! ");
            }
        }
    }
}
