using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Animal_Armageddon.gameobjects.gameobjects;
using Animal_Armageddon.Helpers;
using Animal_Armageddon.Logic;
using Animal_Armageddon.UIModels;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;

namespace Animal_Armageddon.ViewModels
{
    public class NewGameWindowViewModel : ObservableRecipient
    {
        INewGameWindowLogic logic;
        public ObservableCollection<Player> Players { get; set; }
        Player player1;

        public Player Player1
        {
            get { return player1; }
            set { SetProperty(ref player1, value); }
        }


        public ICommand StartGameCommand { get; set; }
        public ICommand BackToMainMenuCommand { get; set; }
        public ICommand ChangeSkinCommand { get; set; }
        public NewGameWindowViewModel()
             : this(Util.IsInDesignMode ? null : Ioc.Default.GetService<INewGameWindowLogic>())
        {

        }
        public NewGameWindowViewModel(INewGameWindowLogic logic)
        {
            this.logic = logic;
            this.Player1 = new Player();

            Players = new ObservableCollection<Player>();
            Players.Add(this.Player1);            
            
            logic.SetUpCollections(Players);

            this.BackToMainMenuCommand = new RelayCommand<Window>(this.BackToMainMenu);
            this.StartGameCommand = new RelayCommand<Window>(this.CloseWindowByCommand);
            this.ChangeSkinCommand = new RelayCommand<Button>(this.PlayerChangeSkin);


            Messenger.Register<NewGameWindowViewModel, string, string>(this, "SkinInfo", (recipient, msg) =>
            {
                OnPropertyChanged("Player1");
            });
        }

        private void BackToMainMenu(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        private void CloseWindowByCommand(Window window)
        {
            this.logic.OpenInGameWindow();
            if (window != null)
            {
                window.Close();
            }
        }

        private void PlayerChangeSkin(Button parameter)
        {
            if (parameter != null)
            {
                string s = parameter.Name;
                switch (s)
                {
                    case "p1Left":
                        this.logic.ChangeSkin("p1Left");
                        break;

                    case "p1Right":
                        this.logic.ChangeSkin("p1Right");
                        break;

                }
            }
        }

    }
}
