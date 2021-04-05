using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    
    public class TaskHistory : ObservableObject
    {
        private string _task;
        public string Task
        {
            get { return _task; }
            set { _task = value; }
        }
        public TaskHistory()
        {

        }
        public TaskHistory(string task)
        {
            _task = task;
        }
    }

}
