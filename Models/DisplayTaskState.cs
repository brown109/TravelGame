﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // This is another display area. Look at DisplayLocationItem to perhaps consolidate
    //
    public class DisplayTaskState : ObservableObject
    {
        private string[] _displayLine;
        
        public string[] DisplayLine
        {
            get { return _displayLine; }
            set { _displayLine = value; }
        }
        public DisplayTaskState()
        {

        }
        public DisplayTaskState(string[] displayLine)
        {
            _displayLine = displayLine;
        }
    }
}
