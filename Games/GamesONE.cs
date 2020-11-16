using System;
using System.Collections.Generic;
using System.Text;

namespace BotMax.Games
{
    class GamesONE
    {


        

        public bool Itsplaying;


        public void Start()
        {

            Itsplaying = true;
            Console.WriteLine("игра началась");


        }

        public void Finish()
        {
            Itsplaying = false;

            Console.WriteLine("игра началась");


        }


        public void MakeTurn(string messege) // переменная в методе в скобках это передаваемый параметр в методе
        {
            Console.WriteLine("ход совершен");
            Finish();
        }

        /*
        public void SwitchChannel(int buttonNumber) 
        {
            int Tvchannel = 3;

            Tvchannel = buttonNumber;

           
        }
        */
         
    }
}
