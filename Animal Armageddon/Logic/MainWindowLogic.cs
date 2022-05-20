using Animal_Armageddon.Services;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Animal_Armageddon.Logic
{
    public class MainWindowLogic : IMainWindowLogic
    {
        IMessenger messenger;
        INewGameWindowService newGameService;

        public MainWindowLogic(IMessenger messenger, INewGameWindowService newGameService)
        {
            this.messenger = messenger;
            this.newGameService = newGameService;
            
        }

        public void NewGame()
        {
           
            this.newGameService.NewGame();
            
        }

        public void ExitGame()
        {
            Application.Current.Shutdown();
        }
    }
}
