using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // When a player completes a task, a message about that task is logged. This is the message and the GameMap has the complete list.
    //
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
