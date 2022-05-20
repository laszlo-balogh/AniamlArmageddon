using Animal_Armageddon.gameobjects.gameobjects;
using Animal_Armageddon.Services;
using Animal_Armageddon.UIModels;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Armageddon.Logic
{
    public class NewGameWindowLogic : INewGameWindowLogic
    {
        IList<Player> Players;

        IMessenger messenger;
        IInGameWindowOpenerService service;


        public Skin SelectedSkin { get; set; }

        public NewGameWindowLogic(IMessenger messenger, IInGameWindowOpenerService service)
        {
            this.messenger = messenger;
            this.service = service;
        }

        public void SetUpCollections(IList<Player> players)
        {
            this.Players = players;
        }        
      
        public void OpenInGameWindow()
        {
            service.NewWindow(this.Players[0]);
        }

        public void ChangeSkin(string param)
        {
            Player p1 = Players[0];           
            if (param == "p1Left")
            {
                if (p1.SelectedSkinIndex==0)
                {
                    p1.SelectedSkin = p1.Skins[p1.Skins.Count()-1];
                    p1.SelectedSkinIndex = p1.Skins.Count() - 1;
                }               
                else
                {
                    p1.SelectedSkin = p1.Skins[p1.SelectedSkinIndex - 1];
                    p1.SelectedSkinIndex--;
                }
                
            }
            else if (param == "p1Right")
            {
                if (p1.SelectedSkinIndex == p1.Skins.Count()-1)
                {
                    p1.SelectedSkin = p1.Skins[0];
                    p1.SelectedSkinIndex = 0;
                }
                else
                {
                    p1.SelectedSkin = p1.Skins[p1.SelectedSkinIndex + 1];
                    p1.SelectedSkinIndex++;
                }
            }                       
            messenger.Send("skinChanged", "SkinInfo");
        }
    }
}
