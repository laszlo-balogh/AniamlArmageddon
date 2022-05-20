using Animal_Armageddon.gameobjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.gameobjects.gameobjects
{
    public class Player
    {
        public string Name { get; set; }
        IList<Weapon> Inventory { get; set; }
        public int HP { get; set; }
        public double SpeedX { get; set; }
        public double SpeedY { get; set; }


    }
}
