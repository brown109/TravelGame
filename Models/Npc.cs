using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class Npc : Actor
    {
        public enum NpcType
        {
            Driver,
            Chef,
            Bartender,
            InterloperMinor,
            InterloperMajor
        }

        private string _language;
        private NpcType _actorType;
        private string _city;
        private string[] _keyWords;
        private int _idPoints;
        private int _completionPoints;
        private bool _isIded;
        private bool _isComplete;
        public override string Language
        {
            get { return _language; }
            set
            {
                if (value == "")
                { _language = PrimaryLanguage.English.ToString(); }
                else
                { _language = value; }
            }
        }
        public NpcType ActorType
        {
            get { return _actorType; }
            set { _actorType = value; }
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
        public int IdPoints
        {
            get { return _idPoints; }
            set { _idPoints = value; }
        }
        public int CompletionPoints
        {
            get { return _completionPoints; }
            set { _completionPoints = value; }
        }
        public bool IsIded
        {
            get { return _isIded; }
            set { _isIded = value; }
        }
        public bool IsComplete
        {
            get { return _isComplete; }
            set { _isComplete = value; }
        }
        public Npc()
        {

        }

        public Npc(string city, NpcType actorType, string[] keyWords, int idpoints, int completionpoints, bool isIded, bool isComplete)
        {
            _city = city;
            _actorType = actorType;
            _keyWords = keyWords;
            _idPoints = idpoints;
            _completionPoints = completionpoints;
            _isIded = isIded;
            _isComplete = IsComplete;
        }
        public string TaskMessage()
        {
            return ("I am an NPC derived from Actor " + GetType().ToString() + " my type is " + ActorType);
        }
    }
}
