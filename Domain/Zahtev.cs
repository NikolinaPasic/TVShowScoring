using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }
    }

    public enum Operacija
    {
        PrijaviKorisnika,
        Kraj,
        RegistrujNovogKorisnika,
        VratiGlumce,
        ObrisiGlumca,
        IzmeniGlumca,
        DodajSeriju,
        VratiSerije,
        IzmeniSeriju,
        VratiUloge,
        DodajRecenziju,
        DodajGlumca,
        VratiZanrove,
        ObrisiSeriju,
        VratiSerijuPoKriterijumu,
        VratiGlumcePoKriterijumu,
        VratiTipove,
        KrajServer
    }
}
