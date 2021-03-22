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
        private List<LocationItems> _locationItems;
        private List<TaskState> _taskStates;
        private Location _currentLocation;
        private LocationItems _currentLocationItems;
               
        public List<Location> LocationList
        {
            get { return _locations; }
            set { _locations = value; }
        }
        public List<LocationItems> LocationItemList
        {
            get { return _locationItems; }
            set { _locationItems = value; }
        }
        public List<TaskState> TaskStateList
        {
            get { return _taskStates; }
            set { _taskStates = value; }
        }
        public Location CurrentLocation
        { 
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }
        public LocationItems CurrentLocationItems
        {
            get { return _currentLocationItems; }
            set { _currentLocationItems = value; }
        }
        
        public GameMap()
        {
            _locations = new List<Location>();
            _locationItems = new List<LocationItems>();
            _taskStates = new List<TaskState>();
            _currentLocation = new Location();
            _currentLocationItems = new LocationItems();
            
        }
    }
}
