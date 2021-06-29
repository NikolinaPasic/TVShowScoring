using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokerBB;
using Domen;
namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected Broker broker = new Broker();
        protected abstract void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat);
        protected abstract void Validacija(DomenskiObjekat objekat);
        public void Izvrsi(DomenskiObjekat objekat)
        {
            try
            {
                Validacija(objekat);
                broker.OtvoriKonekciju();
                broker.PokreniTransakciju();
                IzvrsiKonkretnuOperaciju(objekat);
                broker.CommitTransakcije();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                broker.RollbackTransakcije();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

    }
}
