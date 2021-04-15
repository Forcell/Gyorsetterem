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
    /// Interaction logic for UserControlSzensavas.xaml
    /// </summary>
    public partial class UserControlSzensavas : UserControl
    {
        public static UserControlSzensavas Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> szensavas = new List<Termek>();

        public UserControlSzensavas()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            szensavas = MainWindow.Instance.adat.GetSzensavas();

            //1. szensavas

            SzensavasNev1.Content = szensavas[0].nev;
            SzensavasAr1.Content = szensavas[0].ar + " Ft";
            SzensavasId1.Content = "Id: " + szensavas[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + szensavas[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            SzensavasKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            SzensavasKep1.Fill = brush1;

            //2. szensavas

            SzensavasNev2.Content = szensavas[1].nev;
            SzensavasAr2.Content = szensavas[1].ar + " Ft";
            SzensavasId2.Content = "Id: " + szensavas[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + szensavas[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            SzensavasKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            SzensavasKep2.Fill = brush2;

            //3. szensavas

            SzensavasNev3.Content = szensavas[2].nev;
            SzensavasAr3.Content = szensavas[2].ar + " Ft";
            SzensavasId3.Content = "Id: " + szensavas[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + szensavas[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            SzensavasKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            SzensavasKep3.Fill = brush3;

            //4. szensavas

            SzensavasNev4.Content = szensavas[3].nev;
            SzensavasAr4.Content = szensavas[3].ar + " Ft";
            SzensavasId4.Content = "Id: " + szensavas[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + szensavas[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            SzensavasKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            SzensavasKep4.Fill = brush4;

            //5. szensavas

            SzensavasNev5.Content = szensavas[4].nev;
            SzensavasAr5.Content = szensavas[4].ar + " Ft";
            SzensavasId5.Content = "Id: " + szensavas[4].id;

            ImageBrush brush5 = new ImageBrush();
            Uri uri5 = new Uri("Images/" + szensavas[4].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info5 = Application.GetResourceStream(uri5);
            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.StreamSource = info5.Stream;
            image5.CacheOption = BitmapCacheOption.OnDemand;
            image5.EndInit();
            SzensavasKep5.Stretch = Stretch.Fill;
            brush5.ImageSource = image5;
            SzensavasKep5.Fill = brush5;

        }
        private void Szensavas1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavasNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavas[0].id;
            k.Név = szensavas[0].nev;
            k.Ár = szensavas[0].ar;
            k.Típus = szensavas[0].tipus;
            k.Altípus = szensavas[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Szensavas2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavasNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavas[1].id;
            k.Név = szensavas[1].nev;
            k.Ár = szensavas[1].ar;
            k.Típus = szensavas[1].tipus;
            k.Altípus = szensavas[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Szensavas3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavasNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavas[2].id;
            k.Név = szensavas[2].nev;
            k.Ár = szensavas[2].ar;
            k.Típus = szensavas[2].tipus;
            k.Altípus = szensavas[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Szensavas4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavasNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavas[3].id;
            k.Név = szensavas[3].nev;
            k.Ár = szensavas[3].ar;
            k.Típus = szensavas[3].tipus;
            k.Altípus = szensavas[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Szensavas5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab5++;

            if (darab5 > 1)
            {
                darab6 = darab5 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(SzensavasNev5.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev5.Content + " * " + darab5);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(SzensavasNev5.Content + " * " + darab5);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = szensavas[4].id;
            k.Név = szensavas[4].nev;
            k.Ár = szensavas[4].ar;
            k.Típus = szensavas[4].tipus;
            k.Altípus = szensavas[4].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }

    }
}

