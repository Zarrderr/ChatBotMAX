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

            Strong.Name = "Адольф";
            Max.Name = "MAX";    


            Max.Greetings();   // метод привет о чем задумался
            Strong.Sayit();       // метод здаровался или нет из класса Cikles
            //Max.CountToTen();  // метод счет до 10 последовательно
            //Max.CountwhithWhile(); // метод счет до 10 циклом вайл
            //Max.CountwithFor();


            Max.StartMainLoop();   // цикл с безконечным переспрашиванием  
 



            Console.ReadKey(); // после выполнения всех методов в теле майн консоль ожидает ввода рандомной клавиши для закрытия 
        }
    }
}
