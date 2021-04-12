using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
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
            set { _servings = value; }
        }
        public int Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }
        public double Diminish
        {
            get { return _diminish; }
            set
            {
                _diminish = value;
                CalcPoints();
            }
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
            double addedpoints = (double)Points;
            for (int i = 0; i < Servings - 1; ++i)
            {
                addedpoints *= Diminish;
            }
            Points = (int)addedpoints;
        }
        public string BuildItemMessage()
        {
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
