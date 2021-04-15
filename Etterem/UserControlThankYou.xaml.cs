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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Etterem
{
    /// <summary>
    /// Interaction logic for UserControlThankYou.xaml
    /// </summary>
    public partial class UserControlThankYou : UserControl
    {
        public UserControlThankYou()
        {
            InitializeComponent();
        }

        private void btVissza_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.SwitchScreen(new UserControlHome());
        }
    }
}
