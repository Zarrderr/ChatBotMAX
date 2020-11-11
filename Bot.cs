using System;
using System.Collections.Generic;
using System.Text;

namespace BotMax
{
    class Bot
    {
        public string Name;

        bool isGreeted = false;


        public void Greetings() 
        {
            Console.WriteLine("привет" + Name + "!");
            Console.WriteLine("о чем задумался приятель?");

            bool isGreeted = true;

        }


        public void Sayit()
        {
            if (isGreeted)
            {
                Console.WriteLine("я уже здоровался");

            }
            else
            {
                Console.WriteLine("я еще не здоровался");
            }
        }


        public void CountToTen()
        {
            
            
            Console.WriteLine("считаю до десяти!");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");



        }


        public void CountwhithWhile()
        {


            Console.WriteLine("считаю до десяти с помощью цикла!");
            int number = 1;

        while (number <= 10)
            {

                Console.WriteLine(number + "!");


            }
        }

    }
}
 