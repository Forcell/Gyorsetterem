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
    /// Interaction logic for UserControlHamburger.xaml
    /// </summary>
    public partial class UserControlHamburger : UserControl
    {
        public static UserControlHamburger Instance;
        public UserControlHamburger()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból

            List<Termek> hamburger = new List<Termek>();

            hamburger = MainWindow.Instance.adat.getHamburger();

            Hamburger1.DataContext = hamburger;

            //1. hamburger
            HamburgerNev1.Content = hamburger[0].nev;
            HamburgerAr1.Content = hamburger[0].ar + " Ft";
            HamburgerId1.Content = "Id: " + hamburger[0].id;

            //2. hamburger

            HamburgerNev2.Content= hamburger[1].nev;
            HamburgerAr2.Content = hamburger[1].ar + " Ft";
            HamburgerId2.Content = "Id: " + hamburger[1].id;

            //3. hamburger

            HamburgerNev3.Content = hamburger[2].nev;
            HamburgerAr3.Content = hamburger[2].ar + " Ft";
            HamburgerId3.Content = "Id: " + hamburger[2].id;

            //4. hamburger

            HamburgerNev4.Content = hamburger[3].nev;
            HamburgerAr4.Content = hamburger[3].ar + " Ft";
            HamburgerId4.Content = "Id: " + hamburger[3].id;

            //5. hamburger

            HamburgerNev5.Content = hamburger[4].nev;
            HamburgerAr5.Content = hamburger[4].ar + " Ft";
            HamburgerId5.Content = "Id: " + hamburger[4].id;


            //kép
            ImageBrush brush = new ImageBrush();

            Uri uri = new Uri("Images/" + MainWindow.Instance.adat.getKep() + ".jpg", UriKind.Relative);
            StreamResourceInfo info = Application.GetResourceStream(uri);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = info.Stream;
            image.CacheOption = BitmapCacheOption.OnDemand;
            image.EndInit();

            probaKep.Stretch = Stretch.Fill;

            brush.ImageSource = image;

            probaKep.Fill = brush;


            //eNEMY_BLOB

        }

    }
}
