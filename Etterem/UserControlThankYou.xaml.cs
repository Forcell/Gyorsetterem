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
            Rendeles[] t = MainWindow.Instance.adat.GetRendelesek().ToArray();

            //Message-box
            string msgbx = "Rendelési adatok";
            MessageBox.Show("Azonosító:\t" + t[t.Length-1].id + "\nNév:\t\t" + t[t.Length - 1].nev + "\nTelefonszám:\t" + t[t.Length - 1].telefon + "\nCím:\t\t" + t[t.Length - 1].cim + "\nRendelt termékek:\t" + t[t.Length - 1].rendelve + "\n\nFizetendő:\t\t" + UserControlFizetes.Instance.tbVegosszeg.Text, msgbx);

            //Ablakváltás
            MainWindow.Instance.SwitchScreen(new UserControlHome());
        }
    }
}
