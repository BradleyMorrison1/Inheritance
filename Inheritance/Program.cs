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
            player.x = 10;
            player.y = 20;
            player.health = 95;
            player.name = "Hero Smith";
            player.ShowStats();

            // Enemy
            enemy.x = 50;
            enemy.y = 80;
            enemy.health = 100;
            enemy.name = "Villain Smith";
            enemy.ShowStats();

            Console.ReadKey(true);
        }
    }
}
