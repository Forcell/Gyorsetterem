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
    /// Interaction logic for UserControlPizza.xaml
    /// </summary>
    public partial class UserControlPizza : UserControl
    {
        public static UserControlPizza Instance;
        public UserControlPizza()
        {
            Instance = this;
            InitializeComponent();
        }
        int darab1 = 0;
        int darab2 = 0;
        private void pizzab1_Click(object sender, RoutedEventArgs e)
        {
            darab1++;
            if (MainWindow.Instance.KosárSzöveg.Text == "Üres")
            {
                MainWindow.Instance.KosárSzöveg.Text = pizza1.Text;
            }
            else
            {
                MainWindow.Instance.KosárSzöveg.Text = pizza1.Text + "x" + darab1;
            }
        }

        private void pizzab2_Click(object sender, RoutedEventArgs e)
        {
            darab2++;
            if (MainWindow.Instance.KosárSzöveg.Text == "Üres")
            {
                MainWindow.Instance.KosárSzöveg.Text = pizza2.Text;
            }
            else
            {
                MainWindow.Instance.KosárSzöveg.Text += "\n" + pizza2.Text;
            }
        }
    }
}
