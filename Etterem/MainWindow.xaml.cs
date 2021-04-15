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

        public Hozzaferes adat = new Hozzaferes();

        public int szamlalo = 0;

        public List<KosarTermek> Kosar = new List<KosarTermek>();

        public MainWindow()
        {
            Instance = this;
            InitializeComponent();
            SwitchScreen(new UserControlHome());

            adat = new Hozzaferes();


            //Gyorsételek menüpont
            var menuKaja = new List<SubItem>();
            menuKaja.Add(new SubItem("Pizzák", new UserControlPizza()));
            menuKaja.Add(new SubItem("Hotdogok", new UserControlHotdog()));
            menuKaja.Add(new SubItem("Hamburgerek", new UserControlHamburger()));
            var Gyors = new ItemMenu("Gyorsételek", menuKaja, PackIconKind.FastFood);


            //Egytálételek menüpont
            var menuFoetel = new List<SubItem>();
            menuFoetel.Add(new SubItem("Tészták", new UserControlTeszta()));
            menuFoetel.Add(new SubItem("Sülthúsok", new UserControlSulthus()));
            menuFoetel.Add(new SubItem("Gyrosok", new UserControlGyros()));
            var Foetel = new ItemMenu("Egytálételek", menuFoetel, PackIconKind.Spaghetti);


            //Egyéb ételek menüpont
            var menuEgyeb = new List<SubItem>();
            menuEgyeb.Add(new SubItem("Egészséges ételeink", new UserControlEgeszseges()));
            menuEgyeb.Add(new SubItem("Desszertek", new UserControlDesszert()));
            var Egyeb = new ItemMenu("Egyéb ételeink", menuEgyeb, PackIconKind.AllergenOff);


            //Italok menüpont
            var menuItal = new List<SubItem>();
            menuItal.Add(new SubItem("Szénsavas", new UserControlSzensavas()));
            menuItal.Add(new SubItem("Szénsavmentes", new UserControlSzensavmentes()));
            menuItal.Add(new SubItem("Alkoholos", new UserControlAlkoholos()));
            var Ital = new ItemMenu("Italok", menuItal, PackIconKind.Drink);

            
            Menu.Children.Add(new UserControlMenuItem(Gyors, this));
            Menu.Children.Add(new UserControlMenuItem(Foetel, this));
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

            //Fenti kosár ürítése
            MainWindow.Instance.KosarLista.Items.Clear();

            //Fenti kosárba lévő termékék nullázása
            MainWindow.Instance.KosarOsszesDarab.Text = "0";

            //Kosár ürítése a fizetés oldalon
            MainWindow.Instance.Kosar.Clear();

            //Pizzák darabszámának nullázása
            UserControlPizza.Instance.darab1 = 0;
            UserControlPizza.Instance.darab2 = 0;
            UserControlPizza.Instance.darab3 = 0;
            UserControlPizza.Instance.darab4 = 0;
            UserControlPizza.Instance.darab5 = 0;
            UserControlPizza.Instance.darab6 = 0;
            UserControlPizza.Instance.darab7 = 0;
            UserControlPizza.Instance.darab8 = 0;


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
            UserControlSulthus.Instance.darab1 = 0;
            UserControlSulthus.Instance.darab2 = 0;
            UserControlSulthus.Instance.darab3 = 0;
            UserControlSulthus.Instance.darab4 = 0;
            UserControlSulthus.Instance.darab5 = 0;

            //Gyrosok darabszámának nullázása
            UserControlGyros.Instance.darab1 = 0;
            UserControlGyros.Instance.darab2 = 0;
            UserControlGyros.Instance.darab3 = 0;
            UserControlGyros.Instance.darab4 = 0;

            //Egészségs ételek darabszámának nullázása
            UserControlEgeszseges.Instance.darab1 = 0;
            UserControlEgeszseges.Instance.darab2 = 0;
            UserControlEgeszseges.Instance.darab3 = 0;
            UserControlEgeszseges.Instance.darab4 = 0;
            UserControlEgeszseges.Instance.darab5 = 0;

            //Desszertek darabszámának nullázása
            UserControlDesszert.Instance.darab1 = 0;
            UserControlDesszert.Instance.darab2 = 0;
            UserControlDesszert.Instance.darab3 = 0;
            UserControlDesszert.Instance.darab4 = 0;
            UserControlDesszert.Instance.darab5 = 0;

            //Szénsavas italok darabszámának nullázása
            UserControlSzensavas.Instance.darab1 = 0;
            UserControlSzensavas.Instance.darab2 = 0;
            UserControlSzensavas.Instance.darab3 = 0;
            UserControlSzensavas.Instance.darab4 = 0;
            UserControlSzensavas.Instance.darab5 = 0;

            //Szénsavmentes italok darabszámának nullázása
            UserControlSzensavmentes.Instance.darab1 = 0;
            UserControlSzensavmentes.Instance.darab2= 0;
            UserControlSzensavmentes.Instance.darab3 = 0;
            UserControlSzensavmentes.Instance.darab4 = 0;

            //Alkoholos italok darabszámának nullázása
            UserControlAlkoholos.Instance.darab1 = 0;
            UserControlAlkoholos.Instance.darab2 = 0;
            UserControlAlkoholos.Instance.darab3 = 0;
            UserControlAlkoholos.Instance.darab4 = 0;

            MainWindow.Instance.szamlalo = 0;
        }

        //Fizetésre váltás
        private void Fizetes_Click(object sender, RoutedEventArgs e)
        {
            SwitchScreen(new UserControlFizetes());
            UserControlFizetes.Instance.dgFizetes.ItemsSource = Kosar;
        }

        //Homescreen-re váltás
        private void LogoRow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SwitchScreen(new UserControlHome());
        }

        //Végösszeg
        public int Fizetendo()
        {
            int ossz = 0;
            foreach (var r in Kosar)
            {
                ossz = r.Ár+ossz;
            }
            return ossz;
        }
    }
}
