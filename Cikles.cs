using System;
using System.Collections.Generic;
using System.Text;

namespace BotMax
{
    public class Cikles
    {
        public string Name;



       public bool isGreeted = false;     // переменная булевого типа определяет тру или фалс условия

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

        /*
         public void CountToTen()
         {


             Console.WriteLine("хей");



         }
         int number = 10;

         public void CountwhithWhile()
         {


             Console.WriteLine("считаю до десяти с помощью цикла!");


             {
                 while (number <= 10)

                     Console.Write(number + "!");    // если WriteLine вертикальой строкой если Write горизонтальной 


                 // number = number + 1;   // операторы если нужно поставить другое число больше единицы 
                 // number += 1;
                 number++; // оператор прибовляющий значение на 1



             }
         }

         public void CountwhitDoWhile()
         {
             do

             {
                 Console.WriteLine(number + "!");
                 number++;
             }

             while (number <= 1);

             Console.WriteLine("метод завершен");
         }



         public void CountwithFor()   // неведомая ошибка

         {
             Console.WriteLine("считаем циклом for");

             for (int nuber = 1; number <= 10; number++)   // for( счетчик int nuber = 1; условие number <=10; этератор number++)
             {

                 Console.WriteLine(number + "!");
             }

         }
     }


     */

    }

}



