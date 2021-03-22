using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    
    public class TaskState : ObservableObject
    {
        private string _city;
        private bool _ate;
        private string _food;
        private bool _drank;
        private string _drink;
        private bool _toured;
        private string _site;
        private bool _challenge1done;
        private string _result1;
        private bool _challenge2done;
        private string _result2;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public bool Ate
        {
            get { return _ate; }
            set { _ate = value; }
        }
        public string Food
        {
            get { return _food; }
            set { _food = value; }
        }
        public bool Drank
        {
            get { return _drank; }
            set { _drank = value; }
        }
        public string Drink
        {
            get { return _drink; }
            set { _drink = value; }
        }
        public bool Toured
        {
            get { return _toured; }
            set { _toured = value; }
        }
        public string Site
        {
            get { return _site; }
            set { _site = value; }
        }
        public bool Challenge1done
        {
            get { return _challenge1done; }
            set { _challenge1done = value; }
        }
        public string Result1
        {
            get { return _result1; }
            set { _result1 = value; }
        }
        public bool Challenge2done
        {
            get { return _challenge2done; }
            set { _challenge2done = value; }
        }
        public string Result2
        {
            get { return _result2; }
            set { _result2 = value; }
        }
        public TaskState()
        {

        }
        public TaskState(string city, bool ate, string food, bool drank, string drink, bool toured, string site, 
            bool challenge1done, string result1, bool challenge2done, string result2)
        {
            _city = city;
            _ate = ate;
            _food = food;
            _drank = drank;
            _drink = drink;
            _toured = toured;
            _site = site;
            _challenge1done = challenge1done;
            _result1 = result1;
            _challenge2done = challenge2done;
            _result2 = result2;
        }
    }

}
