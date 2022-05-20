using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Animal_Armageddon.Helpers;
using Animal_Armageddon.Logic;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;

namespace Animal_Armageddon.ViewModels
{
    public class NewGameWindowViewModel
    {
        INewGameWindowLogic logic;

        public ICommand StartGameCommand { get; set; }
        public ICommand BackToMainMenuCommand { get; set; }
        public ICommand ChangeSkinCommand { get; set; }
        public ICommand AddPlayerCommand { get; set; }
        public ICommand RemovePlayerCommand { get; set; }

        public NewGameWindowViewModel()
             : this(Util.IsInDesignMode ? null : Ioc.Default.GetService<INewGameWindowLogic>())
        {

        }
        public NewGameWindowViewModel(INewGameWindowLogic logic)
        {
            this.logic = logic;

            BackToMainMenuCommand = new RelayCommand<Window>(this.BackToMainMenu);
        }

        private void BackToMainMenu(Window window)
        {            
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
