using System;

namespace GuessingGameTreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);

            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Palun sisestage nr 1-10");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne oled võitnud");
                    //break;
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti.{3 - i} katset on jäänud.");
                }
            }
        }
    }
}
