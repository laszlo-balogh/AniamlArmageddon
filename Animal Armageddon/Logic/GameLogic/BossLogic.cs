using Animal_Armageddon.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Logic.GameLogic
{
    public class BossLogic
    {
        public IGameItem Boss{ get; set; }
        public BossLogic()
        {
            Boss = new Boss(792, 368, 336, 712);
        }
    }
}
