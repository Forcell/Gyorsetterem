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

        public int darab1 = 0;
        public int darab2 = 0;
        public int darab3;

        public static UserControlPizza Instance;
        public UserControlPizza()
        {
            Instance = this;
            InitializeComponent();
        }

        //Kosárba rakás
        private void pizzab1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.szamlalo++;
            darab1++;
            
            if(darab1>1)
            {
                darab3 = darab1 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(pizza1.Text + " * " + darab3);
                MainWindow.Instance.KosarLista.Items.Add(pizza1.Text + " * " + darab1);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(pizza1.Text + " * " + darab1);
            }
            
            //Számláló
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();
        }

        //Kosárba rakás
        private void pizzab2_Click(object sender, RoutedEventArgs e)
        {

            MainWindow.Instance.szamlalo++;
            darab2++;

            if (darab2 > 1)
            {
                darab3 = darab2 - 1;
                MainWindow.Instance.KosarLista.Items.Remove(pizza2.Text + " * " + darab3);
                MainWindow.Instance.KosarLista.Items.Add(pizza2.Text + " * " + darab2);
            }
            else
            {
                MainWindow.Instance.KosarLista.Items.Add(pizza2.Text + " * " + darab2);
            }

            //Számláló
            MainWindow.Instance.KosarOsszesDarab.Text = MainWindow.Instance.szamlalo.ToString();
        }
    }
}
