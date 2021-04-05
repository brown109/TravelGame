using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class GameMap : ObservableObject
    {
        private List<Location> _locations;
        private List<Npc> _npcs;
        private List<Item> _items;
        private List<TaskHistory> _taskHistoryList;
        private List<GameStat> _gameStats;
        private Location _currentLocation;
        
        public List<Location> LocationList
        {
            get { return _locations; }
            set { _locations = value; }
        }
        //public List<LocationItems> LocationItemList
        //{
        //    get { return _locationItems; }
        //    set { _locationItems = value; }
        //}
        public List<Npc> Npcs
        {
            get { return _npcs; }
            set { _npcs = value; }
        }
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public List<TaskHistory> TaskHistoryList
        {
            get { return _taskHistoryList; }
            set { _taskHistoryList = value; }
        }
        public List<GameStat> GameStats
        {
            get { return _gameStats; }
            set { _gameStats = value; }
        }
        public Location CurrentLocation
        { 
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }
        public GameMap()
        {
            _locations = new List<Location>();
            _npcs = new List<Npc>();
            _items = new List<Item>();
            _taskHistoryList = new List<TaskHistory>();
            _gameStats = new List<GameStat>();
            _currentLocation = new Location();
        }
    }
}
