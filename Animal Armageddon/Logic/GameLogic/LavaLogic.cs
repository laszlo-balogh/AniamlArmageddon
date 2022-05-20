using Animal_Armageddon.GameItems;
using Animal_Armageddon.GameItems.Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Logic.GameLogic
{
    public class LavaLogic : IGameItem
    {
        PlayerLogic playerLogic;
        public event EventHandler PlayerDieInLava;
        public IGameItem Lava { get; set; }
        public LavaLogic(PlayerLogic playerLogic)
        {
            this.Lava = new Lava(0, 1030, 50, 1920);
            this.playerLogic = playerLogic;
        }

        public void PlayerInLava()
        {
            if (playerLogic.Player1.Hitbox.IntersectsWith(this.Lava.Hitbox))
            {
                playerLogic.Player1.HP = 0;
                PlayerDieInLava?.Invoke(this,null);
            }
        }
    }
}
