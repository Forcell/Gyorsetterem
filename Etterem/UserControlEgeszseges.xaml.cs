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
    /// Interaction logic for UserControlEgeszseges.xaml
    /// </summary>
    public partial class UserControlEgeszseges : UserControl
    {
        public static UserControlEgeszseges Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> egeszseges = new List<Termek>();

        public UserControlEgeszseges()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            egeszseges = MainWindow.Instance.adat.GetEgeszseges();

            //1. egeszseges

            EgeszsegesNev1.Content = egeszseges[0].nev;
            EgeszsegesAr1.Content = egeszseges[0].ar + " Ft";
            EgeszsegesId1.Content = "Id: " + egeszseges[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + egeszseges[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            EgeszsegesKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            EgeszsegesKep1.Fill = brush1;

            //2. egeszseges

            EgeszsegesNev2.Content = egeszseges[1].nev;
            EgeszsegesAr2.Content = egeszseges[1].ar + " Ft";
            EgeszsegesId2.Content = "Id: " + egeszseges[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + egeszseges[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            EgeszsegesKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            EgeszsegesKep2.Fill = brush2;

            //3. egeszseges

            EgeszsegesNev3.Content = egeszseges[2].nev;
            EgeszsegesAr3.Content = egeszseges[2].ar + " Ft";
            EgeszsegesId3.Content = "Id: " + egeszseges[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + egeszseges[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            EgeszsegesKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            EgeszsegesKep3.Fill = brush3;

            //4. egeszseges

            EgeszsegesNev4.Content = egeszseges[3].nev;
            EgeszsegesAr4.Content = egeszseges[3].ar + " Ft";
            EgeszsegesId4.Content = "Id: " + egeszseges[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + egeszseges[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            EgeszsegesKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            EgeszsegesKep4.Fill = brush4;

            //5. egeszseges

            EgeszsegesNev5.Content = egeszseges[4].nev;
            EgeszsegesAr5.Content = egeszseges[4].ar + " Ft";
            EgeszsegesId5.Content = "Id: " + egeszseges[4].id;

            ImageBrush brush5 = new ImageBrush();
            Uri uri5 = new Uri("Images/" + egeszseges[4].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info5 = Application.GetResourceStream(uri5);
            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.StreamSource = info5.Stream;
            image5.CacheOption = BitmapCacheOption.OnDemand;
            image5.EndInit();
            EgeszsegesKep5.Stretch = Stretch.Fill;
            brush5.ImageSource = image5;
            EgeszsegesKep5.Fill = brush5;

        }
        private void Egeszseges1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(EgeszsegesNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = egeszseges[0].id;
            k.Név = egeszseges[0].nev;
            k.Ár = egeszseges[0].ar;
            k.Típus = egeszseges[0].tipus;
            k.Altípus = egeszseges[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Egeszseges2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(EgeszsegesNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = egeszseges[1].id;
            k.Név = egeszseges[1].nev;
            k.Ár = egeszseges[1].ar;
            k.Típus = egeszseges[1].tipus;
            k.Altípus = egeszseges[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Egeszseges3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(EgeszsegesNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = egeszseges[2].id;
            k.Név = egeszseges[2].nev;
            k.Ár = egeszseges[2].ar;
            k.Típus = egeszseges[2].tipus;
            k.Altípus = egeszseges[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Egeszseges4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(EgeszsegesNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = egeszseges[3].id;
            k.Név = egeszseges[3].nev;
            k.Ár = egeszseges[3].ar;
            k.Típus = egeszseges[3].tipus;
            k.Altípus = egeszseges[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Egeszseges5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab5++;

            if (darab5 > 1)
            {
                darab6 = darab5 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(EgeszsegesNev5.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev5.Content + " * " + darab5);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(EgeszsegesNev5.Content + " * " + darab5);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = egeszseges[4].id;
            k.Név = egeszseges[4].nev;
            k.Ár = egeszseges[4].ar;
            k.Típus = egeszseges[4].tipus;
            k.Altípus = egeszseges[4].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }

    }
}

