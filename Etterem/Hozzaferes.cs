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
        public List<Termek> GetPizza()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> pizza = kapcsolat.Query<Termek>("select * from Termek WHERE altipus='Pizza'").ToList();

                return pizza;
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

        public List<Termek> GetSulthus()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> sulthus = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Sülthús'").ToList();

                return sulthus;
            }
        }

        public List<Termek> GetGyros()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> gyros = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Gyros'").ToList();

                return gyros;
            }
        }
        public List<Termek> GetEgeszseges()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> egeszseges = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Egészséges'").ToList();

                return egeszseges;
            }
        }
        public List<Termek> GetDesszert()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> desszert = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Desszert'").ToList();

                return desszert;
            }
        }
        public List<Termek> GetSzensavas()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> szensavas = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Szénsavas'").ToList();

                return szensavas;
            }
        }
        public List<Termek> GetSzensavmentes()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> szensavmentes = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Szénsavmentes'").ToList();

                return szensavmentes;
            }
        }
        public List<Termek> GetAlkoholos()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> alkoholos = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Alkoholos'").ToList();

                return alkoholos;
            }
        }
    }
}
