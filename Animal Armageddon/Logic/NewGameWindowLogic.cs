using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Logic
{
    public class NewGameWindowLogic : INewGameWindowLogic
    {
        IMessenger messenger;
        public NewGameWindowLogic(IMessenger messenger)
        {
            this.messenger = messenger;
        }

        public void BackToMainMenu()
        {

        }

        public void StartGame()
        {

        }

        public void RemovePlayer()
        {

        }
        public void AddPlayer()
        {

        }
        public void ChangeSkin()
        {

        }
    }
}
