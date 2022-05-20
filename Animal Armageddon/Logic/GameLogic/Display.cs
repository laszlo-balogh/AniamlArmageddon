using Animal_Armageddon.UIModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Animal_Armageddon.Logic.GameLogic
{
    public class Display : FrameworkElement
    {
        MapGeneratorLogic mglogic;
        PlayerLogic plogic;
        MovingLogic movlogic;
        ShootingLogic shlogic;
        BossLogic bosslogic;
        LavaLogic lavalogic;
        LavaBallLogic lavaballlogic;

        Brush playerBrush;
        Brush groundBrush;
        Brush bulletBrush;
        Brush skyBrush;
        Brush bossBrush;
        Brush lavaBrush;
        Brush fireBrush;
        public Brush ProggresBarAndNameColor { get; set; }

        public void SetupModel(MapGeneratorLogic model, PlayerLogic plogic, MovingLogic movlogic, ShootingLogic sh, BossLogic bl, LavaLogic lavl, LavaBallLogic lavaballlogic, int playerSkin)
        {
            this.mglogic = model;
            this.plogic = plogic;
            this.movlogic = movlogic;
            this.shlogic = sh;
            this.bosslogic = bl;
            this.lavalogic = lavl;
            this.lavaballlogic = lavaballlogic;
            if (playerSkin == 0)
            {
                this.playerBrush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("textures", "testPlayer2.png"), UriKind.RelativeOrAbsolute)));
                this.ProggresBarAndNameColor = Brushes.Blue;
                this.bulletBrush = Brushes.Blue;
            }
            else if (playerSkin == 1)
            {
                this.playerBrush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("textures", "testPlayer.png"), UriKind.RelativeOrAbsolute)));
                this.bulletBrush = Brushes.OrangeRed;
                this.ProggresBarAndNameColor = Brushes.OrangeRed;
            }
            else if (playerSkin == 2)
            {
                this.playerBrush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("textures", "hippo.png"), UriKind.RelativeOrAbsolute)));
                this.bulletBrush = Brushes.DeepPink;
                this.ProggresBarAndNameColor = Brushes.DeepPink;
            }
        }
        public Display()
        {
            this.skyBrush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("textures", "back.png"), UriKind.RelativeOrAbsolute)));
            this.groundBrush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("textures", "talaj.png"), UriKind.RelativeOrAbsolute)));
            this.lavaBrush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("textures", "lava.png"), UriKind.RelativeOrAbsolute)));
            this.fireBrush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("textures", "fire.jpg"), UriKind.RelativeOrAbsolute)));
            this.bulletBrush = Brushes.Black;
            this.bossBrush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("textures", "boss.gif"), UriKind.RelativeOrAbsolute)));
            this.mglogic = new MapGeneratorLogic();
            this.plogic = new PlayerLogic();
            this.bosslogic = new BossLogic();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            drawingContext.DrawRectangle(skyBrush, null,
                    new Rect(0, 0, ActualWidth, ActualHeight));

            foreach (var item in mglogic.MapObjects)
            {
                drawingContext.DrawRectangle(groundBrush, null, new Rect(item.X, item.Y, item.Width, item.Height));
            }

            foreach (var item in shlogic.Ammos)
            {
                drawingContext.DrawEllipse(bulletBrush, null, new Point(item.X, item.Y), 3, 3);
            }

            foreach (var item in lavaballlogic.LavaBalls)
            {
                drawingContext.DrawEllipse(fireBrush, null, new Point(item.X, item.Y), 25, 25);
            }

            drawingContext.DrawRectangle(playerBrush, null, new Rect(plogic.Player1.X, plogic.Player1.Y, plogic.Player1.Width, plogic.Player1.Heigth));
            drawingContext.DrawRectangle(bossBrush, null, new Rect(bosslogic.Boss.X, bosslogic.Boss.Y, bosslogic.Boss.Width, bosslogic.Boss.Heigth));
            drawingContext.DrawRectangle(lavaBrush, null, new Rect(lavalogic.Lava.X, lavalogic.Lava.Y, lavalogic.Lava.Width, lavalogic.Lava.Heigth));
        }
    }
}
