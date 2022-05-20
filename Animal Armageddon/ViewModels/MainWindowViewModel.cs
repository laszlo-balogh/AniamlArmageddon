using Animal_Armageddon.Helpers;
using Animal_Armageddon.Logic;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Animal_Armageddon.ViewModels
{
    public class MainWindowViewModel
    {
        IMainWindowLogic logic;
        public ICommand NewGameCommand { get; set; }
        public ICommand ExitGameCommand { get; set; }

        public MainWindowViewModel()
           : this(Util.IsInDesignMode ? null : Ioc.Default.GetService<IMainWindowLogic>())
        {

        }

        public MainWindowViewModel(IMainWindowLogic logic)
        {
            this.logic = logic;

            this.NewGameCommand = new RelayCommand<Window>(this.CloseWindow);             

            this.ExitGameCommand = new RelayCommand(
                () => this.logic.ExitGame(),
                () => true
                );
        }

        private void CloseWindow(Window window)
        {
            this.logic.NewGame();
            if (window != null)
            {
                window.Close();
            }           
        }

       
    }
}
