using BeautySolutions.View.ViewModel;
using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public MainWindow()
        {
            Instance = this;
            InitializeComponent();

            //Kezdőlap menüpont
            //var Home = new ItemMenu("Kezdőlap", new UserControl(), PackIconKind.Home);


            //Gyorsételek menüpont
            var menuKaja = new List<SubItem>();
            menuKaja.Add(new SubItem("Pizzák", new UserControlPizza()));
            menuKaja.Add(new SubItem("Hotdogok", new UserControlHotdog()));
            menuKaja.Add(new SubItem("Hamburgerek", new UserControlHamburger()));
            var Gyors = new ItemMenu("Gyorsételek", menuKaja, PackIconKind.FastFood);


            //Egytálételek menüpont
            var menuFoetel = new List<SubItem>();
            menuFoetel.Add(new SubItem("Tészták", new UserControlTeszta()));
            menuFoetel.Add(new SubItem("Sülthúsok"));
            menuFoetel.Add(new SubItem("Gyrosok"));
            var Foetel = new ItemMenu("Egytálételek", menuFoetel, PackIconKind.Spaghetti);


            //Egészséges ételek menüpont
            //var Egeszseges = new ItemMenu("Egészséges ételeink", new UserControl(), PackIconKind.FoodAllergyOff);


            //Desszertek menüpont
            //var Desszert = new ItemMenu("Desszertek", new UserControl(), PackIconKind.Biscuit);


            //Egyéb ételek menüpont
            var menuEgyeb = new List<SubItem>();
            menuEgyeb.Add(new SubItem("Egészséges ételeink"));
            menuEgyeb.Add(new SubItem("Desszertek"));
            var Egyeb = new ItemMenu("Egyéb ételeink", menuEgyeb, PackIconKind.AllergenOff);


            //Italok menüpont
            var menuItal = new List<SubItem>();
            menuItal.Add(new SubItem("Szénsavas"));
            menuItal.Add(new SubItem("Szénsavmentes"));
            menuItal.Add(new SubItem("Rostos"));
            menuItal.Add(new SubItem("Szeszes"));
            var Ital = new ItemMenu("Italok", menuItal, PackIconKind.Drink);

            
            //Menu.Children.Add(new UserControlMenuItem(Home, this));
            Menu.Children.Add(new UserControlMenuItem(Gyors, this));
            Menu.Children.Add(new UserControlMenuItem(Foetel, this));
            //Menu.Children.Add(new UserControlMenuItem(Egeszseges, this));
            //Menu.Children.Add(new UserControlMenuItem(Desszert, this));
            Menu.Children.Add(new UserControlMenuItem(Egyeb, this));
            Menu.Children.Add(new UserControlMenuItem(Ital, this));
        }


        //Ablakváltó
        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);
            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

        //Bejelentkezés kattintása
        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            Login LoginWindow = new Login();
            LoginWindow.Show();
        }


        //Alkalmazás bezárása
        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void PackIcon_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void KosarDarab(object sender, MouseButtonEventArgs e)
        {

        }


        //Kosár ürítése, számláló nullázása
        private void Urites_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.KosarLista.Items.Clear();
            MainWindow.Instance.KosarOsszesDarab.Text = "0";
            UserControlPizza.Instance.szamlalo = 0;
        }
    }
}
