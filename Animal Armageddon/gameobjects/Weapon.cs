using Animal_Armageddon.gameobjects.gameobjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.gameobjects
{
    public enum Rarity { Common, Rare, Epic, Legendary }
    public abstract class Weapon
    {
        public Rarity Rarity { get; set; }
        public string Name { get; set; }
        public IList<Ammunition> Ammunitions { get; set; }
        
    }
}
