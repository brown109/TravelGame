using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class Player : Actor
    {
        private DateTime _startDate;
        private int _experience;
        private int _bestscore;
        private double _visits;
        private double _tasks;
        private int _liveslost;
        private int _totalscore;
        private string _currentcity;
        private string _playerMessage;
        private string _gameInfo;
        private string _lastActorType;
        private string _lastActor;
        private string _lastItemType;
        private string _lastItem;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
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
        public string CurrentCity
        {
            get { return _currentcity; }
            set { _currentcity = value; }
        }
        public string PlayerMessage
        {
            get { return _playerMessage; }
            set { _playerMessage = value; }
        }
        public string GameInfo
        {
            get { return _gameInfo; }
            set { _gameInfo = value; }
        }
        public string LastActorType
        {
            get { return _lastActorType; }
            set { _lastActorType = value; }
        }
        public string LastActor
        {
            get { return _lastActor; }
            set { _lastActor = value; }
        }
        public string LastItemType
        {
            get { return _lastItemType; }
            set { _lastItemType = value; }
        }
        public string LastItem
        {
            get { return _lastItem; }
            set { _lastItem = value; }
        }
        public Player()
        {

        }
        
        public Player(DateTime startdate, int experience, int bestscore, double visits, double tasks, int liveslost, int totalscore, string currentcity, string playerMessage,
            string gameInfo, string lastActorType, string lastActor, string lastItemType, string lastItem)
        {
            _startDate = startdate;
            _experience = experience;
            _bestscore = bestscore;
            _visits = visits;
            _tasks = tasks;
            _liveslost = liveslost;
            _totalscore = totalscore;
            _currentcity = currentcity;
            _playerMessage = playerMessage;
            _gameInfo = gameInfo;
            _lastActorType = lastActorType;
            _lastActor = lastActor;
            _lastItemType = lastItemType;
            _lastItem = lastItem;
        }
        public override string TaskMessage()
        {
            return ("I'm the player so this message isn't shown");
        }
    }
}
