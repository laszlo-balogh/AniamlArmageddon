using Animal_Armageddon.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Logic.GameLogic
{
    public class LavaBallLogic
    {
        public List<LavaBall> LavaBalls { get; set; }
        public IGameItem LavaBall { get; set; }
        public event EventHandler BossWon;
        public static int BallsAddedCounter = 0;
        PlayerLogic pl;

        public LavaBallLogic(PlayerLogic pl)
        {
            this.pl = pl;            
            LavaBalls = new List<LavaBall>();
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));            
        }
        public void KillLavaBalls()
        {            
            foreach (var item in LavaBalls.ToList())
            {
                LavaBalls.Remove(item);
            }
        }
        public void AddMoreLavaBalls()
        {
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));
            LavaBalls.Add(new LavaBall(960, 724, 25, 25));           
        }
        public void AddMoreLavaBallsFromDown()
        {
            LavaBalls.Add(new LavaBall(960, 1080, 25, 25));
            LavaBalls.Add(new LavaBall(960, 1080, 25, 25));
            LavaBalls.Add(new LavaBall(960, 1080, 25, 25));
            LavaBalls.Add(new LavaBall(960, 1080, 25, 25));
            LavaBalls.Add(new LavaBall(960, 1080, 25, 25));
            LavaBalls.Add(new LavaBall(960, 1080, 25, 25));
        }

        #region MoveingLavaBallsMethods
        public void LavaBallMoving0()
        {
            int index = 0;

            foreach (var item in LavaBalls)
            {

                switch (index)
                {
                    case 0:
                        item.Y += 20;
                        item.X -= 20;
                        break;
                    case 1:
                        //item.Y += 20;
                        item.X -= 20;
                        break;
                    case 2:
                        item.Y -= 20;
                        item.X -= 20;
                        break;
                    case 3:
                        item.Y -= 20;
                        item.X += 20;
                        break;
                    case 4:
                        //item.Y += 20;
                        item.X += 20;
                        break;
                    case 5:
                        item.Y += 20;
                        item.X += 20;
                        break;
                    default:
                        break;
                }
                index++;
                if (index > 5)
                {
                    index = 0;
                }
            }      
        }
        //sorok
        public void LavaBallMoving1()
        {
        
            int index = 0;

            foreach (var item in LavaBalls)
            {

                switch (index)
                {
                    case 0:
                        item.Y = 955;
                        item.X -= 20;
                        break;
                    case 1:
                        item.Y = 725;
                        item.X += 20;
                        break;
                    case 2:
                        item.Y = 725;
                        item.X -= 20;
                        break;
                    case 3:
                        item.Y = 955;
                        item.X += 20;
                        break;
                    case 4:
                        item.Y = 495;
                        item.X -= 20;
                        break;
                    case 5:
                        item.Y = 495;
                        item.X += 20;
                        break;
                    default:
                        break;
                }
                index++;
                if (index > 5)
                {
                    index = 0;
                }
            }
        }
        public void LavaBallMoving2()
        {
            int index = 0;

            foreach (var item in LavaBalls)
            {

                switch (index)
                {
                    case 0:
                        item.Y += 30;
                        item.X -= 20;
                        break;
                    case 1:
                        //item.Y += 20;
                        item.X -= 20;
                        break;
                    case 2:
                        item.Y -= 30;
                        item.X -= 20;
                        break;
                    case 3:
                        item.Y -= 30;
                        item.X += 20;
                        break;
                    case 4:
                        //item.Y += 20;
                        item.X += 20;
                        break;
                    case 5:
                        item.Y += 30;
                        item.X += 20;
                        break;
                    default:
                        break;
                }
                index++;
                if (index > 5)
                {
                    index = 0;
                }
            }
        }
        public void LavaBallMoving3()
        {
            int index = 0;

            foreach (var item in LavaBalls)
            {

                switch (index)
                {
                    case 0:
                        item.Y += 10;
                        item.X -= 20;
                        break;
                    case 1:
                        //item.Y += 20;
                        item.X -= 20;
                        break;
                    case 2:
                        item.Y -= 10;
                        item.X -= 20;
                        break;
                    case 3:
                        item.Y -= 10;
                        item.X += 20;
                        break;
                    case 4:
                        //item.Y += 20;
                        item.X += 20;
                        break;
                    case 5:
                        item.Y += 10;
                        item.X += 20;
                        break;
                    default:
                        break;
                }
                index++;
                if (index > 5)
                {
                    index = 0;
                }
            }
        }
        public void LavaBallMoving4()
        {
            int index = 0;

            foreach (var item in LavaBalls)
            {

                switch (index)
                {
                    case 0:
                        item.Y += 20;
                        item.X = 0;
                        break;
                    case 1:
                        item.Y += 20;
                        item.X = 400;
                        break;
                    case 2:
                        item.Y += 20;
                        item.X = 690;
                        break;
                    case 3:
                        item.Y += 20;
                        item.X = 1230;
                        break;
                    case 4:
                        item.Y += 20;
                        item.X = 1520;
                        break;
                    case 5:
                        item.Y += 20;
                        item.X = 1895;
                        break;
                    default:
                        break;
                }
                index++;
                if (index > 5)
                {
                    index = 0;
                }
            }
        }

        public bool firstIter = false;
        public void LavaBallMoving5()
        {
            if (firstIter == false)
            {
                foreach (var item in LavaBalls)
                {
                    item.Y = 1080;
                }
            }
            
            this.firstIter = true;
            int index = 0;

            foreach (var item in LavaBalls)
            {

                switch (index)
                {
                    case 0:
                        item.Y -= 20;
                        item.X = 0;
                        break;
                    case 1:
                        item.Y -= 20;
                        item.X = 400;
                        break;
                    case 2:
                        item.Y -= 20;
                        item.X = 690;
                        break;
                    case 3:
                        item.Y -= 20;
                        item.X = 1230;
                        break;
                    case 4:
                        item.Y -= 20;
                        item.X = 1520;
                        break;
                    case 5:
                        item.Y -= 20;
                        item.X = 1895;
                        break;
                    default:
                        break;
                }
                index++;
                if (index > 5)
                {
                    index = 0;
                }
            }
        }

        #endregion

        public void LavaBallOnPlayer()
        {
            foreach (var item in LavaBalls.ToList())
            {
                if (item.Hitbox.IntersectsWith(pl.Player1.Hitbox))
                {
                    this.KillLavaBalls();
                    pl.Player1.HP -= 334;
                    if (pl.Player1.HP <= 0)
                    {
                        BossWon?.Invoke(this, null);
                    }
                }
            }
        }
    }
}
