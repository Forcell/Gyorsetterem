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

            //beolvasás

            List<Termek> hamburger = new List<Termek>();

            hamburger = MainWindow.Instance.adat.getHamburger();

            probaHamburger.DataContext = hamburger;

            probaLabel.Content = hamburger[0].nev;
            probaAr.Content = hamburger[0].ar + " Ft";
            probaId.Content = "Id: " + hamburger[0].id;


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
