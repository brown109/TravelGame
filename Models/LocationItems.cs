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

        public string _city;
        public string[] _actors;
        public ActorType[] _actorTypes;
        public bool[] _isTypeKnown;
        public string[] _sites;
        public string[] _siteorder;
        public string[] _foods;
        public string[] _foodorder;
        public string[] _drinks;
        public string[] _drinkorder;
        public bool _issiteseen;
        public bool _isfoodeaten;
        public bool _isdrinkdrunk;
        public bool _arealltasksdone;

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
    }
}
