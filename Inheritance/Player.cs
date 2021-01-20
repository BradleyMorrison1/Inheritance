using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Player : GameCharacter
    {
        // Fields
        public int score = 100;

        // Constructor
        public Player()
        {
            x = 10;
            y = 20;
            health = 95;
            name = "Hero Smith";
        }

        // Methods 
        public new void ShowStats() // Method overiding
        {
            // this.ShowStats(); // accessing itself
            base.ShowStats(); // accessing the base (parent) itself
            Console.WriteLine("|Score: " + score);
        }
    }
}
