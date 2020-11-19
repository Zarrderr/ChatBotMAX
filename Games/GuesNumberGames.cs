using System;
using System.Collections.Generic;
using System.Text;


namespace BotMax.Games
{
    class GuesNumberGames
    {


        public bool Isplaying;

        int Number;


        public void Start()
        {
            Isplaying = true;

            Random rand = new Random(); // рандом встроеная библиотека для генерации случайных значений
            Number = rand.Next(1, 100);

            Console.WriteLine("я загадал число от 1 до 100 угадай какое");




        }

        public void Finish()
        {
            Isplaying = false;

            Console.WriteLine("игра закончилась");


        }


        public void MakeTurn(string messege) // переменная в методе в скобках это передаваемый параметр в методе
        {
            
            try
            {

                int guess = Convert.ToInt32(messege);

                if (guess == Number)
                {
                    Console.WriteLine($"да ты угадал! я загадывал число {Number}!");
                    Finish();
                    return;
                }


                if (guess < Number)

                {
                    Console.WriteLine($"нет мое число больше!");

                }


                else
                {
                    Console.WriteLine($"нет мое число меньше!");
                }

            }
            catch(FormatException ex)
            {
                Console.WriteLine("НЕТ! ВВЕДИ ЦИФРОВОЕ ЧИСЛО!");

            }
           
            
        }

        


    }
        
}
