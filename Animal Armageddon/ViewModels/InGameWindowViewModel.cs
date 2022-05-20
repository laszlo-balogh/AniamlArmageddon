using Animal_Armageddon.gameobjects.gameobjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.ViewModels
{
    public class InGameWindowViewModel
    {
        public Player Actual { get; set; }
        public void Setup(Player player)
        {
            this.Actual = player;
        }
        public InGameWindowViewModel() { }
    }
}
