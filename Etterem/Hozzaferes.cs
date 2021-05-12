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
        //Pizzák kinyerése adatbázisból
        public List<Termek> GetPizza()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> pizza = kapcsolat.Query<Termek>("select * from Termek WHERE altipus='Pizza'").ToList();

                return pizza;
            }
        }

        //Hamburgerek kinyerése adatbázisból
        public List<Termek> GetHamburger()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> hamburger = kapcsolat.Query<Termek>("select * from Termek WHERE altipus='Hamburger'").ToList();

                return hamburger;
            }
        }

        //Hotdogok kinyerése adatbázisból
        public List<Termek> GetHotdog()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> hotdog = kapcsolat.Query<Termek>("select * from Termek WHERE altipus='Hot Dog'").ToList();

                return hotdog;
            }
        }

        //Tészták kinyerése adatbázisból
        public List<Termek> GetTeszta()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> teszta = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Tészta'").ToList();

                return teszta;
            }
        }

        //Sülthúsok kinyerése adatbázisból
        public List<Termek> GetSulthus()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> sulthus = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Sülthús'").ToList();

                return sulthus;
            }
        }

        //Gyrosok kinyerése adatbázisból
        public List<Termek> GetGyros()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> gyros = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Gyros'").ToList();

                return gyros;
            }
        }

        //Egésséges ételek kinyerése adatbázisból
        public List<Termek> GetEgeszseges()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> egeszseges = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Egészséges'").ToList();

                return egeszseges;
            }
        }

        //Desszertek kinyerése adatbázisból
        public List<Termek> GetDesszert()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> desszert = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Desszert'").ToList();

                return desszert;
            }
        }

        //Szénsavas italok kinyerése adatbázisból
        public List<Termek> GetSzensavas()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> szensavas = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Szénsavas'").ToList();

                return szensavas;
            }
        }

        //Szénsavmentes italok kinyerése adatbázisból
        public List<Termek> GetSzensavmentes()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> szensavmentes = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Szénsavmentes'").ToList();

                return szensavmentes;
            }
        }

        //Alkoholos italok kinyerése adatbázisból
        public List<Termek> GetAlkoholos()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Termek> alkoholos = kapcsolat.Query<Termek>("SELECT * FROM Termek WHERE altipus='Alkoholos'").ToList();

                return alkoholos;
            }
        }

        //Id-k növelése rendelésenkként
        public int GetId()
        {
            List<Rendeles> rendelesLista;

            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                rendelesLista = kapcsolat.Query<Rendeles>("SELECT * FROM rendeles").ToList();

                if(rendelesLista.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return rendelesLista.Count();
                }
            }
        }

        //Leadott rendelés adatbázisba írása
        public void RendelesLead(Rendeles rendelve)
        { 
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                kapcsolat.Execute("INSERT INTO Rendeles (id, nev, telefon, cim, rendelve) values (@id, @nev, @telefon, @cim, @rendelve)", rendelve);
            }
        }

        //Rendelés megjelenítése
        public List<Rendeles> GetRendelesek()
        {
            using (IDbConnection kapcsolat = new SQLiteConnection(Kapcsolat.Kapcsolodas("dtbEtterem")))
            {
                List<Rendeles> rendelesek = kapcsolat.Query<Rendeles>("SELECT * FROM Rendeles").ToList();

                return rendelesek;
            }
        }
    }
}
