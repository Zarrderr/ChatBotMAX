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

        public bool Ifneed = false;
        
        public bool Isplaying;





        public void Greetings()
        {
            Console.WriteLine("привет меня зовут  " + Name + "!");
            

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
                                   "я тебя внимательно слушаю! ","выбири темму для разговора","давай общаться?","поговорим?","ну что? поболтаем?"};
            Console.WriteLine(rasgovor[new Random().Next(0, rasgovor.Length)]);

           Console.ReadLine();

        }
       
        /*public void IfneedGames()
        {

           {
                Console.WriteLine("хочешь сыграть со мной в игру?");
                    bool Ifneed = true;


                while (Ifneed)
                {

                    string[] ciclesay = { $"хм красивое имя", $"правда?{message}? рад знакомству", $"{message} никогда бы не подумал",
                                                    $"круто быть тобой {message}", $"я тоже хочу имя {message} но меня назвали " + Name};


                    if (IsWorking)
                    {
                        var enterr = Console.ReadLine();

                        string[] enterry = { $"{enterr} хм красивое имя", $"правда?{enterr}? рад знакомству", $"{enterr} никогда бы не подумал",
                                                    $"круто быть тобой {enterr}", $"я тоже хочу имя {enterr} но меня назвали " + Name};

                    }
                    else
                    {

                        break;

                    }




                }




            }


        }


        */


        public void StartMainLoop()

        {
            //game.Start();
              IsWorking = true;

            while (IsWorking)
            {
                var message = Console.ReadLine();

                string[] ciclesay = { $"{message} ой да ладно тебе", $"правда?{message}?", $"{message} ну ты чего удумал то а?",
                                                    $" {message} да я даже не знаю ?", $" {message}? это вообще законно??"};

                

                if (game.Isplaying)
                {
                    game.MakeTurn(message);
                }
                else
                {

                    Console.WriteLine(Answer());   //в врайтлайн подставляется значение метода ансер

                }

               
                string Answer()   // отдельный метод строчный
                {
                    string[] lines = new string[5]; //обьяви переменну массив типа стринг с иминем лайнс присваеваем ссылку на новый массив из пяти строк

                    lines[0] = "да ладно";
                    lines[1] = "серьезно???";
                    lines[2] = "что ты несешь?";
                    lines[3] = "ой ой как круто то";
                    lines[4] = "хм прикольно!";

                    Random rand = new Random();


                    return lines[rand.Next(0, lines.Length)];
                }

            }

        }

    }
}
 


