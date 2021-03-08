using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class DisplayLocationItem : ObservableObject
    {
        public string[,] _displayarea;
        public string[,] DisplayArea
        {
            get { return _displayarea; }
            set { _displayarea = value; }
        }
    }   
}
