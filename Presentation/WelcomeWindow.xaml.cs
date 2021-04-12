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

namespace TravelGame.Presentation
{
    //
    // Interaction logic for WelcomeWindow.xaml
    //
    public partial class WelcomeWindow : Window
    {
        private Player _player;

        public WelcomeWindow(Player player)
        {
            _player = player;
            InitializeComponent();
            ErrorMessageTextBlock.Visibility = Visibility.Hidden;
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            // 
            // Validate Input to make sure a name was entered 
            //
            string errorMessage;
            if (Isnamevalid(out errorMessage))
            {
                _player.Name = NameTextBox.Text;
                _player.StartDate = DateTime.Now;
                Visibility = Visibility.Hidden;
            }
            else
            {
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
                ErrorMessageTextBlock.Text = errorMessage;
            }
        }
        private bool Isnamevalid(out string errorMessage)
        {
            errorMessage = "";
            if (NameTextBox.Text == "")
            {
                errorMessage = "You must enter something for Name";
            }
            return errorMessage == "" ? true : false;
        }
    }
}
