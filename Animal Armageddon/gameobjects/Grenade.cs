using Animal_Armageddon.gameobjects.gameobjects;
using Animal_Armageddon.gameobjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.gameobjects
{
    public  class Grenade : Weapon
    {
        public Grenade()
        {
            this.Rarity = Rarity.Common;
            this.Name = "Grenade";
            Ammunitions = new List<Ammunition>();
        }

        public void Fire()
        {

        }

        public void Explode()
        {

        }
    }
}
