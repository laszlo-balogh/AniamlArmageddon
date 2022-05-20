using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.GameItems
{
    public class Boss : IGameItem
    {
        public Boss(int x, int y, int width, int heigth)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Heigth = heigth;
            this.Center = new Point(x, y);
            this.HP = 10000;
        }
    }
}
