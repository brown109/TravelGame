using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelGame.Models;
using TravelGame.Data;

namespace TravelGame.Presentation
{
    public class ControlWindowModel : ObservableObject
    {
        private Player _player;
        private WorldMap _gameMap;
        private Location _currentLocation;
        private LocationItems _currentLocationItems;
        private DisplayLocationItem _displayLocationItem;
        private GameHistory _gameHistory;


        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public WorldMap GameMap
        {
            get { return _gameMap; }
            set { _gameMap = value; }
        }
        public GameHistory GameHistory
        {
            get { return _gameHistory; }
            set { _gameHistory = value; }
        }
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
            }
        }
        public LocationItems CurrentLocationItems
        {
            get { return _currentLocationItems; }
            set
            {
                _currentLocationItems = value;
                OnPropertyChanged(nameof(CurrentLocationItems));
            }
        }
        public DisplayLocationItem DisplayLocationItems
        {
            get { return _displayLocationItem; }
            set
            {
                _displayLocationItem = value;
                OnPropertyChanged(nameof(DisplayLocationItems));
            }
        }
        public bool HasNorthLocation
        {
            get
            {
                if (GameMap.CurrentLocation.NCity != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool HasEastLocation
        {
            get
            {
                if (GameMap.CurrentLocation.ECity != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool HasWestLocation
        {
            get
            {
                if (GameMap.CurrentLocation.WCity != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool HasSouthLocation
        {
            get
            {
                if (GameMap.CurrentLocation.SCity != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool HasNWLocation
        {
            get
            {
                if (GameMap.CurrentLocation.NWCity != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool HasNELocation
        {
            get
            {
                if (GameMap.CurrentLocation.NECity != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool HasSWLocation
        {
            get
            {
                if (GameMap.CurrentLocation.SWCity != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool HasSELocation
        {
            get
            {
                if (GameMap.CurrentLocation.SECity != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public ControlWindowModel()
        {

        }
        public ControlWindowModel(
            Player player,
            WorldMap gameMap,
            GameHistory gameHistory)
        {
            _player = player;
            _gameMap = gameMap;
            _gameHistory = gameHistory;
            _currentLocation = _gameMap.CurrentLocation;
            _currentLocationItems = _gameMap.CurrentLocationItems;
            _displayLocationItem = _gameMap.DisplayLocationItems;
            InitializeView();
        }

        private void InitializeView()
        {

        }
        public void CheckMove(string _direction)
        {
            string _nextCity = "NowheresVille";
            bool ismoving = false;
            switch (_direction)
            {
                case "North":
                    if (_currentLocation.NCity.ToString() != "")
                    {
                        _nextCity = _currentLocation.NCity;
                        ismoving = true;
                    }
                    break;
                case "South":
                    if (_currentLocation.SCity.ToString() != "")
                    {
                        _nextCity = _currentLocation.SCity;
                        ismoving = true;
                    }
                    break;
                case "East":
                    if (_currentLocation.ECity.ToString() != "")
                    {
                        _nextCity = _currentLocation.ECity;
                        ismoving = true;
                    }
                    break;
                case "West":
                    if (_currentLocation.WCity.ToString() != "")
                    {
                        _nextCity = _currentLocation.WCity;
                        ismoving = true;
                    }
                    break;
                case "NorthWest":
                    if (_currentLocation.NWCity.ToString() != "")
                    {
                        _nextCity = _currentLocation.NWCity;
                        ismoving = true;
                    }
                    break;
                case "SouthWest":
                    if (_currentLocation.SWCity.ToString() != "")
                    {
                        _nextCity = _currentLocation.SWCity;
                        ismoving = true;
                    }
                    break;
                case "NorthEast":
                    if (_currentLocation.NECity.ToString() != "")
                    {
                        _nextCity = _currentLocation.NECity;
                        ismoving = true;
                    }
                    break;
                case "SouthEast":
                    if (_currentLocation.SECity.ToString() != "")
                    {
                        _nextCity = _currentLocation.SECity;
                        ismoving = true;
                    }
                    break;
                default:
                    break;
            }
            if (ismoving)
            {

                GameMap.CurrentLocation = FindLocation(_nextCity);
                _currentLocation = GameMap.CurrentLocation;
                OnPropertyChanged(nameof(GameMap.CurrentLocation));
                OnPropertyChanged(nameof(HasNorthLocation));
                OnPropertyChanged(nameof(HasSouthLocation));
                OnPropertyChanged(nameof(HasEastLocation));
                OnPropertyChanged(nameof(HasWestLocation));
                OnPropertyChanged(nameof(HasNELocation));
                OnPropertyChanged(nameof(HasNWLocation));
                OnPropertyChanged(nameof(HasSELocation));
                OnPropertyChanged(nameof(HasSWLocation));


                GameMap.CurrentLocationItems = FindLocationItems(_nextCity);
                _currentLocationItems = GameMap.CurrentLocationItems;
                //BuildItemDisplay(GameMap.DisplayLocationItems.DisplayArea);
                //_displayLocationItem = GameMap.DisplayLocationItems;
            }
        }
        public Location FindLocation(string _nextCity)
        {
                int i = 0;
                bool matchfound = false;
                Location _checkLocation;
                Location _resultLocation = new Location() { City = "Not in the List" };
                do
                {
                    _checkLocation = _gameMap.Locations[i];
                    if (_checkLocation.City == _nextCity)
                    {
                        matchfound = true;
                        _resultLocation = _checkLocation;
                    }
                    ++i;
                } while (!matchfound);

                return _resultLocation;
        }
        public LocationItems FindLocationItems(string _nextCity)
        {
            int i = 0;
            bool matchfound = false;
            LocationItems _checkLocationItems;
            LocationItems _resultLocationItems = new LocationItems() { City = "Not in the List" };
            do
            {
                _checkLocationItems = _gameMap.LocationItems[i];
                if (_checkLocationItems.City == _nextCity)
                {
                    matchfound = true;
                    _resultLocationItems = _checkLocationItems;
                }
                ++i;
            } while (!matchfound);

            return _resultLocationItems;
        }
        public void BuildItemDisplay(DisplayLocationItem displayLocationItem)
        {
            //
            // not working just yet
            //
            int i;
            int j;
            
            for (i = 0; i < 6; ++i)
            {
                for (j = 0; j < 3; ++j)
                {
                    GameMap.DisplayLocationItems.DisplayArea[i, j] = "";
                }
            }
            GameMap.DisplayLocationItems.DisplayArea[0,0] = "  ACTOR";
            GameMap.DisplayLocationItems.DisplayArea[0,1] = "   ROLE";
            GameMap.DisplayLocationItems.DisplayArea[0,2] = " STATUS";

            for (i=1; i<6; ++i)
            {
                GameMap.DisplayLocationItems.DisplayArea[i,0] = CurrentLocationItems.Actors[i - 1];
                GameMap.DisplayLocationItems.DisplayArea[i,1] = CurrentLocationItems.ActorTypes[i - 1].ToString();
                GameMap.DisplayLocationItems.DisplayArea[i,2] = CurrentLocationItems.IsTypeKnown[i - 1].ToString();
            }

             
        }
    }
}

