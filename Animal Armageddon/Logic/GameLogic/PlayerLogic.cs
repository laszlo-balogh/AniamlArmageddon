
using Animal_Armageddon.GameItems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Logic.GameLogic
{
    //EGYELŐRE EGY PLAYER VAN BENNE
    public class PlayerLogic 
    {
        public IGameItem Player1 { get; set; }


        //30, 916, 64, 64
        public PlayerLogic()
        {
            Player1 = new Character(30, 916, 64, 64, 1000);
        }




    }
}
