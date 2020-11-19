using System;
using BotMax.Games;

namespace BotMax     //имя проэкта
{
    class Program    // основной класс программы
    {
        static void Main(string[] args) // основной метод программы (точка входа)  в нем буду вызывать остольные методы
        {
            Bot Max = new Bot(); // создаем из класса обьект 
            Cikles Strong = new Cikles();

            
            Max.Name = "MAX";
            
            

            Max.Greetings();   // метод привет о чем задумался
            Max.WhatYouName1(); // метод как тебя зовут??
            Max.WhatYouName2(); // метод ввода имини и рандомный ответ
            Max.VarianRasgovor();
            Max.StartMainLoop();   // цикл с безконечным переспрашиванием




            //Strong.Sayit();       // метод здаровался или нет из класса Cikles

            //Max.CountToTen();  // метод счет до 10 последовательно
            //Max.CountwhithWhile(); // метод счет до 10 циклом вайл
            //Max.CountwithFor();


            // Max.StartMainLoop();   // цикл с безконечным переспрашиванием  




            Console.ReadKey(); // после выполнения всех методов в теле майн консоль ожидает ввода рандомной клавиши для закрытия 
        }
    }
}
