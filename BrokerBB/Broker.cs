using Domen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBB
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BazaSeminarski;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public int Izmeni(DomenskiObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand($"update {objekat.VratiImeKlase()} set {objekat.Izmeni()} where {objekat.VratiUslovZaTrazenje()}", connection, transaction);
            Console.WriteLine(komanda.CommandText);
            return komanda.ExecuteNonQuery();
        }

        public List<DomenskiObjekat> VratiSveSaUslovom(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {objekat.VratiImeKlase()} where {objekat.VratiUslovZaTrazenje()}";
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }

        public int Obrisi(DomenskiObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand($"delete from {objekat.VratiImeKlase()} where {objekat.VratiUslovZaTrazenje()}", connection, transaction);
            Console.WriteLine(komanda.CommandText);
            return komanda.ExecuteNonQuery();
        }   

        public List<DomenskiObjekat> VratiSve(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {objekat.VratiImeKlase()} " + $"{objekat.Join()}";
            Console.WriteLine(command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
         
            
            List<DomenskiObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();
            foreach (var item in rezultat)
            {
                Console.WriteLine(rezultat.ToString());
            }
            return rezultat;
        }

        public int Sacuvaj(DomenskiObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand("", connection, transaction);

            komanda.CommandText = $"insert into {objekat.VratiImeKlase()} ({objekat.PostaviVrednostAtributa()}) values ({objekat.VratiVrednostAtributa()})";
            Console.WriteLine(komanda.CommandText);

            return komanda.ExecuteNonQuery();
        }

        public bool sacuvajRecenziju(DomenskiObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand("", connection, transaction);
            int id = DajSledeciID(objekat);

            komanda.CommandText = $"insert into {objekat.VratiImeKlase()} values ({id}, {objekat.VratiVrednostAtributa()})";
            komanda.ExecuteNonQuery();

            Iskustvo r = (Iskustvo)objekat;
            foreach (Ocena ru in r.Ocene)
            {
                ru.Iskustvo.RedniBrojIskustva = id;
                SqlCommand komanda2 = new SqlCommand("", connection, transaction);
                komanda2.CommandText = $"insert into {ru.VratiImeKlase()} values ({ru.Iskustvo.RedniBrojIskustva}, {ru.VratiVrednostAtributa()})";
                komanda2.ExecuteNonQuery();
            }
            return true;
        }

        public int DajSledeciID(DomenskiObjekat objekat)
        {
            try
            {
                SqlCommand komanda = new SqlCommand("", connection, transaction);
                komanda.CommandText = $"select max({objekat.VratiImeID()}) from {objekat.VratiImeKlase()}";
                try
                {
                    int id = Convert.ToInt32(komanda.ExecuteScalar());
                    return id + 1;
                }
                catch (Exception)
                {

                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    
        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void CommitTransakcije()
        {
            transaction.Commit();
        }

        public void RollbackTransakcije()
        {
            transaction.Rollback();
        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public Object VratiJedan(DomenskiObjekat objekat)
        {
            DomenskiObjekat rezultat;

            SqlCommand command = new SqlCommand($"select * from {objekat.VratiImeKlase()}  {objekat.Join()} where {objekat.VratiUslovZaTrazenje()} ", connection, transaction);
            Console.WriteLine(command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            rezultat = objekat.VratiObjekat(reader);
            reader.Close();
            return rezultat;
        }
        public List<DomenskiObjekat> VratiListuPoKriterijumu(DomenskiObjekat objekat)
        {
            List<DomenskiObjekat> rezultat;

            SqlCommand command = new SqlCommand($"select * from {objekat.VratiImeKlase()}  {objekat.Join()} where {objekat.StringPretrazi()} ", connection, transaction);
            Console.WriteLine(command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            rezultat = objekat.VratiListuPoKriterijumu(reader);
            reader.Close();
            return rezultat;
        }
    }
}
