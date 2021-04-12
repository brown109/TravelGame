using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
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
