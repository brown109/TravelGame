using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // An item is something an Npc takes action with. Items are Foods, Drinks, Sights, or ways to defend/attack Interlopers.
    // Items have two interfaces to handle the possibility of losing a life or losing points because of what you ate, drank,
    // stress from driving or interactions with interlopers.
    // Data for items is hard-coded and will be read from a file in subsequent builds. It needs to follow certain rules:
    // It must have a valid Type, City must match the name of any city loaded in the list of Location(s). KeyWords are checked
    // when we parse the players command to identify this item. Points are loaded initially and then they get recalculated each time you 
    // complete a task for the item. Servings is incremented when you complete a task. Your done when it is > 0 but you can get another 
    // serving if you haven't reached Limit. 
    //
    public class Item : ObservableObject, ILifeIsRandom, IRandomPenalty
    {
        public enum ItemType
        {
            Site,
            Food,
            Drink,
            BattleMinor,
            BattleMajor
        }
        private string _name;
        private ItemType _type;
        private string _city;
        private string[] _keyWords;
        private int _points = 0;
        private int _servings;
        private int _limit;
        private double _diminish;
        Random _random = new Random();
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public ItemType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string[] KeyWords
        {
            get { return _keyWords; }
            set { _keyWords = value; }
        }
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }
        public int Servings
        {
            get { return _servings; }
            set { 
                _servings = value;
                CalcPoints();
            }
        }
        public int Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }
        public double Diminish
        {
            get { return _diminish; }
            set { _diminish = value; }
        }
        public string ItemMessage
        {
            get { return BuildItemMessage(); }
        }
        public Item()
        {

        }
        public Item(string name, ItemType type, string city, string[] keyWords, int points, int servings, int limit, double diminish)
        {
            _name = name;
            _type = type;
            _city = city;
            _keyWords = keyWords;
            _points = points;
            _servings = servings;
            _limit = limit;
            _diminish = diminish;
        }
        private void CalcPoints()
        {
            //
            // Based on the law of diminishing returns, subsequent duplicate actions earn less points (i.e. eating a second
            // piece of cake is less rewarding than the first.
            //
            double addedpoints = (double)Points;
            if (Servings > 1) 
            {
                addedpoints *= Diminish;
            }
            Points = (int)addedpoints;
        }
        public string BuildItemMessage()
        {
            //
            // Build out a message that shows up in a log of actions you have taken
            //
            string msg = "";
            if (Type == ItemType.Site)
            {
                msg = Name + " Seen " + Servings + " Time(s) " ;
            }
            else if (Type == ItemType.Food)
            {
                msg = Name + " Eaten " + Servings + " Time(s) ";
            }
            else if (Type == ItemType.Drink)
            {
                msg = "You downed " + Servings + " pour(s) of " + Name + " ";
            }
            else if (Type == ItemType.BattleMinor)
            {
                msg = "Minor skirmish # " + Servings + " with " + Name + " ";
            }
            else if (Type == ItemType.BattleMajor)
            {
                msg = "Major battle # " + Servings + " with " + Name + " ";
            }
            return msg;
        }
        public int CheckForLifeLost()
        {
            //
            // Foreign Foods, Drinks and driving around can be risky. 1% of the time they will kill you
            // This method will return the Lives Lost based on the above info
            //
            int rn = _random.Next(1, 101);

            if (Type == ItemType.Food || Type == ItemType.Drink || Type == ItemType.Site)
            {
                if (rn < 2) { return 1; } else { return 0; }
            }
            
            return 0;
        }
        public int CheckForPenalty()
        {
            //
            // Foreign foods, drinks and driving around town can get you sick. 20% of the time you'll lose 20 points
            // This method will return the points to be subtracted from the score. 
            //
            int rn = _random.Next(1, 101);

            if (Type == ItemType.Site || Type == ItemType.Food || Type == ItemType.Drink)
            {
                if (rn < 21) { return 20; } else { return 0; }
            }
            return 0;
        }
    }
}
