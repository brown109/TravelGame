using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelGame.Presentation;
using TravelGame.Models;
using TravelGame.Data;
using System.Collections.ObjectModel;

namespace TravelGame.Business
{
    //
    // Prepare all the structures for playing the game 
    //
    public class BusinessLogic
    {
        bool _newPlayer = true;
        ControlWindowModel _controlWindowModel;
        Player _player = new Player();
        WelcomeWindow _welcomeWindow = null;
        GameMap _gameMap;
        DisplayLocationItem _currentDisplayItems = new DisplayLocationItem();
        DisplayTaskState _currentDisplayTasks = new DisplayTaskState();
        GameHistory _gameHistory;
        //
        // Get the game started with the Welcome window
        //
        public BusinessLogic()
        {
            InitiatePlayer();
            InitiateData();
            InitiateShowControlWindow();
        
        }
        //
        // The current version always starts up a new player but a future build will allow a restart 
        //
        private void InitiatePlayer()
        {
            if (_newPlayer)
            {
                _welcomeWindow = new WelcomeWindow(_player);
                _welcomeWindow.ShowDialog();
                //
                // insert code here to replace the player data already initialized with GameData
                //
                _player.Totalscore = 1000;
            }
            else
            {
                _player = GameData.PlayerData();
            }
           
        }
        private void InitiateData()
        {
            //_player = GameData.PlayerData();
            _gameMap = GameData.GameMap();
            _gameHistory = GameData.PlayerHistory();
                        
            GetPlayerHistory(_gameHistory);

        }
        private void InitiateShowControlWindow()
        {
            //
            // instantiate the Control Window
            //
            _controlWindowModel = new ControlWindowModel(
                _player,
                _gameMap,
                _currentDisplayItems,
                _currentDisplayTasks,
                _gameHistory);
            
            ControlWindow controlWindow = new ControlWindow(_controlWindowModel);
            controlWindow.DataContext = _controlWindowModel;
            controlWindow.Show();
            //
            // dialog window is initially hidden to mitigate issue with
            // main window closing after dialog window closes
            //
            _welcomeWindow.Close();
        }
        //
        // When starting up, check to see if the player has played this game before because if they have, you will show the number of 
        // times played as their experience and you'll find their best score. 
        //
        private void GetPlayerHistory(GameHistory gameHistory)
        {
            int playergames = 0;
            int topscore = 0;
            int i = 0;
            do
            {
                GameStat gamestat = gameHistory.GameStats[i];
                if (_player.Name == gamestat.Name)
                {
                    ++playergames;
                    if (gamestat.Score > topscore)
                    {
                        topscore = gamestat.Score;
                    }
                }
                ++i;
            } while (i < 6) ;
            _player.Experience = playergames;
            _player.Bestscore = topscore;
            _player.CurrentCity = "New York";
          }
    }
}
