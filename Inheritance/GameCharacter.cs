using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class GameCharacter
    {
        // fields
        public string name;
        public int x;
        public int y;
        public int health;

        // Methods
        public void ShowStats()
        {
            Console.WriteLine("\n|Name: " + name);
            Console.WriteLine("|Health: " + health);
            Console.WriteLine("|X: " + x + " |Y: " + y + "\n");
        }
    }
}
