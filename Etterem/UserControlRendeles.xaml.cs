using MaterialDesignThemes.Wpf;
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

    public partial class UserControlRendeles : UserControl
    {
        public static UserControlRendeles Instance;
        public UserControlRendeles()
        {
            Instance = this;
            InitializeComponent();
        }

        //Vissza gomb
        private void btVissza_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.SwitchScreen(new UserControlFizetes());
        }

        //Rendelés végleges leadása gomb
        private void btRendelesLeadas_Click(object sender, RoutedEventArgs e)
        {
            //Adatok meglétének ellenőrzése, ha nincsenek meg piros aláhúzás
            if (RendelNev.Text.Length == 0 || RendelTelefon.Text.Length == 0 || RendelCim.Text.Length == 0)
            {
                if (RendelNev.Text.Length == 0)
                {
                    TextFieldAssist.SetUnderlineBrush(RendelNev, Brushes.Red);
                }
                else
                {
                    TextFieldAssist.SetUnderlineBrush(RendelNev, Brushes.White);
                }

                if (RendelTelefon.Text.Length == 0)
                {
                    TextFieldAssist.SetUnderlineBrush(RendelTelefon, Brushes.Red);
                }
                else
                {
                    TextFieldAssist.SetUnderlineBrush(RendelTelefon, Brushes.White);
                }

                if (RendelCim.Text.Length == 0)
                {
                    TextFieldAssist.SetUnderlineBrush(RendelCim, Brushes.Red);
                }
                else
                {
                    TextFieldAssist.SetUnderlineBrush(RendelCim, Brushes.White);
                }
            }
            else
            {
                //Terméknév a leadott rendelésnél
                List<string> rendelesnev = new List<string>();
                foreach (var k in MainWindow.Instance.Kosar)
                {

                    rendelesnev.Add(k.Név);
                }

                //Adatbázisba illesztés
                Rendeles megrendelt = new Rendeles(MainWindow.Instance.adat.GetId(), RendelNev.Text, RendelTelefon.Text, RendelCim.Text, string.Join(", ",rendelesnev));
                MainWindow.Instance.adat.RendelesLead(megrendelt);

                //Kosár ürítése
                MainWindow.Instance.KosarLista.Items.Clear();

                //Fenti kosárba lévő termékék nullázása
                MainWindow.Instance.KosarOsszesDarab.Text = "0";

                //Kosár ürítése a fizetés oldalon
                MainWindow.Instance.Kosar.Clear();

                //Pizzák darabszámának nullázása
                UserControlPizza.Instance.darab1 = 0;
                UserControlPizza.Instance.darab2 = 0;
                UserControlPizza.Instance.darab3 = 0;
                UserControlPizza.Instance.darab4 = 0;
                UserControlPizza.Instance.darab5 = 0;
                UserControlPizza.Instance.darab6 = 0;
                UserControlPizza.Instance.darab7 = 0;
                UserControlPizza.Instance.darab8 = 0;

                //Hotdogok darabszámának nullázása
                UserControlHotdog.Instance.darab1 = 0;
                UserControlHotdog.Instance.darab2 = 0;
                UserControlHotdog.Instance.darab3 = 0;
                UserControlHotdog.Instance.darab4 = 0;
                UserControlHotdog.Instance.darab5 = 0;

                //Hamburgerek darabszámának nullázása
                UserControlHamburger.Instance.darab1 = 0;
                UserControlHamburger.Instance.darab2 = 0;
                UserControlHamburger.Instance.darab3 = 0;
                UserControlHamburger.Instance.darab4 = 0;
                UserControlHamburger.Instance.darab5 = 0;

                //Tészták darabszámának nullázása
                UserControlTeszta.Instance.darab1 = 0;
                UserControlTeszta.Instance.darab2 = 0;
                UserControlTeszta.Instance.darab3 = 0;
                UserControlTeszta.Instance.darab4 = 0;
                UserControlTeszta.Instance.darab5 = 0;

                //Sülthúsok darabszámának nullázása
                UserControlSulthus.Instance.darab1 = 0;
                UserControlSulthus.Instance.darab2 = 0;
                UserControlSulthus.Instance.darab3 = 0;
                UserControlSulthus.Instance.darab4 = 0;
                UserControlSulthus.Instance.darab5 = 0;

                //Gyrosok darabszámának nullázása
                UserControlGyros.Instance.darab1 = 0;
                UserControlGyros.Instance.darab2 = 0;
                UserControlGyros.Instance.darab3 = 0;
                UserControlGyros.Instance.darab4 = 0;

                //Egészségs ételek darabszámának nullázása
                UserControlEgeszseges.Instance.darab1 = 0;
                UserControlEgeszseges.Instance.darab2 = 0;
                UserControlEgeszseges.Instance.darab3 = 0;
                UserControlEgeszseges.Instance.darab4 = 0;
                UserControlEgeszseges.Instance.darab5 = 0;

                //Desszertek darabszámának nullázása
                UserControlDesszert.Instance.darab1 = 0;
                UserControlDesszert.Instance.darab2 = 0;
                UserControlDesszert.Instance.darab3 = 0;
                UserControlDesszert.Instance.darab4 = 0;
                UserControlDesszert.Instance.darab5 = 0;

                //Szénsavas italok darabszámának nullázása
                UserControlSzensavas.Instance.darab1 = 0;
                UserControlSzensavas.Instance.darab2 = 0;
                UserControlSzensavas.Instance.darab3 = 0;
                UserControlSzensavas.Instance.darab4 = 0;
                UserControlSzensavas.Instance.darab5 = 0;

                //Szénsavmentes italok darabszámának nullázása
                UserControlSzensavmentes.Instance.darab1 = 0;
                UserControlSzensavmentes.Instance.darab2 = 0;
                UserControlSzensavmentes.Instance.darab3 = 0;
                UserControlSzensavmentes.Instance.darab4 = 0;

                //Alkoholos italok darabszámának nullázása
                UserControlAlkoholos.Instance.darab1 = 0;
                UserControlAlkoholos.Instance.darab2 = 0;
                UserControlAlkoholos.Instance.darab3 = 0;
                UserControlAlkoholos.Instance.darab4 = 0;

                //Számláló nullázása
                MainWindow.Instance.szamlalo = 0;

                //Ablakváltás
                MainWindow.Instance.SwitchScreen(new UserControlThankYou());
            }
        }
    }
}
