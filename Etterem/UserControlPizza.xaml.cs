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
    /// Interaction logic for UserControlPizza.xaml
    /// </summary>
    public partial class UserControlPizza : UserControl
    {
        public static UserControlPizza Instance;

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3 = 0;
        public int darab4 = 0;
        public int darab5 = 0;
        public int darab6 = 0;
        public int darab7 = 0;
        public int darab8 = 0;
        public int darab9 = 0;
        public List<Termek> pizza = new List<Termek>();

        public UserControlPizza()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            pizza = MainWindow.Instance.adat.GetPizza();

            //1. pizza

            PizzaNev1.Content = pizza[0].nev;
            PizzaAr1.Content = pizza[0].ar + " Ft";
            PizzaId1.Content = "Id: " + pizza[0].id;

            ImageBrush brush1 = new ImageBrush();
            Uri uri1 = new Uri("Images/" + pizza[0].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info1 = Application.GetResourceStream(uri1);
            BitmapImage image1 = new BitmapImage();
            image1.BeginInit();
            image1.StreamSource = info1.Stream;
            image1.CacheOption = BitmapCacheOption.OnDemand;
            image1.EndInit();
            PizzaKep1.Stretch = Stretch.Fill;
            brush1.ImageSource = image1;
            PizzaKep1.Fill = brush1;

            //2. pizza

            PizzaNev2.Content = pizza[1].nev;
            PizzaAr2.Content = pizza[1].ar + " Ft";
            PizzaId2.Content = "Id: " + pizza[1].id;

            ImageBrush brush2 = new ImageBrush();
            Uri uri2 = new Uri("Images/" + pizza[1].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info2 = Application.GetResourceStream(uri2);
            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.StreamSource = info2.Stream;
            image2.CacheOption = BitmapCacheOption.OnDemand;
            image2.EndInit();
            PizzaKep2.Stretch = Stretch.Fill;
            brush2.ImageSource = image2;
            PizzaKep2.Fill = brush2;

            //3. pizza

            PizzaNev3.Content = pizza[2].nev;
            PizzaAr3.Content = pizza[2].ar + " Ft";
            PizzaId3.Content = "Id: " + pizza[2].id;

            ImageBrush brush3 = new ImageBrush();
            Uri uri3 = new Uri("Images/" + pizza[2].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info3 = Application.GetResourceStream(uri3);
            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.StreamSource = info3.Stream;
            image3.CacheOption = BitmapCacheOption.OnDemand;
            image3.EndInit();
            PizzaKep3.Stretch = Stretch.Fill;
            brush3.ImageSource = image3;
            PizzaKep3.Fill = brush3;

            //4. pizza

            PizzaNev4.Content = pizza[3].nev;
            PizzaAr4.Content = pizza[3].ar + " Ft";
            PizzaId4.Content = "Id: " + pizza[3].id;

            ImageBrush brush4 = new ImageBrush();
            Uri uri4 = new Uri("Images/" + pizza[3].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info4 = Application.GetResourceStream(uri4);
            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.StreamSource = info4.Stream;
            image4.CacheOption = BitmapCacheOption.OnDemand;
            image4.EndInit();
            PizzaKep4.Stretch = Stretch.Fill;
            brush4.ImageSource = image4;
            PizzaKep4.Fill = brush4;

            //5. pizza

            PizzaNev5.Content = pizza[4].nev;
            PizzaAr5.Content = pizza[4].ar + " Ft";
            PizzaId5.Content = "Id: " + pizza[4].id;

            ImageBrush brush5 = new ImageBrush();
            Uri uri5 = new Uri("Images/" + pizza[4].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info5 = Application.GetResourceStream(uri5);
            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.StreamSource = info5.Stream;
            image5.CacheOption = BitmapCacheOption.OnDemand;
            image5.EndInit();
            PizzaKep5.Stretch = Stretch.Fill;
            brush5.ImageSource = image5;
            PizzaKep5.Fill = brush5;

            //6. pizza

            PizzaNev6.Content = pizza[5].nev;
            PizzaAr6.Content = pizza[5].ar + " Ft";
            PizzaId6.Content = "Id: " + pizza[5].id;

            ImageBrush brush6 = new ImageBrush();
            Uri uri6 = new Uri("Images/" + pizza[5].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info6 = Application.GetResourceStream(uri6);
            BitmapImage image6 = new BitmapImage();
            image6.BeginInit();
            image6.StreamSource = info6.Stream;
            image6.CacheOption = BitmapCacheOption.OnDemand;
            image6.EndInit();
            PizzaKep6.Stretch = Stretch.Fill;
            brush6.ImageSource = image6;
            PizzaKep6.Fill = brush6;

            //7. pizza

            PizzaNev7.Content = pizza[6].nev;
            PizzaAr7.Content = pizza[6].ar + " Ft";
            PizzaId7.Content = "Id: " + pizza[6].id;

            ImageBrush brush7 = new ImageBrush();
            Uri uri7 = new Uri("Images/" + pizza[6].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info7 = Application.GetResourceStream(uri7);
            BitmapImage image7 = new BitmapImage();
            image7.BeginInit();
            image7.StreamSource = info7.Stream;
            image7.CacheOption = BitmapCacheOption.OnDemand;
            image7.EndInit();
            PizzaKep7.Stretch = Stretch.Fill;
            brush7.ImageSource = image7;
            PizzaKep7.Fill = brush7;

            //8. pizza

            PizzaNev8.Content = pizza[7].nev;
            PizzaAr8.Content = pizza[7].ar + " Ft";
            PizzaId8.Content = "Id: " + pizza[7].id;

            ImageBrush brush8 = new ImageBrush();
            Uri uri8 = new Uri("Images/" + pizza[7].kep + ".jpg", UriKind.Relative);
            StreamResourceInfo info8 = Application.GetResourceStream(uri8);
            BitmapImage image8 = new BitmapImage();
            image8.BeginInit();
            image8.StreamSource = info8.Stream;
            image8.CacheOption = BitmapCacheOption.OnDemand;
            image8.EndInit();
            PizzaKep8.Stretch = Stretch.Fill;
            brush8.ImageSource = image8;
            PizzaKep8.Fill = brush8;

        }
        private void Pizza1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;

            if (darab1 > 1)
            {
                darab9 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(PizzaNev1.Content + " * " + darab9);
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev1.Content + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev1.Content + " * " + darab1);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = pizza[0].id;
            k.Név = pizza[0].nev;
            k.Ár = pizza[0].ar;
            k.Típus = pizza[0].tipus;
            k.Altípus = pizza[0].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Pizza2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab9 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(PizzaNev2.Content + " * " + darab9);
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev2.Content + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev2.Content + " * " + darab2);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = pizza[1].id;
            k.Név = pizza[1].nev;
            k.Ár = pizza[1].ar;
            k.Típus = pizza[1].tipus;
            k.Altípus = pizza[1].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Pizza3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab3++;

            if (darab3 > 1)
            {
                darab9 = darab3 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(PizzaNev3.Content + " * " + darab9);
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev3.Content + " * " + darab3);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev3.Content + " * " + darab3);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = pizza[2].id;
            k.Név = pizza[2].nev;
            k.Ár = pizza[2].ar;
            k.Típus = pizza[2].tipus;
            k.Altípus = pizza[2].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Pizza4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab4++;

            if (darab4 > 1)
            {
                darab9 = darab4 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(PizzaNev4.Content + " * " + darab9);
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev4.Content + " * " + darab4);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev4.Content + " * " + darab4);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = pizza[3].id;
            k.Név = pizza[3].nev;
            k.Ár = pizza[3].ar;
            k.Típus = pizza[3].tipus;
            k.Altípus = pizza[3].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }
        private void Pizza5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab5++;

            if (darab5 > 1)
            {
                darab9 = darab5 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(PizzaNev5.Content + " * " + darab9);
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev5.Content + " * " + darab5);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev5.Content + " * " + darab5);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = pizza[4].id;
            k.Név = pizza[4].nev;
            k.Ár = pizza[4].ar;
            k.Típus = pizza[4].tipus;
            k.Altípus = pizza[4].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }

        private void Pizza6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab6++;

            if (darab6 > 1)
            {
                darab9 = darab6 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(PizzaNev6.Content + " * " + darab9);
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev6.Content + " * " + darab6);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev6.Content + " * " + darab6);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = pizza[5].id;
            k.Név = pizza[5].nev;
            k.Ár = pizza[5].ar;
            k.Típus = pizza[5].tipus;
            k.Altípus = pizza[5].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }

        private void Pizza7_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab7++;

            if (darab7 > 1)
            {
                darab9 = darab7 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(PizzaNev7.Content + " * " + darab9);
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev7.Content + " * " + darab7);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev7.Content + " * " + darab7);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = pizza[6].id;
            k.Név = pizza[6].nev;
            k.Ár = pizza[6].ar;
            k.Típus = pizza[6].tipus;
            k.Altípus = pizza[6].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }

        private void Pizza8_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab8++;

            if (darab8 > 1)
            {
                darab9 = darab8 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(PizzaNev8.Content + " * " + darab9);
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev8.Content + " * " + darab8);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(PizzaNev8.Content + " * " + darab8);
            }
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();

            //Datagrid feltöltése
            KosarTermek k = new KosarTermek();
            k.ID = pizza[7].id;
            k.Név = pizza[7].nev;
            k.Ár = pizza[7].ar;
            k.Típus = pizza[7].tipus;
            k.Altípus = pizza[7].altipus;
            MainWindow.Instance.Kosar.Add(k);
        }


    }
}

