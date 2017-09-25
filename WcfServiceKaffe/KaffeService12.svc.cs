using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceKaffe
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class KaffeService : IKaffeService
    {
        Bestilling bestilling; 

        public KaffeService()
        {
             bestilling = new Bestilling();
        }

        //tilføjer en sort kaffe
        public void BestilSortKaffe()
        {
            var sortKaffe = new SortKaffe();
            bestilling.BestilKaffe(sortKaffe);
        }

        public int GetAntalBestillinger()
        {
            return bestilling.AntalBestillinger();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetStyrkeSortKaffe()
        {
            var sortkaffe = new SortKaffe();

            var cordat = new Cortado();

            return sortkaffe.Styrke();
        }
    }
}
