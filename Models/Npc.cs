using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // An Npc is a type of Actor in the game. Types are Drivers - they take you to see a sight, Chefs - they cook local cusine, Bartenders -
    // they mix up a local beverage, and Interlopers both Minor and Major. These are 1 of each type in each city. 
    // Like Items. Npcs have two interfaces to handle the possibility of losing a life or losing points because of your interaction with that actor.
    // Data for Npcs is hard-coded and will be read from a file in subsequent builds. It needs to follow certain rules:
    // It must have a valid Type, City must match the name of any city loaded in the list of Location(s). KeyWords for Drivers, Chefs and Bartenders are checked
    // when we parse the players command to identify this Actor. For Interlopers, KeyWord[0] is what they are exactly and KeyWord[1] is either attack for a Major
    // Interloper or defend for a Minor Interloper. The Hints button shows the player all the interlopers and if you provide the name and the word, "hint" in the
    // command line, we'll show the HintPhrase which helps the player complete the task with the interloper. You earn IdPoints for identifying what a person is
    // (i.e. the command "John drive") will set IsIded and award the points is John is the driver. The command "John drive me to Buckingham Palace" will
    // award CompletionPoints and set IsComplete if John is the driver and Buckingham Palace is one of the sights (i.e. and item of type Site in the current city).
    //
    public class Npc : Actor, ILifeIsRandom, IRandomPenalty
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
        private string _hint;
        private string _city;
        private string[] _keyWords;
        private string _hintPhrase;
        private int _idPoints;
        private int _completionPoints;
        private bool _isIded;
        private bool _isComplete;
        Random _random = new Random();
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
        public string Hint
        {
            get { return _hint; }
            set { _hint = value; }
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
        public string HintPhrase
        {
            get { return _hintPhrase; }
            set { _hintPhrase = value; }
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

        public Npc(string city, NpcType actorType, string hint, string[] keyWords, string hintPhrase, int idpoints, int completionpoints, bool isIded, bool isComplete)
        {
            _city = city;
            _actorType = actorType;
            _hint = hint;
            _keyWords = keyWords;
            _hintPhrase = hintPhrase;
            _idPoints = idpoints;
            _completionPoints = completionpoints;
            _isIded = isIded;
            _isComplete = IsComplete;
        }
        public override string TaskMessage()
        {
            string msg;
            if (Language == PrimaryLanguage.English.ToString()) { msg = "Hello. "; }
            else if (Language == PrimaryLanguage.French.ToString()) { msg = "Bon Jour. "; }
            else if (Language == PrimaryLanguage.Greek.ToString()) { msg = "Geia sas. "; }
            else if (Language == PrimaryLanguage.Polish.ToString()) { msg = "Witam. "; }
            else if (Language == PrimaryLanguage.German.ToString()) { msg = "Hallo. "; }
            else if (Language == PrimaryLanguage.Italian.ToString()) { msg = "Ciao. "; }
            else { msg = "Greetings. "; }
            msg += Hint + "?";
            return msg;
        }
        public int CheckForLifeLost()
        {
            //
            // Chefs, Drivers and Bartenders are mostly harmless. 1% of the time they will kill you
            // Minor Interlopers will kill you 3% of the time
            // Major Interlopers are quite dangerous and they will kill you 20% of the time
            // This method will return the Lives Lost based on the above info
            //
            int rn = _random.Next(1, 101);

            if (ActorType == NpcType.Driver || ActorType == NpcType.Chef || ActorType == NpcType.Bartender)
            {
                if (rn < 2) { return 1; } else { return 0; }
            }
            if (ActorType == NpcType.InterloperMinor)
            {
                if (rn < 4) { return 1; } else { return 0; }
            }
            if (ActorType == NpcType.InterloperMajor)
            {
                if (rn < 21) { return 1; } else { return 0; }
            }
            return 0;
        }
        public int CheckForPenalty()
        {
            //
            // Chefs, Drivers and Bartenders are mostly harmless but they can cause stress. 20% of the time you'll lose 10 points
            // Minor Interlopers cost you 25 points 40% of the time
            // Major Interlopers are very stressful. You'll lose 50 points 50% of the time
            // This method will return the points to be subtracted from the score. 
            //
            int rn = _random.Next(1, 101);

            if (ActorType == NpcType.Driver || ActorType == NpcType.Chef || ActorType == NpcType.Bartender)
            {
                if (rn < 21) { return 10; } else { return 0; }
            }
            if (ActorType == NpcType.InterloperMinor)
            {
                if (rn < 41) { return 25; } else { return 0; }
            }
            if (ActorType == NpcType.InterloperMajor)
            {
                if (rn < 51) { return 50; } else { return 0; }
            }
            return 0;
        }
    }
}
