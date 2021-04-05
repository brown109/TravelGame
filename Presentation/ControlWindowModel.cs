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
                case "Top Scores":
                    BuildTopScoreDisplay();
                    break;
                default:
                    break;
            }
        }
        public void CheckCommand(string _command)
        {
            //
            // here we will analyze the comand. We look for name, action (i.e. eat, battle, etc.) and item (the specific food, drink, etc.)
            // sample command "John, pour me a gin and tonic" 
            //
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
                // find out what actor was selected
                //string _selectedtype = FindType(_row);
                //Player.LastActorType = _selectedtype;
                // need to check if the user selected an interloper
                //
                // parse the command
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
            bool foundname=false;
            string foundactortype="";
            string searchitemtype = "";
            bool foundaction = false;
            bool isitemfound = false;
            string founditem = "";
            bool validitem = false;

            // see if the command has a matching name for the npcs in the current city and when you 
            // find that, see if the command has a matching action for for the type of actor.
            // if it does, and you haven't already Ided the actor, you have now so you get those points
            //

            foreach (Npc npc in npcs)
            {
                if (npc.City == Player.CurrentCity)
                {
                    if (!foundname)
                    {
                        foundname = _command.Contains(npc.Name);
                        if (foundname) 
                        { 
                            foundactortype = npc.ActorType.ToString();
                            for (i = 0; i < npc.KeyWords.Length; ++i)
                            {
                                if (!foundaction)
                                {
                                    foundaction = _command.Contains(npc.KeyWords[i]);
                                    Player.LastActor = npc.Name;
                                    if (foundaction)
                                    {
                                        if (!npc.IsIded)
                                        {
                                            npc.IsIded = true;
                                            Player.Totalscore += npc.IdPoints;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!foundname)
            {
                Player.PlayerMessage = "Command must include an Actor's name (-5)";
                Player.Totalscore -= 5;
                return false;
            }
            if (!foundaction)
            {
                Player.PlayerMessage = "Your action doesn't match what the actor does (-15)";
                Player.Totalscore -= 15;
                return false;
            }
            // 
            // at this point, you have Ided the actor so now we need to see if you have a valid item (drink, site, food)
            // 
            if (foundactortype == "Driver") { searchitemtype = "Site"; };
            if (foundactortype == "Chef") { searchitemtype = "Food"; };
            if (foundactortype == "Bartender") { searchitemtype = "Drink"; };
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
                                validitem = true;
                                founditem = item.Name;
                            }
                        }
                    }
                }
            }
            //
            // temp code - Interlopers don't require an item
            //
            if (foundactortype == "InterloperMinor" || foundactortype == "InterloperMajor")
            {
                isitemfound = true;
                validitem = true;
                founditem = "Interloper";
            }
            BuildActorDisplay();
            if (!isitemfound && foundaction)
            {
                Player.PlayerMessage = "You IDed the Actor, but not an item (-5)";
                Player.Totalscore -= 5;
                return false;
            }
            if (!isitemfound)
            {
                Player.PlayerMessage = "You don't have a valid item (type of food, drink, etc. (-8)";
                Player.Totalscore -= 8;
                return false;
            }
            if (!validitem)
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
            displayLocationItem.DisplayLine[0] = "  Actor    Specialty      Status";
            CurrentDisplayItems = displayLocationItem;
            if (Player.CurrentCity != "New York")
            {
                CurrentDisplayItems = BuildItemDisplay(GameMap.Npcs);
                
            }
            OnPropertyChanged(nameof(CurrentDisplayItems));
            
        }
        public void BuildFoodDisplay()
        {
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Food         desc      Status";
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
            displayLocationItem.DisplayLine[0] = "   Drink        desc      Status";
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
            displayLocationItem.DisplayLine[0] = "   Site         desc      Status";
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
        public DisplayLocationItem BuildItemDisplay(List<Npc> showactors)
        {
            //
            // not working just yet - using wrong list. Use Npcs instead
            //

            int i=0;
            string msg;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "  Actor    Specialty      Status";
            foreach (Npc npc in showactors)
                {

                if (npc.City == Player.CurrentCity)
                {
                    msg = npc.Name + " Pts: " + npc.IdPoints.ToString() + "Cpts: " + npc.CompletionPoints.ToString();
                    if (npc.IsIded && npc.IsComplete)
                    {
                        msg += " ID and Done;";
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
            // not working just yet
            //
            int i=0;
            string msg;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Food         desc      Status";

            foreach (Item item in showitems)
            {

                if (item.City == Player.CurrentCity && item.Type.ToString() == "Food")
                {
                    msg = item.Name + " Pts: " + item.Points.ToString() + " Lim: " + item.Limit.ToString();
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
            // not working just yet
            //
            int i=0;
            string msg;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Drink        desc      Status";

            foreach (Item item in showitems)
            {

                if (item.City == Player.CurrentCity && item.Type.ToString() == "Drink")
                {
                    msg = item.Name + " Pts: " + item.Points.ToString() + " Lim: " + item.Limit.ToString();
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
            // not working just yet
            //
            int i=0;
            string msg;
            DisplayLocationItem displayLocationItem = new DisplayLocationItem();
            displayLocationItem.DisplayLine = new string[6];
            displayLocationItem.DisplayLine[0] = "   Site         desc      Status";

            foreach (Item item in showitems)
            {

                if (item.City == Player.CurrentCity && item.Type.ToString() == "Site")
                {
                    msg = item.Name + " Pts: " + item.Points.ToString() + " Lim: " + item.Limit.ToString();
                    if (item.Servings > 0)
                    {
                        msg += " Seen";
                    }
                    else
                    {
                        msg += " Open";
                    }
                    displayLocationItem.DisplayLine[i+1] = msg;
                    ++i;
                }
            }
            return displayLocationItem;
        }
        public DisplayTaskState BuildTaskDisplay(List<Item> items)
        {
            //
            // not working just yet
            //
            
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.DisplayLine = new string[7];
            displayTaskState.DisplayLine[0] = "   City       Ate     Drank   Toured  War 1   War 2";
            
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
                        msg = citybreak;
                        if (ate) { msg += "   Yes  "; }
                        else { msg += "    No  "; }
                        if (drank) { msg += "  Yes  "; }
                        else { msg += "   No  "; }
                        if (toured) { msg += "  Yes  "; }
                        else { msg += "   No  "; }
                        if (war1) { msg += "  Yes  "; }
                        else { msg += "   No  "; }
                        if (war2) { msg += "  Yes  "; }
                        else { msg += "   No  "; }
                        displayTaskState.DisplayLine[i + 1] = msg;
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
            msg = citybreak;
            if (ate) { msg += "   Yes  "; }
            else { msg += "    No  "; }
            if (drank) { msg += "  Yes  "; }
            else { msg += "   No  "; }
            if (toured) { msg += "  Yes  "; }
            else { msg += "   No  "; }
            if (war1) { msg += "  Yes  "; }
            else { msg += "   No  "; }
            if (war2) { msg += "  Yes  "; }
            else { msg += "   No  "; }
            displayTaskState.DisplayLine[i + 1] = msg;
            return displayTaskState;
        }
        public DisplayTaskState BuildCityDisplay(List<TaskHistory> showtasks)
        {
            //
            // Build display of TaskHistory 
            //

            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.DisplayLine = new string[10];
            int i = 0;
            foreach (TaskHistory taxhistory in showtasks)
            {
                if (i < 10)
                {
                    displayTaskState.DisplayLine[i] = taxhistory.Task;
                    ++i;
                }
            }
            
            return displayTaskState;
        }
        public DisplayTaskState BuildTopScores(List<GameStat> gameStats)
        {
            string msg;
            DisplayTaskState displayTaskState = new DisplayTaskState();
            displayTaskState.DisplayLine = new string[10];
            int i = 0;
            foreach (GameStat gamestat in gameStats)
            {
                if (i < 10)
                {
                    msg = gamestat.Name + "  " + gamestat.Startdate + "  " + gamestat.Score + "  " + gamestat.Liveslost;
                    displayTaskState.DisplayLine[i] = msg;
                    ++i;
                }
            }
            return displayTaskState;
        }
        public void CompleteTask(GameMap gameMap)
        {
            string msg = Player.CurrentCity + " ";
            
            
            
            ++Player.Tasks;
            Player.PlayerMessage = "Congrats, you completed a task";

            //
            // Update Npc
            //
            foreach (Npc npc in gameMap.Npcs)
            {
                if (npc.City == Player.CurrentCity && npc.Name == Player.LastActor)
                {
                    Player.Totalscore += npc.CompletionPoints;
                    npc.IsComplete = true;
                }
            }
            //
            // Update Item
            //
            foreach (Item item in gameMap.Items)
            {
                if (item.City == Player.CurrentCity && item.Name == Player.LastItem)
                {
                    ++item.Servings;
                    msg += item.BuildItemMessage();
                    Player.Totalscore += item.Points;
                }
            }
            TaskHistory taskHistory = new TaskHistory();
            taskHistory.Task = msg;
            gameMap.TaskHistoryList.Add(taskHistory);
            OnPropertyChanged(nameof(GameMap));
            //
            // Find out if you've finished all tasks for a city 
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
                Player.PlayerMessage = "You Can be done with this city, Congrats";
                ++Player.Visits;
            }
            if (isalldone)
            {
                Player.PlayerMessage = "You Finished, Congrats";
            }
            OnPropertyChanged(nameof(Player));

            BuildGameTaskDisplay();
            BuildActorDisplay();
        }
    }
}

