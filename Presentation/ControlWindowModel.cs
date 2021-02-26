using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelGame.Models;

namespace TravelGame.Presentation
{
    public class ControlWindowModel
    {
        private Player _player;

        public Player Player
        { 
            get { return _player; }
            set { _player = value; }
        }

        public ControlWindowModel()
        { 
        
        }
        public ControlWindowModel(Player player)
        {
            _player = player;
            InitializeView();
        }

        private void InitializeView()
        { 
        
        }
        
    }
}
