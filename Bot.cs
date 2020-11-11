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
    }
}
 