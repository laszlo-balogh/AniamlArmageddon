using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.GameItems
{
    public class LavaBall : IGameItem
    {
        public LavaBall(int x, int y, int width, int heigth)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Heigth = heigth;
           
        }
    }
}
