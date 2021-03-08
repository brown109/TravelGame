using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class GameStat
    {
        private string _name;
        private DateTime _startdate;

        private DateTime _enddate;
        private int _score;
        private int _liveslost;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime Startdate
        {
            get { return _startdate; }
            set { _startdate = value; }
        }
        public DateTime Enddate
        {
            get { return _enddate; }
            set { _enddate = value; }
        }
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public int Liveslost
        {
            get { return _liveslost; }
            set { _liveslost = value; }
        }
        public GameStat()
        { 
        
        }
        public GameStat(string Name, DateTime StartDate, DateTime EndDate, int Score, int Liveslost)
        {
            _name = Name;
            _startdate = StartDate;
            _enddate = EndDate;
            _score = Score;
            _liveslost = Liveslost;
        }
        
    }
}
