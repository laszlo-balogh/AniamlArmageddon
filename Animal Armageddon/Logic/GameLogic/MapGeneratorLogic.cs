using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Animal_Armageddon.GameItems.Terrain;

namespace Animal_Armageddon.Logic.GameLogic
{
    //megcsinálja a mapot
    public class MapGeneratorLogic
    {
        Size windowsize;

        public List<ITerrain> MapObjects { get; set; }

        public void getWindowSize(Size size)
        {
            windowsize = size;
        }

        //x,y, magasság, szélesség
        public MapGeneratorLogic()
        {
            MapObjects = new List<ITerrain>();
            //also
            MapObjects.Add(new Land(0, 980, 50, 600));
            MapObjects.Add(new Land(1320, 980, 50, 600));
            //also+1
            MapObjects.Add(new Land(250, 750, 50, 400));
            MapObjects.Add(new Land(1270, 750, 50, 400));
            //also+2
            MapObjects.Add(new Land(450, 520, 50, 200));
            MapObjects.Add(new Land(1270, 520, 50, 200));
            //also+3
            MapObjects.Add(new Land(700, 350, 50, 150));
            MapObjects.Add(new Land(1070, 350, 50, 150));
            
        }

    }
}
