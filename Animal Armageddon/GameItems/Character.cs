using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.GameItems
{
    class Character : IGameItem
    {
        public Character(int x, int y, int width, int heigth, int hp)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Heigth = heigth;
            this.Center = new Point(x, y);
            this.HP = hp;
        }
    }
}
