using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Logic.GameLogic
{
    public class MovingLogic
    {
        PlayerLogic plogic;
        MapGeneratorLogic mlogic;
        int Gravity = 8;

        public bool AreWeFalling { get; private set; }

        public MovingLogic(PlayerLogic plogic, MapGeneratorLogic mapGeneratorLogic)
        {
            this.plogic = plogic;
            mlogic = mapGeneratorLogic;
        }

        public void Move(int directionx, int directiony)
        {
            plogic.Player1.X += directionx;
        }

        public void Falling()
        {
            plogic.Player1.Y += Gravity;
        }

        public bool OnPlatform()
        {
            for (int i = 0; i < mlogic.MapObjects.Count; i++)
            {
                if (plogic.Player1.Hitbox.IntersectsWith(mlogic.MapObjects[i].Hitbox))
                {
                    AreWeFalling = false;
                    return true;
                }
            }
            Falling();
            return false;
        }

        public void Jump()
        {
            AreWeFalling = true;
            plogic.Player1.Y -= 350;
        }


    }
}
