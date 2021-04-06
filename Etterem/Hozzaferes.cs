using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Etterem
{
    public class Hozzaferes
    {

        public List<Megrendelő> getMegrendelo()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                var rendelo = kapcsolat.Query<Megrendelő>("select * from Megrendelo").ToList();

                return rendelo;
            }
        }
        public List<Termek> getPizza()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                var pizza = kapcsolat.Query<Termek>("select * from Termek").ToList();

                return pizza;
            }
        }

        public string getNev()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                var lbl = kapcsolat.Query<string>("select nev from Termek").ToList();

                return lbl[0];
            }
        }

        public string getKep()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                var im = kapcsolat.Query<string>("select nev from Termek").ToList();

                return im[0];
            }
        }
    }
}
