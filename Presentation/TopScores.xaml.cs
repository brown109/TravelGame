﻿using System;
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

namespace TravelGame.Presentation
{
    /// <summary>
    /// Interaction logic for TopScores.xaml
    /// </summary>
    public partial class TopScores : Window
    {
        public TopScores()
        {
            InitializeComponent();
        }
        private void Button_ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
