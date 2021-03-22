using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class LocationItems : ObservableObject
    {
        public enum ActorType
        {
            Driver,
            Chef,
            Bartender,
            Interloper
        }

        private string _city;
        private string[] _actors;
        private ActorType[] _actorTypes;
        private bool[] _isTypeKnown;
        private string[] _sites;
        private string[] _siteorder;
        private string[] _foods;
        private string[] _foodorder;
        private string[] _drinks;
        private string[] _drinkorder;
        private bool _issiteseen;
        private bool _isfoodeaten;
        private bool _isdrinkdrunk;
        private bool _arealltasksdone;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string[] Actors
        {
            get { return _actors; }
            set { _actors = value; }
        }
        public ActorType[] ActorTypes
        {
            get { return _actorTypes; }
            set { _actorTypes = value; }
        }
        public bool[] IsTypeKnown
        {
            get { return _isTypeKnown; }
            set { _isTypeKnown = value; }
        }
        public string[] Sites
        {
            get { return _sites; }
            set { _sites = value; }
        }
        public string[] SiteOrder
        {
            get { return _siteorder; }
            set { _siteorder = value; }
        }
        public string[] Foods
        {
            get { return _foods; }
            set { _foods = value; }
        }
        public string[] FoodOrder
        {
            get { return _foodorder; }
            set { _foodorder = value; }
        }
        public string[] Drinks
        {
            get { return _drinks; }
            set { _drinks = value; }
        }
        public string[] DrinkOrder
        {
            get { return _drinkorder; }
            set { _drinkorder = value; }
        }
        public bool IsSiteSeen
        {
            get { return _issiteseen; }
            set { _issiteseen = value; }
        }
        public bool IsFoodEaten
        {
            get { return _isfoodeaten; }
            set { _isfoodeaten = value; }
        }
        public bool IsDrinkDrunk
        {
            get { return _isdrinkdrunk; }
            set { _isdrinkdrunk = value; }
        }
        public bool AreAllTasksDone
        {
            get { return _arealltasksdone; }
            set { _arealltasksdone = value; }
        }
        public LocationItems()
        {

        }
        public LocationItems(string city, string[] actors, ActorType[] actortypes, bool[] isTypeKnown, string[] sites, string[] siteorder, string[] foods, string[] foodorder,
            string[] drinks, string[] drinkorder, bool issiteseen, bool isfoodeaten, bool isdrinkdrunk, bool arealltasksdone)
        {

            _city = city;
            _actors = actors;
            _actorTypes = actortypes;
            _isTypeKnown = isTypeKnown;
            _sites = sites;
            _siteorder = siteorder;
            _foods = foods;
            _foodorder = foodorder;
            _drinks = drinks;
            _drinkorder = drinkorder;
            _issiteseen = issiteseen;
            _isfoodeaten = isfoodeaten;
            _isdrinkdrunk = isdrinkdrunk;
            _arealltasksdone = arealltasksdone;

        }
    }
}
