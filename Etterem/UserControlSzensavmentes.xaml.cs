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
    /// Interaction logic for UserControlSzensavmentes.xaml
    /// </summary>
    public partial class UserControlSzensavmentes : UserControl
    {
        public static UserControlSzensavmentes Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> szensavmentes = new List<Termek>();

        public UserControlSzensavmentes()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            szensavmentes = MainWindow.Instance.adat.GetSzensavmentes();

            //1. szensavmentes

            SzensavmentesNev1.Content = szensavmentes[0].nev;
            SzensavmentesAr1.Content = szensavmentes[0].ar + " Ft";
            SzensavmentesId1.Content = "Id: " + szensavmentes[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + szensavmentes[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            SzensavmentesKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            SzensavmentesKep1.Fill = brush1;

            //2. szensavmentes

            SzensavmentesNev2.Content = szensavmentes[1].nev;
            SzensavmentesAr2.Content = szensavmentes[1].ar + " Ft";
            SzensavmentesId2.Content = "Id: " + szensavmentes[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + szensavmentes[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            SzensavmentesKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            SzensavmentesKep2.Fill = brush2;

            //3. szensavmentes

            SzensavmentesNev3.Content = szensavmentes[2].nev;
            SzensavmentesAr3.Content = szensavmentes[2].ar + " Ft";
            SzensavmentesId3.Content = "Id: " + szensavmentes[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + szensavmentes[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            SzensavmentesKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            SzensavmentesKep3.Fill = brush3;

            //4. szensavmentes

            SzensavmentesNev4.Content = szensavmentes[3].nev;
            SzensavmentesAr4.Content = szensavmentes[3].ar + " Ft";
            SzensavmentesId4.Content = "Id: " + szensavmentes[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + szensavmentes[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            SzensavmentesKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            SzensavmentesKep4.Fill = brush4;

        }
        private void Szensavmentes1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavmentesNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavmentesNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavmentesNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavmentes[0].id;
            k.Név = szensavmentes[0].nev;
            k.Ár = szensavmentes[0].ar;
            k.Típus = szensavmentes[0].tipus;
            k.Altípus = szensavmentes[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Szensavmentes2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavmentesNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavmentesNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavmentesNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavmentes[1].id;
            k.Név = szensavmentes[1].nev;
            k.Ár = szensavmentes[1].ar;
            k.Típus = szensavmentes[1].tipus;
            k.Altípus = szensavmentes[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Szensavmentes3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavmentesNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavmentesNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavmentesNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavmentes[2].id;
            k.Név = szensavmentes[2].nev;
            k.Ár = szensavmentes[2].ar;
            k.Típus = szensavmentes[2].tipus;
            k.Altípus = szensavmentes[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Szensavmentes4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavmentesNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavmentesNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavmentesNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavmentes[3].id;
            k.Név = szensavmentes[3].nev;
            k.Ár = szensavmentes[3].ar;
            k.Típus = szensavmentes[3].tipus;
            k.Altípus = szensavmentes[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
    }
}

