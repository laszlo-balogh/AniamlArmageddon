using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.GameItems.Terrain
{
    public class Lava : IGameItem
    {
        public Rectangle Rectangle { get
            {
                return new Rectangle(X, Y, Width, Heigth);
            } }

        public Lava(int x, int y, int heigth, int width)
        {
            this.X = x;
            this.Y = y;
            this.Heigth = heigth;
            this.Width = width;
        }
    }
}
