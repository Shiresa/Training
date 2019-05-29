using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game Snake = new Game("Snake", "Andrew", 4);
            Game Monoply = new Game("Monoply", "Sadiq", 6);
            Game Football = new Game("Football", "Anthony", 11);
            ComputerGame Zelda = new ComputerGame("Zelda", "Michael", 1, 8);
            Game Zelda1 = new ComputerGame("Zelda 1", "Michael", 1, 8);
            ComputerGame Zelda2 = Zelda;
            TestGameInter Mario = new TestGameInter();

            Snake.NoOfGamers();
            Football.NoOfGamers();

            Zelda.NoOfBits();
            Zelda.NoOfGamers();
            Zelda1.NoOfGamers();
            Zelda2.NoOfBits();

            Mario.add();
            Mario.subtract();

            Console.ReadLine();  

        }
    }
}
