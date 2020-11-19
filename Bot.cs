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

        public bool NoWorking = true;





        public void Greetings()
        {
            Console.WriteLine("привет меня зовут  " + Name + "!");
            

            bool isGreeted = true;

            string name = Console.ReadLine();
        }

        public void WhatYouName1()
        {
            Console.WriteLine("а как зовут тебя??");

        }

        public void WhatYouName2()
        {


            var myname = Console.ReadLine();

            string[] otvet = { $"{myname} хм красивое имя", $"правда?{myname}? рад знакомству", $"{myname} никогда бы не подумал",
            $"круто быть тобой {myname}", $"я тоже хочу имя {myname} но меня назвали " + Name};

            Console.WriteLine(otvet[new Random().Next(0, otvet.Length)]);

            

        }

        public void VarianRasgovor()
        {

            string[] rasgovor = { "о чем поговорим", "что расскажешь", "давай поболтаем","ну вещай",
                                   "я тебя внимательно слушаю! ","выбири темму для разговора","давай общаться","поговорим?","ну что? поболтаем?"};
            Console.WriteLine(rasgovor[new Random().Next(0, rasgovor.Length)]);

            var potvet = Console.ReadLine();

        }

         


        public void StartMainLoop()

        {
            
            NoWorking = false;
            IsWorking = true;

            while (IsWorking)
            {



                var message = Console.ReadLine();

                string[] ciclesay = { $"{message} хм красивое имя", $"правда?{message}? рад знакомству", $"{message} никогда бы не подумал",
                                                    $"круто быть тобой {message}", $"я тоже хочу имя {message} но меня назвали " + Name};

     
                if(NoWorking)
                {
                    var enterr = Console.ReadLine();

                    string[] enterry = { $"{enterr} хм красивое имя", $"правда?{enterr}? рад знакомству", $"{enterr} никогда бы не подумал",
                                                    $"круто быть тобой {enterr}", $"я тоже хочу имя {enterr} но меня назвали " + Name};

                }
                else
                {

                    Console.WriteLine(ciclesay[new Random().Next(0, ciclesay.Length)]);

                }
                
                
                

            }



           
        }


        


            
        

    }
}
 


