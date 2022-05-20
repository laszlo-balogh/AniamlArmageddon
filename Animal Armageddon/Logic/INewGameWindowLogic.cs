using Animal_Armageddon.gameobjects.gameobjects;
using Animal_Armageddon.UIModels;
using System.Collections.Generic;

namespace Animal_Armageddon.Logic
{
    public interface INewGameWindowLogic
    {
        Skin SelectedSkin { get; set; }
        void OpenInGameWindow();
        void SetUpCollections(IList<Player> players);        
        void ChangeSkin(string param);       
    }
}