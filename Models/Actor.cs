using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
     public class Actor : ObservableObject
    {
        public enum PrimaryLanguage
        {
            English,
            French,
            Greek
        }
        
        protected int _id;
        protected string _name;
        protected string _language;

        public int Id
        { 
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }
        public Actor()
        {
            
        }
        public Actor(int id, string name, string language)
        {
            _id = id;
            _name = name;
            _language = language;
        }

    }
}
