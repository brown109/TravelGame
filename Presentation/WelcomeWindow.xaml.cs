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
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        private Player _player;

        public WelcomeWindow(Player player)
        {
            _player = player;
            InitializeComponent();

        }
        //public WelcomeWindow()
        //{
        //    InitializeComponent();
        //}

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            // 
            // Validate Input  
            //
            //MessageBox.Show("Breakpoint");
            _player.Name = NameTextBox.ToString();
        }
        
    }
}
