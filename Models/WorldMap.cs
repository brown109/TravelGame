using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class WorldMap
    {
        private List<Location> _locations;
        private List<LocationItems> _locationItems;
        private Location _currentLocation;
        private LocationItems _currentLocationItems;
        private DisplayLocationItem _displayLocationItem;
       
        public List<Location> Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }
        public List<LocationItems> LocationItems
        {
            get { return _locationItems; }
            set { _locationItems = value; }
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
        public DisplayLocationItem DisplayLocationItems
        {
            get { return _displayLocationItem; }
            set { _displayLocationItem = value; }
        }
        public WorldMap()
        {
            _locations = new List<Location>();
            _locationItems = new List<LocationItems>();
            _displayLocationItem = new DisplayLocationItem();
        }
    }
}
