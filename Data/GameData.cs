using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelGame.Models;

namespace TravelGame.Data
{
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                StartDate = DateTime.Now,
                //Name = "GNB",
                Experience = 0,
                Bestscore = 1977,
                Visits = 0,
                Tasks = 0,
                Liveslost = 0,
                Totalscore = 1000,
                CurrentCity = "blank"
            };
        }


        public static GameMap GameMap()
        {
            GameMap gameMap = new GameMap();
            //
            // load location list (each city to visit and where you can go from there)
            // taskstate list (each city to visit and the results of tasks to complete at each one)
            // locationitems (each city to visit and the actors, their role, and choices to drive interaction)
            //
            Location _location = new Location();
            _location.City = "New York";
            _location.NCity = "";
            _location.SCity = "";
            _location.ECity = "London";
            _location.WCity = "";
            _location.NECity = "";
            _location.NWCity = "";
            _location.SECity = "";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);
            
            TaskState _taskstate = new TaskState();
            _taskstate.City = "New York";
            _taskstate.Ate = false;
            _taskstate.Food = "";
            _taskstate.Drank = false;
            _taskstate.Drink = "";
            _taskstate.Toured = false;
            _taskstate.Site = "";
            _taskstate.Challenge1done = false;
            _taskstate.Result1 = "";
            _taskstate.Challenge2done = false;
            _taskstate.Result2 = "";
            gameMap.TaskStateList.Add(_taskstate);

            _location = new Location();
            _location.City = "London";
            _location.NCity = "";
            _location.SCity = "";
            _location.ECity = "Frankfort";
            _location.WCity = "New York";
            _location.NECity = "";
            _location.NWCity = "";
            _location.SECity = "Paris";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);
            
            _taskstate = new TaskState();
            _taskstate.City = "London";
            _taskstate.Ate = false;
            _taskstate.Food = "";
            _taskstate.Drank = false;
            _taskstate.Drink = "";
            _taskstate.Toured = false;
            _taskstate.Site = "";
            _taskstate.Challenge1done = false;
            _taskstate.Result1 = "";
            _taskstate.Challenge2done = false;
            _taskstate.Result2 = "";
            gameMap.TaskStateList.Add(_taskstate);

            _location = new Location();
            _location.City = "Frankfort";
            _location.NCity = "";
            _location.SCity = "Rome";
            _location.ECity = "Warsaw";
            _location.WCity = "London";
            _location.NECity = "";
            _location.NWCity = "";
            _location.SECity = "";
            _location.SWCity = "Paris";
            gameMap.LocationList.Add(_location);

            _taskstate = new TaskState();
            _taskstate.City = "Frankfort";
            _taskstate.Ate = false;
            _taskstate.Food = "";
            _taskstate.Drank = false;
            _taskstate.Drink = "";
            _taskstate.Toured = false;
            _taskstate.Site = "";
            _taskstate.Challenge1done = false;
            _taskstate.Result1 = "";
            _taskstate.Challenge2done = false;
            _taskstate.Result2 = "";
            gameMap.TaskStateList.Add(_taskstate);

            _location = new Location();
            _location.City = "Paris";
            _location.NCity = "";
            _location.SCity = "";
            _location.ECity = "";
            _location.WCity = "";
            _location.NECity = "Frankfort";
            _location.NWCity = "London";
            _location.SECity = "Rome";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);

            _taskstate = new TaskState();
            _taskstate.City = "Paris";
            _taskstate.Ate = false;
            _taskstate.Food = "";
            _taskstate.Drank = false;
            _taskstate.Drink = "";
            _taskstate.Toured = false;
            _taskstate.Site = "";
            _taskstate.Challenge1done = false;
            _taskstate.Result1 = "";
            _taskstate.Challenge2done = false;
            _taskstate.Result2 = "";
            gameMap.TaskStateList.Add(_taskstate);

            _location = new Location();
            _location.City = "Rome";
            _location.NCity = "Frankfort";
            _location.SCity = "";
            _location.ECity = "";
            _location.WCity = "";
            _location.NECity = "Warsaw";
            _location.NWCity = "Paris";
            _location.SECity = "Athens";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);

            _taskstate = new TaskState();
            _taskstate.City = "Rome";
            _taskstate.Ate = false;
            _taskstate.Food = "";
            _taskstate.Drank = false;
            _taskstate.Drink = "";
            _taskstate.Toured = false;
            _taskstate.Site = "";
            _taskstate.Challenge1done = false;
            _taskstate.Result1 = "";
            _taskstate.Challenge2done = false;
            _taskstate.Result2 = "";
            gameMap.TaskStateList.Add(_taskstate);

            _location = new Location();
            _location.City = "Warsaw";
            _location.NCity = "";
            _location.SCity = "Athens";
            _location.ECity = "";
            _location.WCity = "Frankfort";
            _location.NECity = "";
            _location.NWCity = "";
            _location.SECity = "";
            _location.SWCity = "Rome";
            gameMap.LocationList.Add(_location);

            _taskstate = new TaskState();
            _taskstate.City = "Warsaw";
            _taskstate.Ate = false;
            _taskstate.Food = "";
            _taskstate.Drank = false;
            _taskstate.Drink = "";
            _taskstate.Toured = false;
            _taskstate.Site = "";
            _taskstate.Challenge1done = false;
            _taskstate.Result1 = "";
            _taskstate.Challenge2done = false;
            _taskstate.Result2 = "";
            gameMap.TaskStateList.Add(_taskstate);

            _location = new Location();
            _location.City = "Athens";
            _location.NCity = "Warsaw";
            _location.SCity = "";
            _location.ECity = "";
            _location.WCity = "";
            _location.NECity = "";
            _location.NWCity = "Rome";
            _location.SECity = "";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);

            _taskstate = new TaskState();
            _taskstate.City = "Athens";
            _taskstate.Ate = false;
            _taskstate.Food = "";
            _taskstate.Drank = false;
            _taskstate.Drink = "";
            _taskstate.Toured = false;
            _taskstate.Site = "";
            _taskstate.Challenge1done = false;
            _taskstate.Result1 = "";
            _taskstate.Challenge2done = false;
            _taskstate.Result2 = "";
            gameMap.TaskStateList.Add(_taskstate);

            gameMap.CurrentLocation = gameMap.LocationList[0];

            LocationItems _locationItems = new LocationItems();
            _locationItems.City = "New York";
            _locationItems.Actors = new string[] { "J", "P", "G", "R", "B" };
            _locationItems.ActorTypes = new LocationItems.ActorType[] {LocationItems.ActorType.Driver, LocationItems.ActorType.Chef, LocationItems.ActorType.Bartender,
                LocationItems.ActorType.Interloper, LocationItems.ActorType.Interloper};
            _locationItems.IsTypeKnown = new bool[] { false, false, false, false, false };
            _locationItems.Sites = new string[] { "BB", "BP", "AR" };
            _locationItems.SiteOrder = new string[] { "Third", "Second", "First" };
            _locationItems.Foods = new string[] { "B and M", "F and C", "F P" };
            _locationItems.FoodOrder = new string[] { "Second", "First", "Third" };
            _locationItems.Drinks = new string[] { "G and T", "G", "J E" };
            _locationItems.DrinkOrder = new string[] { "Second", "First", "Third" };
            _locationItems.IsSiteSeen = false;
            _locationItems.IsFoodEaten = false;
            _locationItems.IsDrinkDrunk = false;
            _locationItems.AreAllTasksDone = false;
            gameMap.LocationItemList.Add(_locationItems);

            _locationItems.City = "London";
            _locationItems.Actors = new string[] { "John", "Paul", "George", "Ringo", "Brian" };
            _locationItems.ActorTypes = new LocationItems.ActorType[] {LocationItems.ActorType.Driver, LocationItems.ActorType.Chef, LocationItems.ActorType.Bartender,
                LocationItems.ActorType.Interloper, LocationItems.ActorType.Interloper};
            _locationItems.IsTypeKnown = new bool[] { false, false, false, false, false };
            _locationItems.Sites = new string[] { "Big Ben", "Buckingham Palace", "Abbey Road" };
            _locationItems.SiteOrder = new string[] { "Third", "Second", "First" };
            _locationItems.Foods = new string[] { "Bangers and Mash", "Fish and Chips", "Figgy Pudding" };
            _locationItems.FoodOrder = new string[] { "Second", "First", "Third" };
            _locationItems.Drinks = new string[] { "Gin and Tonic", "Guinness", "Jellied Eel" };
            _locationItems.DrinkOrder = new string[] { "Second", "First", "Third" };
            _locationItems.IsSiteSeen = false;
            _locationItems.IsFoodEaten = false;
            _locationItems.IsDrinkDrunk = false;
            _locationItems.AreAllTasksDone = false;
            gameMap.LocationItemList.Add(_locationItems);
            _locationItems = new LocationItems();
            _locationItems.City = "Frankfort";
            _locationItems.Actors = new string[] { "FJohn", "FPaul", "FGeorge", "FRingo", "FBrian" };
            _locationItems.ActorTypes = new LocationItems.ActorType[] {LocationItems.ActorType.Driver, LocationItems.ActorType.Chef, LocationItems.ActorType.Bartender,
                LocationItems.ActorType.Interloper, LocationItems.ActorType.Interloper};
            _locationItems.IsTypeKnown = new bool[] { false, false, false, false, false };
            _locationItems.Sites = new string[] { "FBig Ben", "FBuckingham Palace", "FAbbey Road" };
            _locationItems.SiteOrder = new string[] { "Third", "Second", "First" };
            _locationItems.Foods = new string[] { "FBangers and Mash", "FFish and Chips", "FFiggy Pudding" };
            _locationItems.FoodOrder = new string[] { "Second", "First", "Third" };
            _locationItems.Drinks = new string[] { "FGin and Tonic", "FGuinness", "FJellied Eel" };
            _locationItems.DrinkOrder = new string[] { "Second", "First", "Third" };
            _locationItems.IsSiteSeen = false;
            _locationItems.IsFoodEaten = false;
            _locationItems.IsDrinkDrunk = false;
            _locationItems.AreAllTasksDone = false;
            gameMap.LocationItemList.Add(_locationItems);

            _locationItems = new LocationItems();
            _locationItems.City = "Paris";
            _locationItems.Actors = new string[] { "pJohn", "pPaul", "pGeorge", "pRingo", "pBrian" };
            _locationItems.ActorTypes = new LocationItems.ActorType[] {LocationItems.ActorType.Driver, LocationItems.ActorType.Chef, LocationItems.ActorType.Bartender,
                LocationItems.ActorType.Interloper, LocationItems.ActorType.Interloper};
            _locationItems.IsTypeKnown = new bool[] { false, false, false, false, false };
            _locationItems.Sites = new string[] { "pBig Ben", "pBuckingham Palace", "pAbbey Road" };
            _locationItems.SiteOrder = new string[] { "Third", "Second", "First" };
            _locationItems.Foods = new string[] { "pBangers and Mash", "pFish and Chips", "pFiggy Pudding" };
            _locationItems.FoodOrder = new string[] { "Second", "First", "Third" };
            _locationItems.Drinks = new string[] { "pGin and Tonic", "pGuinness", "pJellied Eel" };
            _locationItems.DrinkOrder = new string[] { "Second", "First", "Third" };
            _locationItems.IsSiteSeen = false;
            _locationItems.IsFoodEaten = false;
            _locationItems.IsDrinkDrunk = false;
            _locationItems.AreAllTasksDone = false;
            gameMap.LocationItemList.Add(_locationItems);

            _locationItems = new LocationItems();
            _locationItems.City = "Rome";
            _locationItems.Actors = new string[] { "rJohn", "rPaul", "rGeorge", "rRingo", "rBrian" };
            _locationItems.ActorTypes = new LocationItems.ActorType[] {LocationItems.ActorType.Driver, LocationItems.ActorType.Chef, LocationItems.ActorType.Bartender,
                LocationItems.ActorType.Interloper, LocationItems.ActorType.Interloper};
            _locationItems.IsTypeKnown = new bool[] { false, false, false, false, false };
            _locationItems.Sites = new string[] { "rBig Ben", "rBuckingham Palace", "rAbbey Road" };
            _locationItems.SiteOrder = new string[] { "Third", "Second", "First" };
            _locationItems.Foods = new string[] { "rBangers and Mash", "rFish and Chips", "rFiggy Pudding" };
            _locationItems.FoodOrder = new string[] { "Second", "First", "Third" };
            _locationItems.Drinks = new string[] { "rGin and Tonic", "rGuinness", "rJellied Eel" };
            _locationItems.DrinkOrder = new string[] { "Second", "First", "Third" };
            _locationItems.IsSiteSeen = false;
            _locationItems.IsFoodEaten = false;
            _locationItems.IsDrinkDrunk = false;
            _locationItems.AreAllTasksDone = false;
            gameMap.LocationItemList.Add(_locationItems);

            _locationItems = new LocationItems();
            _locationItems.City = "Warsaw";
            _locationItems.Actors = new string[] { "wFJohn", "wFPaul", "wFGeorge", "wFRingo", "wFBrian" };
            _locationItems.ActorTypes = new LocationItems.ActorType[] {LocationItems.ActorType.Driver, LocationItems.ActorType.Chef, LocationItems.ActorType.Bartender,
                LocationItems.ActorType.Interloper, LocationItems.ActorType.Interloper};
            _locationItems.IsTypeKnown = new bool[] { false, false, false, false, false };
            _locationItems.Sites = new string[] { "wFBig Ben", "wFBuckingham Palace", "wFAbbey Road" };
            _locationItems.SiteOrder = new string[] { "Third", "Second", "First" };
            _locationItems.Foods = new string[] { "wFBangers and Mash", "wFFish and Chips", "wFFiggy Pudding" };
            _locationItems.FoodOrder = new string[] { "Second", "First", "Third" };
            _locationItems.Drinks = new string[] { "wFGin and Tonic", "wFGuinness", "wFJellied Eel" };
            _locationItems.DrinkOrder = new string[] { "Second", "First", "Third" };
            _locationItems.IsSiteSeen = false;
            _locationItems.IsFoodEaten = false;
            _locationItems.IsDrinkDrunk = false;
            _locationItems.AreAllTasksDone = false;
            gameMap.LocationItemList.Add(_locationItems);

            _locationItems = new LocationItems();
            _locationItems.City = "Athens";
            _locationItems.Actors = new string[] { "aFJohn", "aFPaul", "aFGeorge", "aFRingo", "aFBrian" };
            _locationItems.ActorTypes = new LocationItems.ActorType[] {LocationItems.ActorType.Driver, LocationItems.ActorType.Chef, LocationItems.ActorType.Bartender,
                LocationItems.ActorType.Interloper, LocationItems.ActorType.Interloper};
            _locationItems.IsTypeKnown = new bool[] { false, false, false, false, false };
            _locationItems.Sites = new string[] { "aFBig Ben", "aFBuckingham Palace", "aFAbbey Road" };
            _locationItems.SiteOrder = new string[] { "Third", "Second", "First" };
            _locationItems.Foods = new string[] { "aFBangers and Mash", "aFFish and Chips", "aFFiggy Pudding" };
            _locationItems.FoodOrder = new string[] { "Second", "First", "Third" };
            _locationItems.Drinks = new string[] { "aFGin and Tonic", "aFGuinness", "aFJellied Eel" };
            _locationItems.DrinkOrder = new string[] { "Second", "First", "Third" };
            _locationItems.IsSiteSeen = false;
            _locationItems.IsFoodEaten = false;
            _locationItems.IsDrinkDrunk = false;
            _locationItems.AreAllTasksDone = false;
            gameMap.LocationItemList.Add(_locationItems);

            gameMap.CurrentLocationItems = gameMap.LocationItemList[0];

            return gameMap;

        }
        public static GameHistory PlayerHistory()
        {
            GameHistory gameHistory = new GameHistory();
            //
            // load game history list by force for now. Later, need to read it in from a data file
            //
            GameStat _gameStat = new GameStat();
            _gameStat.Name = "GNB";
            _gameStat.Startdate = new DateTime(2021, 03, 01, 08, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 01, 09, 01, 02);
            _gameStat.Score = 1015;
            _gameStat.Liveslost = 2;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "GNB";
            _gameStat.Startdate = new DateTime(2021, 03, 02, 09, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 02, 10, 01, 02);
            _gameStat.Score = 1027;
            _gameStat.Liveslost = 2;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "HAK";
            _gameStat.Startdate = new DateTime(2021, 03, 01, 11, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 01, 12, 01, 02);
            _gameStat.Score = 850;
            _gameStat.Liveslost = 3;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "GNB";
            _gameStat.Startdate = new DateTime(2021, 03, 03, 09, 31, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 03, 10, 41, 02);
            _gameStat.Score = 905;
            _gameStat.Liveslost = 4;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "HAK";
            _gameStat.Startdate = new DateTime(2021, 03, 04, 11, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 04, 11, 59, 02);
            _gameStat.Score = 1999;
            _gameStat.Liveslost = 1;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "GNB";
            _gameStat.Startdate = new DateTime(2021, 03, 05, 06, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 05, 07, 01, 02);
            _gameStat.Score = 1158;
            _gameStat.Liveslost = 1;
            gameHistory.GameStats.Add(_gameStat);

            return gameHistory;
        }
    }
}
