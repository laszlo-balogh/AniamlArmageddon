using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.GameItems
{
    public enum Rarity { Common, Rare, Epic, Legendary }

    public class IGameItem
    {
        public Point Center { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int HP { get; set; }

        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle(X, Y, Width, Heigth);
            }
        }
        
    }
}
