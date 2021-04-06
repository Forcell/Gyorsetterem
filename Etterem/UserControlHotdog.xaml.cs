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
        }
    }
}
