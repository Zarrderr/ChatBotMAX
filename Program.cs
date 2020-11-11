using System;

namespace BotMax     //имя проэкта
{
    class Program    // основной класс программы
    {
        static void Main(string[] args) // основной метод программы (точка входа)  в нем буду вызывать остольные методы
        {
            Bot Max = new Bot();
            Max.Name = "MAX";    
            Max.Greetings();   // метод привет о чем задумался
            Max.Sayit();       // метод здаровался или нет
            Max.CountToTen();  // метод счет до 10 последовательно
            Max.CountwhithWhile(); // метод счет до 10 циклом вайл
        }
    }
}
