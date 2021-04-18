using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows;
using TravelGame.Models;
using TravelGame.Data;

namespace TravelGame.Presentation
{
    //
    // Define the primary control window (view) object
    //
    public class ControlWindowModel : ObservableObject
    {
        private DateTime _gameStartTime;
        private string _gameTimeDisplay;
        private TimeSpan _gameTime;
        private Player _player;
        private GameMap _gameMap;
        private DisplayLocationItem _currentDisplayItems;
        private DisplayTaskState _currentDisplayTasks;
        private GameHistory _gameHistory;
        //private Random _random = new Random();
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
        public string MissionTimeDisplay
        {
            get { return _gameTimeDisplay; }
            set
            {
                _gameTimeDisplay = value;
                OnPropertyChanged(nameof(MissionTimeDisplay));
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
            GameTimer();
        }

        private void InitializeView()
        {
            _gameStartTime = DateTime.Now;
        }
        //
        // Calculate difference between when the game started and now
        //
        private TimeSpan GameTime()
        {
            return DateTime.Now - _gameStartTime;
        }
        //
        // game time event, publishes every 1 second
        //
        public void GameTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += OnGameTimerTick;
            timer.Start();
        }
        //
        //  game timer event handler update elapsed time on window
        //
        void OnGameTimerTick(object sender, EventArgs e)
        {
            _gameTime = DateTime.Now - _gameStartTime;
            MissionTimeDisplay = _gameTime.ToString(@"hh\:mm\:ss");
        }
        public void CheckMove(string _direction)
        {
            //
            // When a directional button was clicked, find out what to do next
            //
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
                switch (_nextCity)
                {
                    case "New York":
                        Player.MapLocation = "/Data/europemap.jpg";
                        break;
                    case "London":
                        Player.MapLocation = "/Data/bigben.png";
                        break;
                    case "Frankfort":
                        Player.MapLocation = "/Data/frankfort.png";
                        break;
                    case "Warsaw":
                        Player.MapLocation = "/Data/warsaw.png";
                        break;
                    case "Paris":
                        Player.MapLocation = "/Data/paris.png";
                        break;
                    case "Rome":
                        Player.MapLocation = "/Data/rome.png";
                        break;
                    case "Athens":
                        Player.MapLocation = "/Data/athens.png";
                        break;
                    default:
                        Player.MapLocation = "/Data/europemap.jpg";
                        break;
                }
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
                BuildActorDisplay();
                BuildGameTaskDisplay();
            }
        }
        public void CheckDisplay(string _whatdata)
        {
            //
            // Build display areas based on button that was clicked
            //
            switch (_whatdata)
            {
                case "Actors":
                    BuildActorDisplay();
                    break;
                case "Foods":
                    Player.Totalscore -= 100;
                    OnPropertyChanged(nameof(Player));
                    BuildFoodDisplay();
                    break;
                case "Drinks":
                    Player.Totalscore -= 100;
                    OnPropertyChanged(nameof(Player));
                    BuildDrinkDisplay();
                    break;
                case "Sites":
                    Player.Totalscore -= 100;
                    OnPropertyChanged(nameof(Player));
                    BuildSiteDisplay();
                    break;
                case "Game Tasks":
                    BuildGameTaskDisplay();
                    break;
                case "City Tasks":
                    BuildCityTaskDisplay();
                    break;
                case "Top Scores":
                    BuildTopScoreDisplay();
                    break;
                case "My Scores":
                    BuildMyScoreDisplay();
                    break;
                case "Hints":
                    Player.Totalscore -= 400;
                    OnPropertyChanged(nameof(Player));
                    BuildHintsDisplay();
                    break;
                default:
                    break;
            }
        }
        public void CheckCommand(string _command)
        {
            //
            // here we will analyze the command. We look for name, action (i.e. eat, battle, etc.) and item (the specific food, drink, etc.)
            // sample command "John, pour me a gin and tonic" 
            //
            Player.GameInfo = "";
            Player.PlayerMessage = "";
            OnPropertyChanged(nameof(Player));
            bool validinput = true;
            if (_command == null || _command == "")
            {
                Player.PlayerMessage = "You need to enter a command";
                validinput = false;
            }
            if (!validinput)
            {
                Player.Totalscore -= 3;
                OnPropertyChanged(nameof(Player));
            }
            else
            {
                //
                // find out what actor was selected and what was their type
                // parse the command
                //
                bool stillvalid = CheckAction(_command, _gameMap.Npcs, _gameMap.Items);
                if (stillvalid)
                {
                    CompleteTask(GameMap);
                }
                OnPropertyChanged(nameof(Player));
                OnPropertyChanged(nameof(GameMap));
            }
        }
        private bool CheckAction(string _command, List<Npc> npcs, List<Item> items)
        {
            int i;
            bool isnamefound = false;
            string foundname = "";
            string foundactortype = "";
            string searchitemtype = "";
            bool isactionfound = false;
            bool isitemfound = false;
            string founditem = "";
            bool isitemvalid = false;
            bool wantahint;
            string msg;
            //
            // see if the command has a matching name for the npcs in the current city and when you 
            // find that, see if the command has a matching action for for the type of actor.
            // if it does, and you haven't already Ided the actor, you have now so you get those points
            // The following code is targeted for refactoring in the next build
            //
            wantahint = (_command.Contains("Hint") || _command.Contains("hint"));
            foreach (Npc npc in npcs)
            {
                if (npc.City == Player.CurrentCity)
                {
                    if (!isnamefound)
                    {
                        isnamefound = _command.Contains(npc.Name);
                        if (isnamefound)
                        {
                            foundname = npc.Name;
                            foundactortype = npc.ActorType.ToString();
                            if (wantahint)
                            {
                                if (foundactortype == "InterloperMajor" || foundactortype == "InterloperMinor")
                                {
                                    Player.Totalscore -= 50;
                                    Player.GameInfo = "You 'defend' a minor interloper and 'attack a major interloper. ";
                                    Player.GameInfo += "Hint for " + npc.Name + " is " + npc.HintPhrase;
                                    Player.GameInfo += " BTW - this hint cost you 50 points.";
                                }
                                else
                                {
                                    Player.Totalscore -= 10;
                                    Player.GameInfo = "No hints for this actor because they are not an interloper.";
                                    Player.GameInfo += "You should check Food, Drink & Site Display."; 
                                    Player.GameInfo += " BTW - this cost you 10 points.";
                                }
                            }
                            else
                            {
                                for (i = 0; i < npc.KeyWords.Length; ++i)
                                {
                                    if (!isactionfound)
                                    {
                                        isactionfound = _command.Contains(npc.KeyWords[i]);
                                        if (isactionfound)
                                        {
                                            if (!npc.IsIded)
                                            {
                                                npc.IsIded = true;
                                                msg = npc.City + " " + npc.Name + " Ided as " + npc.ActorType.ToString() + " (" + npc.IdPoints + ")";
                                                CreateHistory(msg);
                                                Player.Totalscore += npc.IdPoints;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (wantahint)
            {
                return false;
            }
            if (!isnamefound)
            {
                Player.PlayerMessage = "No Actor's name (-5)";
                Player.Totalscore -= 5;
                return false;
            }
            if (!isactionfound)
            {
                Player.PlayerMessage = "Actor doesn't do what you asked (-15)";
                Player.Totalscore -= 15;
                return false;
            }
            Player.LastActor = foundname;
            // 
            // at this point, you have Ided the actor so now we need to see if you have a valid item (drink, site, food)
            // 
            if (foundactortype == "Driver") { searchitemtype = "Site"; };
            if (foundactortype == "Chef") { searchitemtype = "Food"; };
            if (foundactortype == "Bartender") { searchitemtype = "Drink"; };
            if (foundactortype == "InterloperMinor") { searchitemtype = "BattleMinor"; };
            if (foundactortype == "InterloperMajor") { searchitemtype = "BattleMajor"; };
            foreach (Item item in items)
            {
                for (i = 0; i < item.KeyWords.Length; ++i)
                {
                    if (!isitemfound)
                    {
                        isitemfound = _command.Contains(item.KeyWords[i]);
                        if (isitemfound)
                        {
                            if (item.City == Player.CurrentCity && item.Type.ToString() == searchitemtype)
                            {
                                isitemvalid = true;
                                founditem = item.Name;
                            }
                        }
                    }
                }
            }
            BuildActorDisplay();
            if (!isitemfound && isactionfound)
            {
                Player.PlayerMessage = "Actor Ided, but not an item (-5)";
                Player.Totalscore -= 5;
                return false;
            }
            if (!isitemfound)
            {
                Player.PlayerMessage = "You don't have a valid item (-8)";
                Player.Totalscore -= 8;
                return false;
            }
            if (!isitemvalid)
            {
                Player.PlayerMessage = "Good item, but not for this actor or city (-2)";
                Player.Totalscore -= 2;
                return false;
            }
            //
            // good news, you have a completed task
            //
            Player.LastItemType = searchitemtype;
            Player.LastItem = founditem;
            return true;
        }
        public Location FindLocation(string _nextCity)
        {
            //
            // Find the city being moved to in the list of locations
            //
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
        public void BuildActorDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "  Actor      Greeting               Status";
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildActorStatusDisplay(GameMap.Npcs);
            }
            OnPropertyChanged(nameof(CurrentDisplayItems));
        }
        public void BuildFoodDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Food                  Message     Status";
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildFoodItemDisplay(GameMap.Items);
            }
            OnPropertyChanged(nameof(CurrentDisplayItems));
        }
        public void BuildDrinkDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Drink                 Message     Status";
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildDrinkItemDisplay(GameMap.Items);
            }
            OnPropertyChanged(nameof(CurrentDisplayItems));
        }
        public void BuildSiteDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Site                  Message     Status";
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildSiteItemDisplay(GameMap.Items);
            }
            OnPropertyChanged(nameof(CurrentDisplayItems));
        }
        public void BuildGameTaskDisplay()
        {
            DisplayTaskState displayTaskState = new DisplayTaskState();
            CurrentDisplayTasks = displayTaskState;
            CurrentDisplayTasks = BuildTaskDisplay(GameMap.Items);
            OnPropertyChanged(nameof(CurrentDisplayTasks));
        }
        public void BuildCityTaskDisplay()
        {
            DisplayTaskState displayTaskState = new DisplayTaskState();
            CurrentDisplayTasks = displayTaskState;
            CurrentDisplayTasks = BuildCityDisplay(GameMap.TaskHistoryList);
            OnPropertyChanged(nameof(CurrentDisplayTasks));
        }
        public void BuildTopScoreDisplay()
        {
            DisplayTaskState displayTaskState = new DisplayTaskState();
            CurrentDisplayTasks = displayTaskState;
            CurrentDisplayTasks = BuildTopScores(GameMap.GameStats);
            OnPropertyChanged(nameof(CurrentDisplayTasks));
        }
        public void BuildMyScoreDisplay()
        {
            DisplayTaskState displayTaskState = new DisplayTaskState();
            CurrentDisplayTasks = displayTaskState;
            CurrentDisplayTasks = BuildMyScores(GameMap.GameStats);
            OnPropertyChanged(nameof(CurrentDisplayTasks));
        }
        public void BuildHintsDisplay()
        {
            DisplayTaskState displayTaskState = new DisplayTaskState();
            CurrentDisplayTasks = displayTaskState;
            CurrentDisplayTasks = BuildHints(GameMap.Npcs);
            OnPropertyChanged(nameof(CurrentDisplayTasks));
        }
        public DisplayLocationItem BuildActorStatusDisplay(List<Npc> showactors)
        {
            //
            // cycle thru NPC list for actors in the current city to show status
            //
            int i = 0;
            string msg;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "  Actor      Greeting               Status";
            foreach (Npc npc in showactors)
            {
                if (npc.City == Player.CurrentCity)
                {
                    msg = npc.Name.PadRight(10) + " " + npc.TaskMessage().PadRight(24);
                    if (npc.IsIded && npc.IsComplete)
                    {
                        msg += "IDed, Done";
                    }
                    else if (npc.IsComplete)
                    {
                        msg += " Done";
                    }
                    else if (npc.IsIded)
                    {
                        msg += " IDed";
                    }
                    else
                    {
                        msg += " Open";
                    }
                    displayLocationItem.DisplayLine[i + 1] = msg;
                    ++i;
                }
            }
            return displayLocationItem;
        }
        public DisplayLocationItem BuildFoodItemDisplay(List<Item> showitems)
        {
            //
            // cycle through Item list to show Food Items valid for current city. 
            //
            int i = 0;
            string msg;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Food                  Message     Status";
            foreach (Item item in showitems)
            {
                if (item.City == Player.CurrentCity && item.Type.ToString() == "Food")
                {
                    msg = item.Name.PadRight(22);
                    if (item.Servings < item.Limit)
                    {
                        msg += " Try it Again? ";
                    }
                    else
                    {
                        msg += " That's Enough ";
                    }
                    if (item.Servings > 0)
                    {
                        msg += " Eaten";
                    }
                    else
                    {
                        msg += " Open";
                    }
                    displayLocationItem.DisplayLine[i + 1] = msg;
                    ++i;
                }
            }
            return displayLocationItem;
        }
        public DisplayLocationItem BuildDrinkItemDisplay(List<Item> showitems)
        {
            //
            // cycle through Item list to show Drink Items valid for current city.
            //
            int i = 0;
            string msg;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Drink                 Message     Status";
            foreach (Item item in showitems)
            {
                if (item.City == Player.CurrentCity && item.Type.ToString() == "Drink")
                {
                    msg = item.Name.PadRight(22);
                    if (item.Servings < item.Limit)
                    {
                        msg += " Try it Again? ";
                    }
                    else
                    {
                        msg += " That's Enough ";
                    }
                    if (item.Servings > 0)
                    {
                        msg += " Drank";
                    }
                    else
                    {
                        msg += " Open";
                    }
                    displayLocationItem.DisplayLine[i + 1] = msg;
                    ++i;
                }
            }
            return displayLocationItem;
        }
        public DisplayLocationItem BuildSiteItemDisplay(List<Item> showitems)
        {
            //
            // cycle through Item list to show Drink Items valid for current city.
            //
            int i = 0;
            string msg;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Site                  Message     Status";
            foreach (Item item in showitems)
            {
                if (item.City == Player.CurrentCity && item.Type.ToString() == "Site")
                {
                    msg = item.Name.PadRight(22);
                    if (item.Servings < item.Limit)
                    {
                        msg += " Try it Again? ";
                    }
                    else
                    {
                        msg += " That's Enough ";
                    }
                    if (item.Servings > 0)
                    {
                        msg += " Seen";
                    }
                    else
                    {
                        msg += " Open";
                    }
                    displayLocationItem.DisplayLine[i + 1] = msg;
                    ++i;
                }
            }
            return displayLocationItem;
        }
        public DisplayTaskState BuildTaskDisplay(List<Item> items)
        {
            //
            // cycle through all items to show task complete (yes/no) for each city and each actor (you complete a task with an
            // actor by having at least one interaction with the actor's type and item type (chefs & food, drivers and sites,
            // minor interlopers and a defense). A complete interaction has Item.Servings > 0.
            //
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.DisplayLine = new string[21];
            displayTaskState.DisplayLine[0] = "   City       Ate   Drank  Toured Defend  Attack";
            int i = 0;
            string citybreak = "xxx";
            string msg = "";
            bool firstitem = true;
            bool ate = false;
            bool drank = false;
            bool toured = false;
            bool war1 = false;
            bool war2 = false;
            foreach (Item item in items)
            {
                if (firstitem)
                {
                    citybreak = item.City;
                    firstitem = false;
                }
                if (item.City == citybreak)
                {
                    if (item.Servings > 0)
                    {
                        if (item.Type.ToString() == "Food") { ate = true; }
                        else if (item.Type.ToString() == "Drink") { drank = true; }
                        else if (item.Type.ToString() == "Site") { toured = true; }
                        else if (item.Type.ToString() == "BattleMinor") { war1 = true; }
                        else if (item.Type.ToString() == "BattleMajor") { war2 = true; }
                    }
                }
                else
                {
                    if (item.City != "New York")
                    {
                        msg = citybreak.PadRight(10);
                        if (ate) { msg += "   Yes  "; }
                        else { msg += "    No  "; }
                        if (drank) { msg += "  Yes   "; }
                        else { msg += "   No   "; }
                        if (toured) { msg += "  Yes  "; }
                        else { msg += "   No  "; }
                        if (war1) { msg += "  Yes  "; }
                        else { msg += "   No  "; }
                        if (war2) { msg += "   Yes  "; }
                        else { msg += "    No  "; }
                        displayTaskState.DisplayLine[i + 1] = msg;
                        ++i;                        
                        displayTaskState.DisplayLine[i + 1] = " ";
                        ++i;
                        citybreak = item.City;
                        ate = false;
                        drank = false;
                        toured = false;
                        war1 = false;
                        war2 = false;
                    }
                }
            }
            msg = citybreak.PadRight(10);
            if (ate) { msg += "   Yes  "; }
            else { msg += "    No  "; }
            if (drank) { msg += "  Yes  "; }
            else { msg += "   No  "; }
            if (toured) { msg += "   Yes  "; }
            else { msg += "    No  "; }
            if (war1) { msg += "  Yes  "; }
            else { msg += "   No  "; }
            if (war2) { msg += "   Yes  "; }
            else { msg += "    No  "; }
            displayTaskState.DisplayLine[i + 1] = msg;
            return displayTaskState;
        }
        public DisplayTaskState BuildCityDisplay(List<TaskHistory> showtasks)
        {
            //
            // Build display of TaskHistory showing last entry first - showtask.Reverse() 
            //
            showtasks.Reverse();
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.DisplayLine = new string[21];
            int i = 0;
            foreach (TaskHistory taxhistory in showtasks)
            {
                if (i < 21)
                {
                    displayTaskState.DisplayLine[i] = taxhistory.Task;
                    ++i;
                }
            }
            //
            // put the tasks back in the order that they were before you started
            //
            showtasks.Reverse();
            return displayTaskState;
        }
        public DisplayTaskState BuildTopScores(List<GameStat> gameStats)
        {
            //
            // All past games are loaded in to a List of GameStat. Sort the list by score descending and display each score.  
            // Only the top 21 scores are display and past game scores are hard-coded. A future sprint will save completed 
            // games in a file and then pull in the scores from that file.
            //
            string msg;
            var newList = gameStats.OrderByDescending(GameStat => GameStat.Score);
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.DisplayLine = new string[21];
            displayTaskState.DisplayLine[0] = "  Name          Start Date         Score Lost Life";
            int i = 1;
            foreach (GameStat gamestat in newList)
            {
                if (i < 21)
                {
                    msg = gamestat.Name.PadRight(13) + " " + gamestat.Startdate.ToString().PadRight(20) + " " + gamestat.Score.ToString().PadRight(8) + "    " + gamestat.Liveslost;
                    displayTaskState.DisplayLine[i] = msg;
                    ++i;
                }
            }
            return displayTaskState;
        }
        public DisplayTaskState BuildMyScores(List<GameStat> gameStats)
        {
            //
            // All past games are loaded in to a List of GameStat. This routine will cycle through that list
            // looking for an exact match on the Player Name which was entered on the initial screen when the
            // game started.   
            // Past game scores are hard-coded so you'll only see values if you use a name that matches the
            // hard-coded data. You can look at top scores to see the names of previous players and then
            // use that name when you start up.
            //
            string msg;
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.DisplayLine = new string[21];
            displayTaskState.DisplayLine[0] = "  Name          Start Date         Score Lost Life";
            int i = 1;
            foreach (GameStat gamestat in gameStats)
            {
                if (Player.Name == gamestat.Name && i < 21)
                {
                    msg = gamestat.Name.PadRight(13) + " " + gamestat.Startdate.ToString().PadRight(20) + " " + gamestat.Score.ToString().PadRight(8) + "     " + gamestat.Liveslost;
                    displayTaskState.DisplayLine[i] = msg;
                    ++i;
                }
            }
            return displayTaskState;
        }
        public DisplayTaskState BuildHints(List<Npc> npcs)
        {
            //
            // cycle through NPCs to show the Names and Interloper type so you have an idea of when to attack or defend
            //
            string msg;
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.DisplayLine = new string[21];
            int i = 0;
            foreach (Npc npc in npcs)
            {
                if (npc.ActorType.ToString() == "InterloperMinor" || npc.ActorType.ToString() == "InterloperMajor")
                {
                    if (i < 21)
                    {
                        msg = npc.Name + " is a " + npc.KeyWords[0] + " you need to ";
                        if (npc.ActorType.ToString() == "InterloperMinor")
                        {
                            msg += "defend";
                        }
                        else
                        {
                            msg += "attack";
                        }
                        displayTaskState.DisplayLine[i] = msg;
                        ++i;
                    }
                }
            }
            return displayTaskState;
        }
        public void CompleteTask(GameMap gameMap)
        {
            //
            // All the command edits passed so we know what Actor and what Item to update. There are a few ways to accrue or lose points
            // so we'll keep a running total and build messages to help detail the specifics. We'll also write Task History which is
            // an internal log of task completions.
            //
            string msg = Player.CurrentCity + " ";
            int lostlives;
            int penaltypoints;
            int pointsearned = 0;
            bool isfirstcompletion = true;
            //
            // Update Npc
            //
            foreach (Npc npc in gameMap.Npcs)
            {
                if (npc.City == Player.CurrentCity && npc.Name == Player.LastActor)
                {
                    //
                    // The game requires that you only eat 1 item per city, drink 1 item per city and see 1 site per city. You can do more
                    // eating, drinking, and sightseeing but you can only get Npc completion points once. so we need to know later if this
                    // interaction was already complete
                    //
                    if (isfirstcompletion && npc.IsComplete) { isfirstcompletion = false; };
                    //
                    // polymorphism used to determine lives lost for an Npc
                    //
                    lostlives = npc.CheckForLifeLost();
                    if (lostlives > 0)
                    {
                        Player.Liveslost += lostlives;
                        pointsearned -= 500;
                        Player.GameInfo += "Bad Break. There's bad people out there. You lose a life and 500 points. ";
                    }
                    else
                    {
                        if (isfirstcompletion)
                        {
                            pointsearned += npc.CompletionPoints;
                            Player.GameInfo += "You just earned " + npc.CompletionPoints + " interacting with " + npc.Name + " ";
                        }
                    }
                    //
                    // If you didn't lose your life, you might have endured some stress. Using polymorphism to determine any random penalties for an Npc
                    //
                    if (lostlives == 0)
                    {
                        penaltypoints = npc.CheckForPenalty();
                        if (penaltypoints > 0)
                        {
                            pointsearned -= penaltypoints;
                            Player.GameInfo += "Travel is stressful. " + "As a result, you just lost " + penaltypoints + " points.";
                        }
                        else
                        {
                            Player.GameInfo += " No stress from " + npc.Name + " ";
                        }
                    }
                    //
                    // no matter what happened, you finished a task.
                    //
                    npc.IsComplete = true;
                }
            }
            //
            // Update Item. Find it, check to see if this would take you over the limit else, see if you randomly lose a life or lose points.
            //
            foreach (Item item in gameMap.Items)
            {
                if (item.City == Player.CurrentCity && item.Name == Player.LastItem)
                {
                    if (item.Servings == item.Limit)
                    {
                        msg += "Oops, you overindulged ";
                        Player.PlayerMessage = "Oops, you overindulged and will lose 200 points";
                        pointsearned -= 200;
                    }
                    else
                    {
                        ++item.Servings;
                        msg += item.BuildItemMessage();
                        pointsearned += item.Points;
                        //
                        // polymorphism used to determine lives lost for an item
                        //
                        lostlives = item.CheckForLifeLost();
                        if (lostlives > 0)
                        {
                            Player.Liveslost += lostlives;
                            pointsearned -= 500;
                            Player.GameInfo += " Really Bad Break. Sometimes the food, drink, or driving can kill you. ";
                            Player.GameInfo += "You lose a life and 500 points.";
                        }
                        else
                        {
                            Player.GameInfo += " You just earned " + item.Points + " points for the chosen item ";
                        }
                        //
                        // If you didn't lose your life, you might have endured some stress. Using polymorphism to determine any random penalties for an Item
                        //
                        if (lostlives == 0)
                        {
                            penaltypoints = item.CheckForPenalty();
                            if (penaltypoints > 0)
                            {
                               pointsearned -= penaltypoints;
                               Player.GameInfo += " Food, Drinks and Driving around can make you sick.";
                                Player.GameInfo += " As a result, you just lost " + penaltypoints + " points.";
                            }
                            else
                            {
                                Player.GameInfo += " No stress from " + item.Name + " ";
                            }
                        }
                    }
                }
            }
            //
            // update players total score on this command accumuated thru pointsearned. Then write a TaskHistory entry
            //
            if (isfirstcompletion)
            {
                ++Player.Tasks;
            }
            Player.PlayerMessage += " Task Done";
            Player.Totalscore += pointsearned;
            msg += "(" + pointsearned + ")";
            CreateHistory(msg);
            //
            // Find out if you've finished all tasks for a city and all tasks for the game by cycling thru all Npcs to see
            // if any are not done. 
            //
            bool iscitydone = true;
            bool isalldone = true;
            foreach (Npc npc in gameMap.Npcs)
            {
                if (npc.City == Player.CurrentCity)
                {
                    if (!npc.IsComplete)
                    {
                        iscitydone = false;
                        isalldone = false;
                    }
                }
                else if (!npc.IsComplete)
                {
                    isalldone = false;
                }
            }
            if (iscitydone)
            {
                ++Player.Visits;
                Player.PlayerMessage = "You can be done with this city, Congrats";
                Player.Totalscore += 1000;
                msg = "1000 points for completing " + Player.CurrentCity + " tasks";
                CreateHistory(msg);
            }
            if (isalldone)
            {
                Player.PlayerMessage = "You Finished, Congrats";
                Player.Totalscore += 5000;
                msg = "5000 points for completing the game";
                CreateHistory(msg);
            }
            OnPropertyChanged(nameof(Player));
            //
            // Done with processing the command so re-build the Actor Display and the Game Task Display
            //
            BuildGameTaskDisplay();
            BuildActorDisplay();
        }
        public void CreateHistory(string message)
        {
            //
            // add Task History to the Task History List
            //
            TaskHistory taskHistory = new TaskHistory();
            taskHistory.Task = message;
            GameMap.TaskHistoryList.Add(taskHistory);
            OnPropertyChanged(nameof(GameMap));
        }
    }
}

