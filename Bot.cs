using System;
using System.Collections.Generic;
using System.Text;
using BotMax.Games; // подключение библиотеки папки Games иначе   GuesNumberGames не работает


namespace BotMax
{

   
    class Bot
    {
         
        GuesNumberGames game = new GuesNumberGames();  // новая переменная GuesNumberGames в классе точнее со ссылкой на класс GuesNumberGames

        
        public string Name; // переменная имя обекта в классе 

        public bool IsWorking = false;
        
        string[] otvet = { "красивое имя", "правда? рад знакомству", "офигенно", };




        public void Greetings()
        {
            Console.WriteLine("привет меня зовут  " + Name + "!");
            

            bool isGreeted = true;

            string name = Console.ReadLine();
        }

        public void WhatYouName()
        {
            Console.WriteLine("а как зовут тебя??");

        }

        public void WhatYouName2()
        {
            string myname;
            myname = Console.ReadLine();

            Console.WriteLine(otvet[new Random().Next(0, otvet.Length)]);

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
 


