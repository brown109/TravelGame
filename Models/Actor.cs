using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // Parent class for Npc (Non Player Characters) and the Player. Everyone has an ID, Name and a primary language. Every specific Npc needs to provide a 
    // message to the player so it is an abstract method at the parent level
    //
    public abstract class Actor : ObservableObject
    {
        public enum PrimaryLanguage
        {
            English,
            French,
            Polish,
            Greek,
            German,
            Italian
        }
        protected int _id;
        protected string _name;
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
        public virtual string Language
        { get; set; }
        public Actor()
        {

        }
        public abstract string TaskMessage();
        //
        // Since the game never interacts with the parent, there is no need for a message
        //
    }

}
