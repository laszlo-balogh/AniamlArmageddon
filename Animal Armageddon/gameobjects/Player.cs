using Animal_Armageddon.GameItems;
using Animal_Armageddon.gameobjects;
using Animal_Armageddon.UIModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Animal_Armageddon.gameobjects.gameobjects
{
    public class Player
    {
        public string Name { get; set; }       
        public int HP { get; set; }
        public double SpeedX { get; set; }
        public double SpeedY { get; set; }
        public Skin SelectedSkin { get; set; }
        public int SelectedSkinIndex { get; set; }
        public List<Skin> Skins { get; set; }

        public Player()
        {
            Name = "Player";
            Skins = new List<Skin>();
            Skins.Add(new Skin()
            {
                Color = "Blue",
                Name ="Low Budget Sonic",
                Root = "/textures/testPlayer2.png"
            });
            Skins.Add(new Skin()
            {
                Color = "OrangeRed",
                Name = "Foxi",
                Root = "/textures/testPlayer.png"
            });
            Skins.Add(new Skin()
            {                
                Color = "DeepPink",
                Name = "Hippi Hippo",
                Root = "/textures/hippo.png"
            });

            SelectedSkinIndex = 0;
            this.HP = 1000;
            this.SpeedX = 0;
            this.SpeedY = 0;
            this.SelectedSkin=Skins[0];
        }
    }
}
