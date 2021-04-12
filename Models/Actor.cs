using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
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
        //{
        //    //return ("I am just a parent class actor ");
        //}
    }

}
