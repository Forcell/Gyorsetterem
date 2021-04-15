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
    /// Interaction logic for UserControlAlkoholos.xaml
    /// </summary>
    public partial class UserControlAlkoholos : UserControl
    {
        public static UserControlAlkoholos Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public List<Termek> alkoholos = new List<Termek>();

        public UserControlAlkoholos()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            alkoholos = MainWindow.Instance.adat.GetAlkoholos();

            //1. alkoholos

            AlkoholosNev1.Content = alkoholos[0].nev;
            AlkoholosAr1.Content = alkoholos[0].ar + " Ft";
            AlkoholosId1.Content = "Id: " + alkoholos[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + alkoholos[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            AlkoholosKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            AlkoholosKep1.Fill = brush1;

            //2. alkoholos

            AlkoholosNev2.Content = alkoholos[1].nev;
            AlkoholosAr2.Content = alkoholos[1].ar + " Ft";
            AlkoholosId2.Content = "Id: " + alkoholos[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + alkoholos[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            AlkoholosKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            AlkoholosKep2.Fill = brush2;

            //3. alkoholos

            AlkoholosNev3.Content = alkoholos[2].nev;
            AlkoholosAr3.Content = alkoholos[2].ar + " Ft";
            AlkoholosId3.Content = "Id: " + alkoholos[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + alkoholos[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            AlkoholosKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            AlkoholosKep3.Fill = brush3;

            //4. alkoholos

            AlkoholosNev4.Content = alkoholos[3].nev;
            AlkoholosAr4.Content = alkoholos[3].ar + " Ft";
            AlkoholosId4.Content = "Id: " + alkoholos[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + alkoholos[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            AlkoholosKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            AlkoholosKep4.Fill = brush4;

        }
        private void Alkoholos1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab6 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(AlkoholosNev1.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(AlkoholosNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(AlkoholosNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = alkoholos[0].id;
            k.Név = alkoholos[0].nev;
            k.Ár = alkoholos[0].ar;
            k.Típus = alkoholos[0].tipus;
            k.Altípus = alkoholos[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Alkoholos2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab6 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(AlkoholosNev2.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(AlkoholosNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(AlkoholosNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = alkoholos[1].id;
            k.Név = alkoholos[1].nev;
            k.Ár = alkoholos[1].ar;
            k.Típus = alkoholos[1].tipus;
            k.Altípus = alkoholos[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Alkoholos3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab6 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(AlkoholosNev3.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(AlkoholosNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(AlkoholosNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = alkoholos[2].id;
            k.Név = alkoholos[2].nev;
            k.Ár = alkoholos[2].ar;
            k.Típus = alkoholos[2].tipus;
            k.Altípus = alkoholos[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Alkoholos4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab6 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(AlkoholosNev4.Content + " * " + darab6);
                MainWindow.Instance.KosarLista.Items.Add(AlkoholosNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(AlkoholosNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = alkoholos[3].id;
            k.Név = alkoholos[3].nev;
            k.Ár = alkoholos[3].ar;
            k.Típus = alkoholos[3].tipus;
            k.Altípus = alkoholos[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
    }
}

