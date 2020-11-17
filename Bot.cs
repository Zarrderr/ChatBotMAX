using System;
using System.Collections.Generic;
using System.Text;
using BotMax.Games;


namespace BotMax
{

    



    class Bot
    {

        GuesNumberGames game = new GuesNumberGames();


        public bool isGreeted = false;     // переменная булевого типа определяет тру или фалс условия
        
        public string Name; // переменная имя обекта в классе 

        

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
            game.Start();
            IsWorking = true;
            while (IsWorking)
            {
                var message = Console.ReadLine();
                if(game.Itsplaying)
                {
                
                game.MakeTurn(message);
                
                }
                else
                {
                Console.WriteLine($"почему {message}???");
                }

                
            }



           
        }


        


            
        

    }
}
 


