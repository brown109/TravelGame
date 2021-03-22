using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class DisplayLocationItem : ObservableObject
    {
        private string[] _item;
        private string[] _description;
        private string[] _status;
        
        public string[] Item
        {
            get { return _item; }
            set { _item = value; }
        }
        public string[] Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string[] Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public DisplayLocationItem()
        {

        }
        public DisplayLocationItem(string[] item, string[] description, string[] status)
        {
            _item = item;
            _description = description;
            _status = status;
        }
    }   
}
