using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    public class GameHistory
    {
        public List<GameStat> _gamestats;
        public GameStat _gamestat;
            
        public List<GameStat> GameStats
        {
            get { return _gamestats; }
            set { _gamestats = value; }
        }
        public GameStat GameStat
        { 
            get { return _gamestat; }
            set { _gamestat = value; }
        }
        public GameHistory()
        {
            _gamestats = new List<GameStat>();
        }
    }
 }



