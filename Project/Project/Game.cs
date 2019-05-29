using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Game
    {
        protected string title /*{ get; set; }*/;
        protected string creater /*{ get; set; }*/;
        protected int players /*{ get; set; }*/;

        public Game(string aTitle, string aCreater, int aPlayer)
        {
            title = aTitle;
            creater = aCreater;
            players = aPlayer;

            Console.WriteLine($"Creating Game: {title}");
        }

        public virtual void NoOfGamers()
        {
            Console.WriteLine($"The number of Gamers that can play {title} is: {players}");
        }

        /*public void NoOfGamers()
        {
            Console.WriteLine($"The number of Gamers that can play {title} is: {players}");
        }*/

        public void GameCreater()
        {
            Console.WriteLine($"The name of the Creater is : {creater}");
        }
    }

    public class Gamers
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public double Phone { get; set; }
    }
}
