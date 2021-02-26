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
    public class BusinessLogic
    {
        ControlWindowModel _controlWindowModel;
        Player _player = new Player();
        WelcomeWindow _welcomeWindow = null;

        public BusinessLogic()
        {
            InitiatePlayer();
            InitiateShowControlWindow();
        
        }
        private void InitiatePlayer()
        {
            _welcomeWindow = new WelcomeWindow(_player);
            _welcomeWindow.Show();
            _player.Name = _welcomeWindow.Name;
            _player.Experience = 3;
            _player.Bestscore = 1256;
            _player.Experience = 3;
            _player.Bestscore = 1256;
            _player.Visits = 2;
            _player.Tasks = 24;
            _player.Liveslost = 3;
            _player.Totalscore = 1000;
            
        }
        private void InitiateShowControlWindow()
        {
            //
            // instantiate the Control Window
            //
            // ControlWindowModel _controlWindowModel;

            _controlWindowModel = new ControlWindowModel(_player);
            ControlWindow controlWindow = new ControlWindow(_controlWindowModel);

            controlWindow.DataContext = _controlWindowModel;

            controlWindow.Show();

            //
            // dialog window is initially hidden to mitigate issue with
            // main window closing after dialog window closes
            //
            // commented out because the player setup window is disabled
            //
            //_playerSetupView.Close();
        }
    }
}
