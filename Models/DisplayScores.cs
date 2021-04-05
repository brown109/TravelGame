using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class DisplayScores : ObservableObject
    {
        private string[] _displayScoreLine;
                
        public string[] DisplayScoreLine
        {
            get { return _displayScoreLine; }
            set { _displayScoreLine = value; }
        }
        
        public DisplayScores()
        {

        }
        public DisplayScores(string[] displayScoreLine)
        {
            _displayScoreLine = displayScoreLine;
            
        }
    }
}
