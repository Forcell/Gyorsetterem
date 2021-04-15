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
        public UserControlFizetes()
        {
            Instance = this;
            InitializeComponent();
            tbVegosszeg.Text = (MainWindow.Instance.Fizetendo().ToString()) + " Ft";
        }

        private void btVissza_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.SwitchScreen(new UserControlHome());
        }

        private void btKifizet_Click(object sender, RoutedEventArgs e)
        {
            //Ablakváltás
            MainWindow.Instance.SwitchScreen(new UserControlThankYou());

            //Fenti kosár ürítése
            MainWindow.Instance.KosarLista.Items.Clear();

            //Fenti kosárba lévő termékék nullázása
            MainWindow.Instance.KosarOsszesDarab.Text = "0";


            //Pizzák darabszámának nullázása
            UserControlPizza.Instance.darab1 = 0;
            UserControlPizza.Instance.darab2 = 0;

            //Hotdogok darabszámának nullázása
            UserControlHotdog.Instance.darab1 = 0;
            UserControlHotdog.Instance.darab2 = 0;
            UserControlHotdog.Instance.darab3 = 0;
            UserControlHotdog.Instance.darab4 = 0;
            UserControlHotdog.Instance.darab5 = 0;

            //Hamburgerek darabszámának nullázása
            UserControlHamburger.Instance.darab1 = 0;
            UserControlHamburger.Instance.darab2 = 0;
            UserControlHamburger.Instance.darab3 = 0;
            UserControlHamburger.Instance.darab4 = 0;
            UserControlHamburger.Instance.darab5 = 0;

            //Tészták darabszámának nullázása
            UserControlTeszta.Instance.darab1 = 0;
            UserControlTeszta.Instance.darab2 = 0;
            UserControlTeszta.Instance.darab3 = 0;
            UserControlTeszta.Instance.darab4 = 0;
            UserControlTeszta.Instance.darab5 = 0;

            //Sülthúsok darabszámának nullázása
            //Gyrosok darabszámának nullázása
            //Egészségs ételek darabszámának nullázása
            //Desszertek darabszámának nullázása
            //Szénsavas italok darabszámának nullázása
            //Szénsavmentes italok darabszámának nullázása
            //Alkoholos italok darabszámának nullázása

            //Számláló nullázása
            MainWindow.Instance.szamlalo = 0;

            
        }
    }
}
