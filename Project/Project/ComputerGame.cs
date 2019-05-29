using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ComputerGame : Game
    {
        private int noBits;

        public ComputerGame(string aTitle, string aCreater, int aPlayer, int noBits)
        : base(aTitle, aCreater, aPlayer)
        {
            this.noBits = noBits;
        }

        public void NoOfBits()
        {
            Console.WriteLine($"the number of bites for {title} is {noBits}");
        }


        public override void NoOfGamers()
        {
            Console.WriteLine($"The number of Gamers that can play this computer game {title} is: {players}");
        }

        /*public new void NoOfGamers()
        {
            Console.WriteLine($"The number of Gamers that can play this computer game : {players}");
        }*/
    }
}
