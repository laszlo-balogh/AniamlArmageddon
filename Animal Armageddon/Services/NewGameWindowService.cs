using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Services
{
    public class NewGameWindowService : INewGameWindowService
    {
        public void NewGame()
        {
            new NewGameWindow().ShowDialog();
        }
    }
}
