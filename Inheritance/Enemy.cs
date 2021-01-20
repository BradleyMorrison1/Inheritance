using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Enemy : GameCharacter
    {

        public Enemy()
        {
            x = 50;
            y = 80;
            health = 100;
            name = "Villain Smith";
        }
    }
}
