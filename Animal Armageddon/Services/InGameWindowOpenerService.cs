using Animal_Armageddon.gameobjects.gameobjects;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Services
{
    public class InGameWindowOpenerService : IInGameWindowOpenerService
    {
        public void NewWindow(Player p)
        {
            new InGameWindow(p).Show();
        }
    }
}
