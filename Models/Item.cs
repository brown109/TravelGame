using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class Item : ObservableObject
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
                msg = "You have visited " + Name + " " + Servings + " Time(s)" ;
            }
            else if (Type == ItemType.Food)
            {
                msg = "You have now eaten " + Name + " " + Servings + " Time(s)";
            }
            else if (Type == ItemType.Drink)
            {
                msg = "You have now downed " + Servings + " pour(s) of " + Name;
            }
            else if (Type == ItemType.BattleMinor)
            {
                msg = "You have had " + Servings + " minor skirmish(es) with " + Name;
            }
            else if (Type == ItemType.BattleMajor)
            {
                msg = "You have had " + Servings + " major skirmish(es) with " + Name;
            }
            return msg;
        }
    }
}
