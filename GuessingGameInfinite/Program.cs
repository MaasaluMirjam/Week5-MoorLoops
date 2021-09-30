using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku nr 1-10
            //kasutaja peab nr ära arvama
            //kui kasutaja arvab ära nr, siis ta on mängu võitnud
            //katsete arv on piiramatu
            //*programm genereerib juhuslikku nr ühe korra
          
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Palun sisestage nr 1-10");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne! oled võitnud");
                    //break;
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti");
                }
            }           
        }
    }
}
