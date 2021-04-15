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
    /// Interaction logic for UserControlSulthus.xaml
    /// </summary>
    public partial class UserControlSulthus : UserControl
    {
        public static UserControlSulthus Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> sulthus = new List<Termek>();

        public UserControlSulthus()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            sulthus = MainWindow.Instance.adat.GetSulthus();

            //1. sulthus

            SulthusNev1.Content = sulthus[0].nev;
            SulthusAr1.Content = sulthus[0].ar + " Ft";
            SulthusId1.Content = "Id: " + sulthus[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + sulthus[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            SulthusKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            SulthusKep1.Fill = brush1;

            //2. sulthus

            SulthusNev2.Content = sulthus[1].nev;
            SulthusAr2.Content = sulthus[1].ar + " Ft";
            SulthusId2.Content = "Id: " + sulthus[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + sulthus[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            SulthusKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            SulthusKep2.Fill = brush2;

            //3. sulthus

            SulthusNev3.Content = sulthus[2].nev;
            SulthusAr3.Content = sulthus[2].ar + " Ft";
            SulthusId3.Content = "Id: " + sulthus[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + sulthus[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            SulthusKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            SulthusKep3.Fill = brush3;

            //4. sulthus

            SulthusNev4.Content = sulthus[3].nev;
            SulthusAr4.Content = sulthus[3].ar + " Ft";
            SulthusId4.Content = "Id: " + sulthus[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + sulthus[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            SulthusKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            SulthusKep4.Fill = brush4;

            //5. sulthus

            SulthusNev5.Content = sulthus[4].nev;
            SulthusAr5.Content = sulthus[4].ar + " Ft";
            SulthusId5.Content = "Id: " + sulthus[4].id;

            ImageBrush brush5 = new ImageBrush();
            Uri uri5 = new Uri("Images/" + sulthus[4].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info5 = Application.GetResourceStream(uri5);
            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.StreamSource = info5.Stream;
            image5.CacheOption = BitmapCacheOption.OnDemand;
            image5.EndInit();
            SulthusKep5.Stretch = Stretch.Fill;
            brush5.ImageSource = image5;
            SulthusKep5.Fill = brush5;

        }
        private void Sulthus1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SulthusNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = sulthus[0].id;
            k.Név = sulthus[0].nev;
            k.Ár = sulthus[0].ar;
            k.Típus = sulthus[0].tipus;
            k.Altípus = sulthus[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Sulthus2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SulthusNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = sulthus[1].id;
            k.Név = sulthus[1].nev;
            k.Ár = sulthus[1].ar;
            k.Típus = sulthus[1].tipus;
            k.Altípus = sulthus[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Sulthus3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SulthusNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = sulthus[2].id;
            k.Név = sulthus[2].nev;
            k.Ár = sulthus[2].ar;
            k.Típus = sulthus[2].tipus;
            k.Altípus = sulthus[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Sulthus4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SulthusNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = sulthus[3].id;
            k.Név = sulthus[3].nev;
            k.Ár = sulthus[3].ar;
            k.Típus = sulthus[3].tipus;
            k.Altípus = sulthus[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Sulthus5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab5++;

            if (darab5 > 1)
            {
                darab6 = darab5 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SulthusNev5.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev5.Content + " * " + darab5);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SulthusNev5.Content + " * " + darab5);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = sulthus[4].id;
            k.Név = sulthus[4].nev;
            k.Ár = sulthus[4].ar;
            k.Típus = sulthus[4].tipus;
            k.Altípus = sulthus[4].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }

    }
}

