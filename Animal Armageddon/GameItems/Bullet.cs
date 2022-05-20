using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.GameItems
{
    public class Bullet:IGameItem
    {
        public int Direction { get; set; }

        public Bullet(int x, int y, int width, int heigth, int direction)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Heigth = heigth;
            this.Direction = direction;
        }
    }
}
