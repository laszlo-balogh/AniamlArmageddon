using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.GameItems.Terrain
{
    public class ITerrain
    {
        public Rectangle Hitbox { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

    }
}
