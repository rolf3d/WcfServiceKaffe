using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kaffe;
namespace WcfServiceKaffe
{
    public  class Bestilling
    {

       static  List<Kaffe> kaffeListe = new List<Kaffe>();

        // min klon builde
        public void BestilKaffe(Kaffe kaffe)
        {
            kaffeListe.Add(kaffe);
        }

        public Bestilling()
        {
            //kaffeListe = new List<Kaffe>();
        }

        public int AntalBestillinger()
        {
            return kaffeListe.Count();
        }


    }
}