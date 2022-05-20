using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.gameobjects.gameobjects
{
    public abstract class Ammunition
    {
        public Ammunition? AmmunitionType { get; set; }
        public double SpeedX { get; set; }
        public double SpeedY { get; set; }
        public int Demage { get; set; }
        public bool CanExplode { get; set; } = false;

        public abstract void Explode();

    }
}
