using Animal_Armageddon.gameobjects.gameobjects;
using Animal_Armageddon.Helpers;
using Animal_Armageddon.Logic;
using Animal_Armageddon.Logic.GameLogic;
using Animal_Armageddon.Services;
using Animal_Armageddon.ViewModels;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Animal_Armageddon
{
    /// <summary>
    /// Interaction logic for InGameWindow.xaml
    /// </summary>
    public partial class InGameWindow : Window
    {
        MapGeneratorLogic mglogic;
        PlayerLogic plogic;
        LavaLogic lavalogic;
        BossLogic bosslogic;
        MovingLogic movlogic;
        ShootingLogic shlogic;
        LavaBallLogic lavaballlogic;
        DispatcherTimer dt;
        DispatcherTimer dt2;
        int rnd = 0;

        public InGameWindow(Player player)
        {            
            InitializeComponent();
            mglogic = new MapGeneratorLogic();
            plogic = new PlayerLogic();            
            bosslogic = new BossLogic();
            movlogic = new MovingLogic(plogic, mglogic);
            shlogic = new ShootingLogic(plogic, bosslogic);
            this.DataContext = new InGameWindowViewModel();
            (this.DataContext as InGameWindowViewModel).Setup(player);
            lavaballlogic = new LavaBallLogic(plogic);
            this.lavalogic = new LavaLogic(plogic);
            lavaballlogic.BossWon += Lavaballlogic_BossWon;
            shlogic.GameOver += Shlogic_GameOver;
            lavalogic.PlayerDieInLava += Lavaballlogic_BossWon;
            dt = new DispatcherTimer();
            display.SetupModel(mglogic, plogic, movlogic, shlogic, bosslogic, lavalogic, lavaballlogic, player.SelectedSkinIndex);
            playerhp.Foreground = display.ProggresBarAndNameColor;
            playername.Foreground = display.ProggresBarAndNameColor;
            display.InvalidateVisual();
            dt = new DispatcherTimer();
            dt2 = new DispatcherTimer();
            rnd = Util.rnd.Next(0, 6);
            dt.Interval = TimeSpan.FromMilliseconds(10);
            dt2.Interval = TimeSpan.FromMilliseconds(3000);
            dt.Tick += (sender, eargs) =>
            {
                movlogic.OnPlatform();
                shlogic.BulletMoving();
                switch (rnd)
                {
                    case 0:
                        lavaballlogic.LavaBallMoving0();
                        break;
                    case 1:
                        lavaballlogic.LavaBallMoving1();
                        break;
                    case 2:
                        lavaballlogic.LavaBallMoving2();
                        break;
                    case 3:
                        lavaballlogic.LavaBallMoving3();
                        break;
                    case 4:
                        lavaballlogic.LavaBallMoving4();
                        break;
                    case 5:
                        lavaballlogic.LavaBallMoving5();
                        break;
                    default:
                        break;
                }
                lavalogic.PlayerInLava();
                lavaballlogic.LavaBallOnPlayer();
                shlogic.BulletOnBoss();
                display.InvalidateVisual();
                bosshp.Value = bosslogic.Boss.HP;
                playerhp.Value = plogic.Player1.HP;
                playername.Content = player.Name;
            };
            dt2.Tick += (sender, eargs) =>
            {
                rnd = Util.rnd.Next(0, 6);
                if (rnd == 5)
                {
                    lavaballlogic.AddMoreLavaBallsFromDown();                    
                }
                else
                {
                    lavaballlogic.KillLavaBalls();
                    lavaballlogic.AddMoreLavaBalls();
                    lavaballlogic.firstIter = false;
                }

            };
            dt.Start();
            dt2.Start();
        }

        private void Shlogic_GameOver(object sender, EventArgs e)
        {
            var result = MessageBox.Show("U defeated the Icon of Sin");
            if (result == MessageBoxResult.OK)
            {
                this.Close();
            }
            dt.Stop();
            dt2.Stop();
        }

        private void Lavaballlogic_BossWon(object sender, EventArgs e)
        {
            var result = MessageBox.Show("U lost to the Icon of Sin");
            if (result == MessageBoxResult.OK)
            {
                this.Close();
            }
            dt.Stop();
            dt2.Stop();
        }
        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.W) && !movlogic.AreWeFalling)
            {
                movlogic.Jump();
            }
            if (Keyboard.IsKeyDown(Key.S))
            {
                movlogic.Move(0, 10);
            }
            if (Keyboard.IsKeyDown(Key.D))
            {
                movlogic.Move(20, 0);
            }
            if (Keyboard.IsKeyDown(Key.A))
            {
                movlogic.Move(-20, 0);
            }
            if (Keyboard.IsKeyDown(Key.Up))
            {
                shlogic.Shoot(1);
            }
            if (Keyboard.IsKeyDown(Key.Right))
            {
                shlogic.Shoot(2);
            }
            if (Keyboard.IsKeyDown(Key.Down))
            {
                shlogic.Shoot(3);
            }
            if (Keyboard.IsKeyDown(Key.Left))
            {
                shlogic.Shoot(4);
            }
            if(Keyboard.IsKeyDown(Key.Escape))
            {
                dt.Stop();
                dt2.Stop();
                this.Close();
            }


            display.InvalidateVisual();
        }
    }
}
