using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TravelGame.Models;
using TravelGame.Business;
using TravelGame.Data;

namespace TravelGame.Presentation
{
    /// <summary>
    /// Interaction logic for ControlWindow.xaml
    /// </summary>
    public partial class ControlWindow : Window
    {
        ControlWindowModel _controlWindowModel;
        public ControlWindow(ControlWindowModel controlWindowModel)
        {
            _controlWindowModel = controlWindowModel;

            InitializeComponent();
        }
        public void ControlWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Button windowButton = sender as Button;

            switch (windowButton.Name)
            {
                case "Help":
                    ShowHelp();
                    break;
                case "Quit":
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Got a command that the code can't handle" + Name);
                    break;
            }
        }
        public void DirectionButton_Click(object sender, RoutedEventArgs e)
        {
            Button windowButton = sender as Button;
            //
            // will need to prepare everything for a new location. 
            //
            _controlWindowModel.CheckMove(windowButton.Tag.ToString());
        }
        public void InteractionAreaButton_Click(object sender, RoutedEventArgs e)
        {
            Button windowButton = sender as Button;
            //
            // will need to build out display of actors, sites, foods, drinks, scores, task status, task history, or hints 
            //
            _controlWindowModel.CheckDisplay(windowButton.Tag.ToString());
        }
        public void GameCommandSubmit_Click(object sender, RoutedEventArgs e)
        {
            Button windowButton = sender as Button;
            //
            // will need to process the Command submitted by the user 
            //
            _controlWindowModel.CheckCommand(GameCommand.Text.ToString());
            GameCommand.Text = "";
        }
        private void ShowHelp()
        {
            //
            // Show the help screen
            // 
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
            helpWindow.Close();
        }
    }
}
