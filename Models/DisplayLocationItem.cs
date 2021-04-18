using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // several of the buttons in the game require the creation of a display of information. This is the area
    // used for all of them.
    //
    public class DisplayLocationItem : ObservableObject
    {
        private string[] _displayLine;
                
        public string[] DisplayLine
        {
            get { return _displayLine; }
            set { _displayLine = value; }
        }
        public DisplayLocationItem()
        {

        }
        public DisplayLocationItem(string[] displayLine)
        {
            _displayLine = displayLine;
        }
    }   
}
