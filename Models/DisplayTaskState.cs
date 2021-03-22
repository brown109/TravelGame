using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class DisplayTaskState : ObservableObject
    {
        private string[] _city;
        private string[] _didyoueat;
        private string[] _didyoudrink;
        private string[] _didyoutour;
        private string[] _didyoubattle1;
        private string[] _didyoubattle2;

        public string[] City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string[] DidYouEat
        {
            get { return _didyoueat; }
            set { _didyoueat = value; }
        }
        public string[] DidYouDrink
        {
            get { return _didyoudrink; }
            set { _didyoudrink = value; }
        }
        public string[] DidYouTour
        {
            get { return _didyoutour; }
            set { _didyoutour = value; }
        }
        public string[] DidYouBattle1
        {
            get { return _didyoubattle1; }
            set { _didyoubattle1 = value; }
        }
        public string[] DidYouBattle2
        {
            get { return _didyoubattle2; }
            set { _didyoubattle2 = value; }
        }
        public DisplayTaskState()
        {

        }
        public DisplayTaskState(string[] city, string[] didyoueat, string[] didyoudrink, string[] didyoutour, string[] didyoubattle1, string[] didyoubattle2)
        {
            _city = city;
            _didyoueat = didyoueat;
            _didyoudrink = didyoudrink;
            _didyoutour = didyoutour;
            _didyoubattle1 = didyoubattle1;
            _didyoubattle2 = didyoubattle2;
        }
    }
}
