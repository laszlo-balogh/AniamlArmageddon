using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Animal_Armageddon.UIModels
{
    public class Skin : ObservableObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private string root;

        public string Root
        {
            get { return root; }
            set { SetProperty(ref root, value); }
        }

        private string color;        
        public string Color
        {
            get { return color; }
            set { SetProperty(ref color, value); }
        }



    }
}
