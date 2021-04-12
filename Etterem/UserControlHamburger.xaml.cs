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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Etterem
{
    /// <summary>
    /// Interaction logic for UserControlHamburger.xaml
    /// </summary>
    public partial class UserControlHamburger : UserControl
    {
        public static UserControlHamburger Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> hamburger = new List<Termek>();


        public UserControlHamburger()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból


            hamburger = MainWindow.Instance.adat.GetHamburger();

            //Hamburger1.DataContext = hamburger;

            //1. hamburger
            HamburgerNev1.Content = hamburger[0].nev;
            HamburgerAr1.Content = hamburger[0].ar + " Ft";
            HamburgerId1.Content = "Id: " + hamburger[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + hamburger[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            HamburgerKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            HamburgerKep1.Fill = brush1;

            //2. hamburger

            HamburgerNev2.Content = hamburger[1].nev;
            HamburgerAr2.Content = hamburger[1].ar + " Ft";
            HamburgerId2.Content = "Id: " + hamburger[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + hamburger[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            HamburgerKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            HamburgerKep2.Fill = brush2;

            //3. hamburger

            HamburgerNev3.Content = hamburger[2].nev;
            HamburgerAr3.Content = hamburger[2].ar + " Ft";
            HamburgerId3.Content = "Id: " + hamburger[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + hamburger[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            HamburgerKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            HamburgerKep3.Fill = brush3;

            //4. hamburger

            HamburgerNev4.Content = hamburger[3].nev;
            HamburgerAr4.Content = hamburger[3].ar + " Ft";
            HamburgerId4.Content = "Id: " + hamburger[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + hamburger[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            HamburgerKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            HamburgerKep4.Fill = brush4;

            //5. hamburger

            HamburgerNev5.Content = hamburger[4].nev;
            HamburgerAr5.Content = hamburger[4].ar + " Ft";
            HamburgerId5.Content = "Id: " + hamburger[4].id;

            ImageBrush brush5 = new ImageBrush();
            Uri uri5 = new Uri("Images/" + hamburger[4].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info5 = Application.GetResourceStream(uri5);
            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.StreamSource = info5.Stream;
            image5.CacheOption = BitmapCacheOption.OnDemand;
            image5.EndInit();
            HamburgerKep5.Stretch = Stretch.Fill;
            brush5.ImageSource = image5;
            HamburgerKep5.Fill = brush5;


            //ENEMY_BLOB

        }

        private void Hamburger1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;
            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HamburgerNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev1.Content + " * " + darab1);
             }
            //Számláló
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();
            int rendeltdb = 0;
            for(int i=0; i<MainWindow.Instance.Kosar.Count();i++)
            {
                if(MainWindow.Instance.Kosar[i].id==hamburger[0].id)
                {
                    MainWindow.Instance.Kosar[i].db++;
                    break;
                }
                else
                {
                    KosarTermek k = new KosarTermek();
                    k.ar = hamburger[0].ar;
                    k.nev = hamburger[0].nev;
                    k.tipus = hamburger[0].tipus;
                    k.altipus = hamburger[0].altipus;
                    k.db = rendeltdb;
                    MainWindow.Instance.Kosar.Add(k);
                }
            }
            
        }

        private void Hamburger2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HamburgerNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();
        }

        private void Hamburger3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HamburgerNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();
        }

        private void Hamburger4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HamburgerNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();
        }

        private void Hamburger5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab5++;

            if (darab5 > 1)
            {
                darab6 = darab5 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HamburgerNev5.Content + " * " + darab5);
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev5.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HamburgerNev5.Content + " * " + darab5);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();
        }

    }
}
