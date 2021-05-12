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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Etterem
{
    /// <summary>
    /// Interaction logic for UserControlFizetes.xaml
    /// </summary>
    public partial class UserControlFizetes : UserControl
    {
        public static UserControlFizetes Instance;

        //Végösszeg
        public UserControlFizetes()
        {
            Instance = this;
            InitializeComponent();
            tbVegosszeg.Text = (MainWindow.Instance.Fizetendo().ToString()) + " Ft";
        }

        //Vissza gomb
        private void btVissza_Click(object sender, RoutedEventArgs e)
        {
            //Ablakváltás
            MainWindow.Instance.SwitchScreen(new UserControlHome());
        }

        //Kifizet gomb
        private void btKifizet_Click(object sender, RoutedEventArgs e)
        {
            //Ablakváltás
            MainWindow.Instance.SwitchScreen(new UserControlRendeles());           
        }
    }
}
