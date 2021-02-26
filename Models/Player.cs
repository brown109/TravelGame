using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class Player : ObservableObject
    {
        private string _name;
        private int _experience;
        private int _bestscore;
        private double _visits;
        private double _tasks;
        private int _liveslost;
        private int _totalscore;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }
        public int Bestscore
        {
            get { return _bestscore; }
            set { _bestscore = value; }
        }
        public double Visits
        {
            get { return _visits; }
            set { _visits = value; }
        }
        public double Tasks
        {
            get { return _tasks; }
            set { _tasks = value; }
        }
        public int Liveslost
        {
            get { return _liveslost; }
            set { _liveslost = value; }
        }
        public int Totalscore
        {
            get { return _totalscore; }
            set { _totalscore = value; }
        }
        public Player()
        {

        }
        
        public Player(string name, int experience, int bestscore, double visits, double tasks, int liveslost, int totalscore)
        {
            _name = name;
            _experience = experience;
            _bestscore = bestscore;
            _visits = visits;
            _tasks = tasks;
            _liveslost = liveslost;
            _totalscore = totalscore;
        }

    }
}
