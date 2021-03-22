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
        private GameMap _gameMap;
        //private Location _currentLocation;
        //private LocationItems _currentLocationItems;
        private DisplayLocationItem _currentDisplayItems;
        private DisplayTaskState _currentDisplayTasks;
        private GameHistory _gameHistory;


        public Player Player
        {
            get { return _player; }
            set { _player = value;
                OnPropertyChanged(nameof(Player));
            }
        }

        public GameMap GameMap
        {
            get { return _gameMap; }
            set { _gameMap = value;
                OnPropertyChanged(nameof(GameMap));
            }
        }
        public GameHistory GameHistory
        {
            get { return _gameHistory; }
            set { _gameHistory = value; }
        }
        public DisplayLocationItem CurrentDisplayItems
        {
            get { return _currentDisplayItems; }
            set
            {
                _currentDisplayItems = value;
                OnPropertyChanged(nameof(CurrentDisplayItems));
            }
        }
        public DisplayTaskState CurrentDisplayTasks
        {
            get { return _currentDisplayTasks; }
            set
            {
                _currentDisplayTasks = value;
                OnPropertyChanged(nameof(CurrentDisplayTasks));
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
            GameMap gameMap,
            DisplayLocationItem displayLocationItem,
            DisplayTaskState displayTaskState,
            GameHistory gameHistory)
        {
            _player = player;
            _gameMap = gameMap;
            _currentDisplayItems = displayLocationItem;
            _currentDisplayTasks = displayTaskState;
            _gameHistory = gameHistory;
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
                    if (_gameMap.CurrentLocation.NCity.ToString() != "")
                    {
                        _nextCity = _gameMap.CurrentLocation.NCity;
                        ismoving = true;
                    }
                    break;
                case "South":
                    if (_gameMap.CurrentLocation.SCity.ToString() != "")
                    {
                        _nextCity = _gameMap.CurrentLocation.SCity;
                        ismoving = true;
                    }
                    break;
                case "East":
                    if (_gameMap.CurrentLocation.ECity.ToString() != "")
                    {
                        _nextCity = _gameMap.CurrentLocation.ECity;
                        ismoving = true;
                    }
                    break;
                case "West":
                    if (_gameMap.CurrentLocation.WCity.ToString() != "")
                    {
                        _nextCity = _gameMap.CurrentLocation.WCity;
                        ismoving = true;
                    }
                    break;
                case "NorthWest":
                    if (_gameMap.CurrentLocation.NWCity.ToString() != "")
                    {
                        _nextCity = _gameMap.CurrentLocation.NWCity;
                        ismoving = true;
                    }
                    break;
                case "SouthWest":
                    if (_gameMap.CurrentLocation.SWCity.ToString() != "")
                    {
                        _nextCity = _gameMap.CurrentLocation.SWCity;
                        ismoving = true;
                    }
                    break;
                case "NorthEast":
                    if (_gameMap.CurrentLocation.NECity.ToString() != "")
                    {
                        _nextCity = _gameMap.CurrentLocation.NECity;
                        ismoving = true;
                    }
                    break;
                case "SouthEast":
                    if (_gameMap.CurrentLocation.SECity.ToString() != "")
                    {
                        _nextCity = _gameMap.CurrentLocation.SECity;
                        ismoving = true;
                    }
                    break;
                default:
                    break;
            }
            if (ismoving)
            {

                Player.Totalscore -= 10;
                Player.CurrentCity = _nextCity;
                OnPropertyChanged(nameof(Player));
                GameMap.CurrentLocation = FindLocation(_nextCity);
                //_currentLocation = GameMap.CurrentLocation;
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
                //_currentLocationItems = GameMap.CurrentLocationItems;
                OnPropertyChanged(nameof(GameMap.CurrentLocationItems));
                BuildActorDisplay();
                BuildGameTaskDisplay();
                
            }
        }
        public void CheckDisplay(string _whatdata)
        {

            switch (_whatdata)
            {
                case "Actors":
                    BuildActorDisplay();
                    break;
                case "Foods":
                    BuildFoodDisplay();
                    break;
                case "Drinks":
                    BuildDrinkDisplay();
                    break;
                case "Sites":
                    BuildSiteDisplay();
                    break;
                case "Game Tasks":
                    BuildGameTaskDisplay();
                    break;
                case "City Tasks":
                    BuildCityTaskDisplay();
                    break;
                default:
                    break;
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
                _checkLocation = _gameMap.LocationList[i];
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
                _checkLocationItems = _gameMap.LocationItemList[i];
                if (_checkLocationItems.City == _nextCity)
                {
                    matchfound = true;
                    _resultLocationItems = _checkLocationItems;
                }
                ++i;
                if (i > 6)
                {
                    matchfound = true;
                }
            } while (!matchfound);

            return _resultLocationItems;
        }
        public void BuildActorDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.Item = new string[6] { "  Actor", "", "", "", "", "" };
            displayLocationItem.Description = new string[6] { "Specialty", "", "", "", "", "" };
            displayLocationItem.Status = new string[6] { " Status", "", "", "", "", "" };
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildItemDisplay(GameMap.CurrentLocationItems);
                
            }
            OnPropertyChanged(nameof(CurrentDisplayItems));
            
        }
        public void BuildFoodDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.Item = new string[6] { "  Food", "", "", "", "", "" };
            displayLocationItem.Description = new string[6] { "Order", "", "", "", "", "" };
            displayLocationItem.Status = new string[6] { " Status", "", "", "", "", "" };
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildFoodItemDisplay(GameMap.CurrentLocationItems);

            }
            OnPropertyChanged(nameof(CurrentDisplayItems));

        }
        public void BuildDrinkDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.Item = new string[6] { " Drinks", "", "", "", "", "" };
            displayLocationItem.Description = new string[6] { "Order", "", "", "", "", "" };
            displayLocationItem.Status = new string[6] { " Status", "", "", "", "", "" };
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildDrinkItemDisplay(GameMap.CurrentLocationItems);

            }
            OnPropertyChanged(nameof(CurrentDisplayItems));

        }
        public void BuildSiteDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.Item = new string[6] { "  Sites", "", "", "", "", "" };
            displayLocationItem.Description = new string[6] { "Order", "", "", "", "", "" };
            displayLocationItem.Status = new string[6] { " Status", "", "", "", "", "" };
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildSiteItemDisplay(GameMap.CurrentLocationItems);

            }
            OnPropertyChanged(nameof(CurrentDisplayItems));

        }
        public void BuildGameTaskDisplay()
        {
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.City = new string[7] { "  City", "", "", "", "", "", "" };
            displayTaskState.DidYouEat = new string[7] { "Ate", "No", "No", "No", "No", "No", "No" };
            displayTaskState.DidYouDrink = new string[7] { "Drank", "No", "No", "No", "No", "No", "No" };
            displayTaskState.DidYouTour = new string[7] { "Toured", "No", "No", "No", "No", "No", "No" };
            displayTaskState.DidYouBattle1 = new string[7] { "War 1", "No", "No", "No", "No", "No", "No" };
            displayTaskState.DidYouBattle2 = new string[7] { "War 2", "No", "No", "No", "No", "No", "No" };
            CurrentDisplayTasks = displayTaskState;
            CurrentDisplayTasks = BuildTaskDisplay(GameMap.TaskStateList);
            OnPropertyChanged(nameof(CurrentDisplayTasks));
        }
        public void BuildCityTaskDisplay()
        {
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.City = new string[7] { "  Actor", "", "", "", "", "", "" };
            displayTaskState.DidYouEat = new string[7] { "Action", "", "", "", "", "", "" };
            displayTaskState.DidYouDrink = new string[7] { "", "", "", "", "", "", "" };
            displayTaskState.DidYouTour = new string[7] { "Desc", "", "", "", "", "", "" };
            displayTaskState.DidYouBattle1 = new string[7] { "", "", "", "", "", "", "" };
            displayTaskState.DidYouBattle2 = new string[7] { "", "", "", "", "", "", "" };
            CurrentDisplayTasks = displayTaskState;
            CurrentDisplayTasks = BuildCityDisplay(GameMap.TaskStateList);
            OnPropertyChanged(nameof(CurrentDisplayTasks));
        }
        public DisplayLocationItem BuildItemDisplay(LocationItems showlocationitems)
        {
            //
            // not working just yet
            //
            int i;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.Item = new string[6] { "  Actor", "", "", "", "", "" };
            displayLocationItem.Description = new string[6] { "Specialty", "", "", "", "", "" };
            displayLocationItem.Status = new string[6] { " Status", "", "", "", "", "" };

            for (i = 1; i < 6; ++i)
            {
                displayLocationItem.Item[i] = showlocationitems.Actors[i-1];
                displayLocationItem.Description[i] = showlocationitems.ActorTypes[i-1].ToString();
                displayLocationItem.Status[i] = "Open";
            }
            return displayLocationItem;
            

             
        }
        public DisplayLocationItem BuildFoodItemDisplay(LocationItems showlocationitems)
        {
            //
            // not working just yet
            //
            int i;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.Item = new string[6] { "  Food", "", "", "", "", "" };
            displayLocationItem.Description = new string[6] { "Order", "", "", "", "", "" };
            displayLocationItem.Status = new string[6] { " Status", "", "", "", "", "" };

            for (i = 1; i < 4; ++i)
            {
                displayLocationItem.Item[i] = showlocationitems.Foods[i - 1];
                displayLocationItem.Description[i] = showlocationitems.FoodOrder[i - 1].ToString();
                displayLocationItem.Status[i] = "Open";
            }
            return displayLocationItem;



        }
        public DisplayLocationItem BuildDrinkItemDisplay(LocationItems showlocationitems)
        {
            //
            // not working just yet
            //
            int i;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.Item = new string[6] { " Drinks", "", "", "", "", "" };
            displayLocationItem.Description = new string[6] { "Order", "", "", "", "", "" };
            displayLocationItem.Status = new string[6] { " Status", "", "", "", "", "" };

            for (i = 1; i < 4; ++i)
            {
                displayLocationItem.Item[i] = showlocationitems.Drinks[i - 1];
                displayLocationItem.Description[i] = showlocationitems.DrinkOrder[i - 1].ToString();
                displayLocationItem.Status[i] = "Open";
            }
            return displayLocationItem;



        }
        public DisplayLocationItem BuildSiteItemDisplay(LocationItems showlocationitems)
        {
            //
            // not working just yet
            //
            int i;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.Item = new string[6] { " Sites", "", "", "", "", "" };
            displayLocationItem.Description = new string[6] { "Order", "", "", "", "", "" };
            displayLocationItem.Status = new string[6] { " Status", "", "", "", "", "" };

            for (i = 1; i < 4; ++i)
            {
                displayLocationItem.Item[i] = showlocationitems.Sites[i - 1];
                displayLocationItem.Description[i] = showlocationitems.SiteOrder[i - 1].ToString();
                displayLocationItem.Status[i] = "Open";
            }
            return displayLocationItem;



        }
        public DisplayTaskState BuildTaskDisplay(List<TaskState> showtasks)
        {
            //
            // not working just yet
            //
            
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.City = new string[7] { "  City", "", "", "", "", "", "" };
            displayTaskState.DidYouEat = new string[7] { "Ate", "No", "No", "No", "No", "No", "No" };
            displayTaskState.DidYouDrink = new string[7] { "Drank", "No", "No", "No", "No", "No", "No" };
            displayTaskState.DidYouTour = new string[7] { "Toured", "No", "No", "No", "No", "No", "No" };
            displayTaskState.DidYouBattle1 = new string[7] { "War 1", "No", "No", "No", "No", "No", "No" };
            displayTaskState.DidYouBattle2 = new string[7] { "War 2", "No", "No", "No", "No", "No", "No" };

            //for (i = 1; i < 6; ++i)
            //{
            //    TaskState showtask = showtasks[i - 1];
            //    displayTaskState.City[i] = showtask.City; 

            //    displayLocationItem.Description[i] = showlocationitems.ActorTypes[i - 1].ToString();
            //    displayLocationItem.Status[i] = "Open";
            //}

            int i = 0;
            foreach (TaskState taxstate in showtasks)
            {
                if (taxstate.City != "New York")
                {
                    displayTaskState.City[i + 1] = taxstate.City;
                    if (taxstate.Ate) { displayTaskState.DidYouEat[i + 1] = "Yes";  };
                    if (taxstate.Drank) { displayTaskState.DidYouDrink[i + 1] = "Yes"; };
                    if (taxstate.Toured) { displayTaskState.DidYouTour[i + 1] = "Yes"; };
                    if (taxstate.Challenge1done) { displayTaskState.DidYouBattle1[i + 1] = "Yes"; };
                    if (taxstate.Challenge2done) { displayTaskState.DidYouBattle2[i + 1] = "Yes"; };
                    ++i;
                }
            }


            return displayTaskState;
        }
        public DisplayTaskState BuildCityDisplay(List<TaskState> showtasks)
        {
            //
            // not working just yet. Need to pass different data for building display
            //

            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.City = new string[7] { " Actor", "", "", "", "", "", "" };
            displayTaskState.DidYouEat = new string[7] { "Action", "", "", "", "", "", "" };
            displayTaskState.DidYouDrink = new string[7] { "", "", "", "", "", "", "" };
            displayTaskState.DidYouTour = new string[7] { "Desc", "", "", "", "", "", "" };
            displayTaskState.DidYouBattle1 = new string[7] { "", "", "", "", "", "", "" };
            displayTaskState.DidYouBattle2 = new string[7] { "", "", "", "", "", "", "" };

            int i = 0;
            foreach (TaskState taxstate in showtasks)
            {
                if (taxstate.City != "New York")
                {
                    displayTaskState.City[i + 1] = "A " + taxstate.City;
                    if (taxstate.Ate) { displayTaskState.DidYouEat[i + 1] = "Yes"; };
                    if (taxstate.Drank) { displayTaskState.DidYouDrink[i + 1] = "Yes"; };
                    if (taxstate.Toured) { displayTaskState.DidYouTour[i + 1] = "Yes"; };
                    if (taxstate.Challenge1done) { displayTaskState.DidYouBattle1[i + 1] = "Yes"; };
                    if (taxstate.Challenge2done) { displayTaskState.DidYouBattle2[i + 1] = "Yes"; };
                    ++i;
                }
            }


            return displayTaskState;
        }
    }
}

