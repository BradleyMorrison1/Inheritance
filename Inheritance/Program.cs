using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Inheritance - Bradley Morrison|");

            Player player = new Player();
            Enemy enemy = new Enemy();

            // Player
            player.ShowStats();

            // Enemy
            enemy.ShowStats();

            Console.ReadKey(true);
        }
    }
}
