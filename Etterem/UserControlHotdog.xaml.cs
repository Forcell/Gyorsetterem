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
    public partial class UserControlHotdog : UserControl
    {
        public static UserControlHotdog Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> hotdog = new List<Termek>();

        public UserControlHotdog()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            
            

            hotdog = MainWindow.Instance.adat.GetHotdog();

            //1. hotdog
            HotdogNev1.Content = hotdog[0].nev;
            HotdogAr1.Content = hotdog[0].ar + " Ft";
            HotdogId1.Content = "Id: " + hotdog[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + hotdog[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            HotdogKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            HotdogKep1.Fill = brush1;

            //2. hotdog

            HotdogNev2.Content = hotdog[1].nev;
            HotdogAr2.Content = hotdog[1].ar + " Ft";
            HotdogId2.Content = "Id: " + hotdog[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + hotdog[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            HotdogKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            HotdogKep2.Fill = brush2;

            //3. hotdog

            HotdogNev3.Content = hotdog[2].nev;
            HotdogAr3.Content = hotdog[2].ar + " Ft";
            HotdogId3.Content = "Id: " + hotdog[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + hotdog[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            HotdogKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            HotdogKep3.Fill = brush3;

            //4. hotdog

            HotdogNev4.Content = hotdog[3].nev;
            HotdogAr4.Content = hotdog[3].ar + " Ft";
            HotdogId4.Content = "Id: " + hotdog[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + hotdog[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            HotdogKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            HotdogKep4.Fill = brush4;

            //5. hotdog

            HotdogNev5.Content = hotdog[4].nev;
            HotdogAr5.Content = hotdog[4].ar + " Ft";
            HotdogId5.Content = "Id: " + hotdog[4].id;

            ImageBrush brush5 = new ImageBrush();
            Uri uri5 = new Uri("Images/" + hotdog[4].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info5 = Application.GetResourceStream(uri5);
            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.StreamSource = info5.Stream;
            image5.CacheOption = BitmapCacheOption.OnDemand;
            image5.EndInit();
            HotdogKep5.Stretch = Stretch.Fill;
            brush5.ImageSource = image5;
            HotdogKep5.Fill = brush5;

        }
        private void Hotdog1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HotdogNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev1.Content + " * " + darab1);
            }

            //Számláló
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = hotdog[0].id;
            k.Név = hotdog[0].nev;
            k.Ár = hotdog[0].ar;
            k.Típus = hotdog[0].tipus;
            k.Altípus = hotdog[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Hotdog2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HotdogNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = hotdog[1].id;
            k.Név = hotdog[1].nev;
            k.Ár = hotdog[1].ar;
            k.Típus = hotdog[1].tipus;
            k.Altípus = hotdog[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Hotdog3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HotdogNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = hotdog[2].id;
            k.Név = hotdog[2].nev;
            k.Ár = hotdog[2].ar;
            k.Típus = hotdog[2].tipus;
            k.Altípus = hotdog[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Hotdog4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HotdogNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = hotdog[3].id;
            k.Név = hotdog[3].nev;
            k.Ár = hotdog[3].ar;
            k.Típus = hotdog[3].tipus;
            k.Altípus = hotdog[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Hotdog5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab5++;

            if (darab5 > 1)
            {
                darab6 = darab5 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(HotdogNev5.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev5.Content + " * " + darab5);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(HotdogNev5.Content + " * " + darab5);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = hotdog[4].id;
            k.Név = hotdog[4].nev;
            k.Ár = hotdog[4].ar;
            k.Típus = hotdog[4].tipus;
            k.Altípus = hotdog[4].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
    }
}
