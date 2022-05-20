using Animal_Armageddon.GameItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Logic.GameLogic
{
    public class ShootingLogic
    {
        PlayerLogic pl;
        BossLogic bl;
        public List<Bullet> Ammos { get; set; }
        public event EventHandler BulletsMoving;
        public event EventHandler GameOver;

        public ShootingLogic(PlayerLogic pl, BossLogic bl)
        {
            this.pl = pl;
            this.bl = bl;
            Ammos = new List<Bullet>();
        }

        public void Shoot(int dir)
        {
            Ammos.Add(new Bullet(pl.Player1.X+16, pl.Player1.Y+32, 15, 15, dir));
            BulletsMoving?.Invoke(this, null);
        }

        public void BulletMoving()
        {
            foreach (var item in Ammos)
            {
                if (item.Direction == 1)
                {
                    item.Y -= 20;
                }
                else if (item.Direction == 2)
                {
                    item.X += 20;
                }
                else if (item.Direction == 3)
                {
                    item.Y += 20;
                }
                else if (item.Direction == 4)
                {
                    item.X -= 20;
                }
            }
            BulletsMoving?.Invoke(this, null);
        }

        public void BulletOnBoss()
        {
            foreach (var item in Ammos.ToList())
            {
                if (item.Hitbox.IntersectsWith(bl.Boss.Hitbox))
                {
                    Ammos.Remove(item);
                    bl.Boss.HP -= 10;
                    if(bl.Boss.HP <= 0)
                    {
                        GameOver?.Invoke(this, null);
                    }
                }
            }
        }
    }
}
