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
    /// Interaction logic for UserControlDesszert.xaml
    /// </summary>
    public partial class UserControlDesszert : UserControl
    {
        public static UserControlDesszert Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> desszert = new List<Termek>();

        public UserControlDesszert()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            desszert = MainWindow.Instance.adat.GetDesszert();

            //1. desszert

            DesszertNev1.Content = desszert[0].nev;
            DesszertAr1.Content = desszert[0].ar + " Ft";
            DesszertId1.Content = "Id: " + desszert[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + desszert[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            DesszertKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            DesszertKep1.Fill = brush1;

            //2. desszert

            DesszertNev2.Content = desszert[1].nev;
            DesszertAr2.Content = desszert[1].ar + " Ft";
            DesszertId2.Content = "Id: " + desszert[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + desszert[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            DesszertKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            DesszertKep2.Fill = brush2;

            //3. desszert

            DesszertNev3.Content = desszert[2].nev;
            DesszertAr3.Content = desszert[2].ar + " Ft";
            DesszertId3.Content = "Id: " + desszert[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + desszert[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            DesszertKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            DesszertKep3.Fill = brush3;

            //4. desszert

            DesszertNev4.Content = desszert[3].nev;
            DesszertAr4.Content = desszert[3].ar + " Ft";
            DesszertId4.Content = "Id: " + desszert[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + desszert[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            DesszertKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            DesszertKep4.Fill = brush4;

            //5. desszert

            DesszertNev5.Content = desszert[4].nev;
            DesszertAr5.Content = desszert[4].ar + " Ft";
            DesszertId5.Content = "Id: " + desszert[4].id;

            ImageBrush brush5 = new ImageBrush();
            Uri uri5 = new Uri("Images/" + desszert[4].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info5 = Application.GetResourceStream(uri5);
            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.StreamSource = info5.Stream;
            image5.CacheOption = BitmapCacheOption.OnDemand;
            image5.EndInit();
            DesszertKep5.Stretch = Stretch.Fill;
            brush5.ImageSource = image5;
            DesszertKep5.Fill = brush5;

        }
        private void Desszert1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(DesszertNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = desszert[0].id;
            k.Név = desszert[0].nev;
            k.Ár = desszert[0].ar;
            k.Típus = desszert[0].tipus;
            k.Altípus = desszert[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Desszert2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(DesszertNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = desszert[1].id;
            k.Név = desszert[1].nev;
            k.Ár = desszert[1].ar;
            k.Típus = desszert[1].tipus;
            k.Altípus = desszert[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Desszert3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(DesszertNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = desszert[2].id;
            k.Név = desszert[2].nev;
            k.Ár = desszert[2].ar;
            k.Típus = desszert[2].tipus;
            k.Altípus = desszert[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Desszert4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(DesszertNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = desszert[3].id;
            k.Név = desszert[3].nev;
            k.Ár = desszert[3].ar;
            k.Típus = desszert[3].tipus;
            k.Altípus = desszert[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Desszert5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab5++;

            if (darab5 > 1)
            {
                darab6 = darab5 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(DesszertNev5.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev5.Content + " * " + darab5);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(DesszertNev5.Content + " * " + darab5);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = desszert[4].id;
            k.Név = desszert[4].nev;
            k.Ár = desszert[4].ar;
            k.Típus = desszert[4].tipus;
            k.Altípus = desszert[4].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }

    }
}

