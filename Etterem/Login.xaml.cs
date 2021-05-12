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

namespace Etterem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        //Regisztráció gomb
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Loginablak.Visibility = Visibility.Collapsed;
            regablak.Visibility = Visibility.Visible;
        }

        //Elfelejtett jelszó gomb
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Loginablak.Visibility = Visibility.Collapsed;
            ElfelejtettAblak.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
