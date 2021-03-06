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
    /// Interaction logic for UserControlGyros.xaml
    /// </summary>
    public partial class UserControlGyros : UserControl
    {
        public static UserControlGyros Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> gyros = new List<Termek>();

        public UserControlGyros()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            gyros = MainWindow.Instance.adat.GetGyros();

            //1. gyros

            GyrosNev1.Content = gyros[0].nev;
            GyrosAr1.Content = gyros[0].ar + " Ft";
            GyrosId1.Content = "Id: " + gyros[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + gyros[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            GyrosKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            GyrosKep1.Fill = brush1;

            //2. gyros

            GyrosNev2.Content = gyros[1].nev;
            GyrosAr2.Content = gyros[1].ar + " Ft";
            GyrosId2.Content = "Id: " + gyros[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + gyros[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            GyrosKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            GyrosKep2.Fill = brush2;

            //3. gyros

            GyrosNev3.Content = gyros[2].nev;
            GyrosAr3.Content = gyros[2].ar + " Ft";
            GyrosId3.Content = "Id: " + gyros[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + gyros[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            GyrosKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            GyrosKep3.Fill = brush3;

            //4. gyros

            GyrosNev4.Content = gyros[3].nev;
            GyrosAr4.Content = gyros[3].ar + " Ft";
            GyrosId4.Content = "Id: " + gyros[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + gyros[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            GyrosKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            GyrosKep4.Fill = brush4;


        }
        private void Gyros1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(GyrosNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(GyrosNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(GyrosNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = gyros[0].id;
            k.Név = gyros[0].nev;
            k.Ár = gyros[0].ar;
            k.Típus = gyros[0].tipus;
            k.Altípus = gyros[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Gyros2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(GyrosNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(GyrosNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(GyrosNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = gyros[1].id;
            k.Név = gyros[1].nev;
            k.Ár = gyros[1].ar;
            k.Típus = gyros[1].tipus;
            k.Altípus = gyros[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Gyros3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(GyrosNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(GyrosNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(GyrosNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = gyros[2].id;
            k.Név = gyros[2].nev;
            k.Ár = gyros[2].ar;
            k.Típus = gyros[2].tipus;
            k.Altípus = gyros[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Gyros4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(GyrosNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(GyrosNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(GyrosNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = gyros[3].id;
            k.Név = gyros[3].nev;
            k.Ár = gyros[3].ar;
            k.Típus = gyros[3].tipus;
            k.Altípus = gyros[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
    }
}

