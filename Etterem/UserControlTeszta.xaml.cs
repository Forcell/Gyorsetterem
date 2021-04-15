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
    /// Interaction logic for UserControlTeszta.xaml
    /// </summary>
    public partial class UserControlTeszta : UserControl
    {
        public static UserControlTeszta Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> teszta = new List<Termek>();

        public UserControlTeszta()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            teszta = MainWindow.Instance.adat.GetTeszta();

            //1. teszta

            TesztaNev1.Content = teszta[0].nev;
            TesztaAr1.Content = teszta[0].ar + " Ft";
            TesztaId1.Content = "Id: " + teszta[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + teszta[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            TesztaKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            TesztaKep1.Fill = brush1;

            //2. teszta

            TesztaNev2.Content = teszta[1].nev;
            TesztaAr2.Content = teszta[1].ar + " Ft";
            TesztaId2.Content = "Id: " + teszta[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + teszta[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            TesztaKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            TesztaKep2.Fill = brush2;

            //3. teszta

            TesztaNev3.Content = teszta[2].nev;
            TesztaAr3.Content = teszta[2].ar + " Ft";
            TesztaId3.Content = "Id: " + teszta[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + teszta[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            TesztaKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            TesztaKep3.Fill = brush3;

            //4. teszta

            TesztaNev4.Content = teszta[3].nev;
            TesztaAr4.Content = teszta[3].ar + " Ft";
            TesztaId4.Content = "Id: " + teszta[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + teszta[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            TesztaKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            TesztaKep4.Fill = brush4;

            //5. teszta

            TesztaNev5.Content = teszta[4].nev;
            TesztaAr5.Content = teszta[4].ar + " Ft";
            TesztaId5.Content = "Id: " + teszta[4].id;

            ImageBrush brush5 = new ImageBrush();
            Uri uri5 = new Uri("Images/" + teszta[4].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info5 = Application.GetResourceStream(uri5);
            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.StreamSource = info5.Stream;
            image5.CacheOption = BitmapCacheOption.OnDemand;
            image5.EndInit();
            TesztaKep5.Stretch = Stretch.Fill;
            brush5.ImageSource = image5;
            TesztaKep5.Fill = brush5;

        }
        private void Teszta1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(TesztaNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = teszta[0].id;
            k.Név = teszta[0].nev;
            k.Ár = teszta[0].ar;
            k.Típus = teszta[0].tipus;
            k.Altípus = teszta[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Teszta2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(TesztaNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = teszta[1].id;
            k.Név = teszta[1].nev;
            k.Ár = teszta[1].ar;
            k.Típus = teszta[1].tipus;
            k.Altípus = teszta[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Teszta3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(TesztaNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = teszta[2].id;
            k.Név = teszta[2].nev;
            k.Ár = teszta[2].ar;
            k.Típus = teszta[2].tipus;
            k.Altípus = teszta[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Teszta4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(TesztaNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = teszta[3].id;
            k.Név = teszta[3].nev;
            k.Ár = teszta[3].ar;
            k.Típus = teszta[3].tipus;
            k.Altípus = teszta[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Teszta5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab5++;

            if (darab5 > 1)
            {
                darab6 = darab5 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(TesztaNev5.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev5.Content + " * " + darab5);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(TesztaNev5.Content + " * " + darab5);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = teszta[4].id;
            k.Név = teszta[4].nev;
            k.Ár = teszta[4].ar;
            k.Típus = teszta[4].tipus;
            k.Altípus = teszta[4].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }

    }
}

