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
using System.Windows.Shapes;

namespace Etterem
{
    /// <summary>
    /// Interaction logic for UserControlHotdog.xaml
    /// </summary>
    /// 


    public partial class UserControlHotdog : UserControl
    {
        public static UserControlHotdog Instance;

        public UserControlHotdog()
        {
            Instance = this;
            InitializeComponent();

            //beolvasás adatbázisból
            
            List<Termek> hotdog = new List<Termek>();

            hotdog = MainWindow.Instance.adat.getHotdog();

            //1. hamburger
            HotdogNev1.Content = hotdog[0].nev;
            HotdogAr1.Content = hotdog[0].ar + " Ft";
            HotdogId1.Content = "Id: " + hotdog[0].id;

            //2. hamburger

            HotdogNev2.Content = hotdog[1].nev;
            HotdogAr2.Content = hotdog[1].ar + " Ft";
            HotdogId2.Content = "Id: " + hotdog[1].id;

            //3. hamburger

            HotdogNev3.Content = hotdog[2].nev;
            HotdogAr3.Content = hotdog[2].ar + " Ft";
            HotdogId3.Content = "Id: " + hotdog[2].id;

            //4. hamburger

            HotdogNev4.Content = hotdog[3].nev;
            HotdogAr4.Content = hotdog[3].ar + " Ft";
            HotdogId4.Content = "Id: " + hotdog[3].id;

            //5. hamburger

            HotdogNev5.Content = hotdog[4].nev;
            HotdogAr5.Content = hotdog[4].ar + " Ft";
            HotdogId5.Content = "Id: " + hotdog[4].id;



        }
    }
}
