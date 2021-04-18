using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // GameHistory is a List of GameStat. When getting around to re-factoring, we could probably eliminate this class and the
    // just pass around the list 
    //
    public class GameHistory : ObservableObject
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



