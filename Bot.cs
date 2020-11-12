using System;
using System.Collections.Generic;
using System.Text;

namespace BotMax
{
    class Bot
    {

        public bool isGreeted = false;     // переменная булевого типа определяет тру или фалс условия
        
        public string Name;

       

        public bool IsWorking = false;

        

        string name = Console.ReadLine();

        public void YouName()
        {

            Console.ReadLine();

        }



        public void Greetings()
        {
            Console.WriteLine("привет" + Name + "!");
            

            bool isGreeted = true;

        }

        public void StartMainLoop()
        {
            IsWorking = true;
            while (IsWorking)
            {
                var message = Console.ReadLine();
                Console.WriteLine($"почему {message}???");
            }



           
        }


        


            
        

    }
}
 


