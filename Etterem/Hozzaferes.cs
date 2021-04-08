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

        public List<Megrendelő> GetMegrendelo()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                var rendelo = kapcsolat.Query<Megrendelő>("select * from Megrendelo").ToList();

                return rendelo;
            }
        }
        public List<Termek> GetHamburger()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> hamburger = kapcsolat.Query<Termek>("select * from Termek WHERE altipus='Hamburger'").ToList();

                return hamburger;
            }
        }
        public List<Termek> GetHotdog()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> hotdog = kapcsolat.Query<Termek>("select * from Termek WHERE altipus='Hot Dog'").ToList();

                return hotdog;
            }
        }
        public List<Termek> GetTeszta()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> teszta = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Tészta'").ToList();

                return teszta;
            }
        }
    }
}
