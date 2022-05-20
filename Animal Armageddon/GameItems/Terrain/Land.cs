using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.GameItems.Terrain
{
    class Land:ITerrain
    {
         public Land(int x, int y, int heigth, int width)
        {
            this.X = x;
            this.Y = y;
            this.Height = heigth;
            this.Width = width;
            this.Hitbox=new Rectangle(X, Y, Width, Height);
        }
    }
}
