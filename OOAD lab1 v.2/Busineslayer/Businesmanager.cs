using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer
{
    public class Businesmanager /*: IBusinesmanager*/
    {
        private Anställd InLoggad { get; set; }
        private DataStore DataStore { get; }

        public Businesmanager()
        {
            DataStore = new DataStore();
        }

        public Anställd LoggaIn(int Nr, string lösen)
        {
            InLoggad = DataStore.LoggaIn(Nr, lösen);
            return InLoggad;
        }

        public Anställd VisaAnställd()
        {
            return InLoggad;
        }

        public List<Bok> GetTillgängligaBöcker()
        {
            return DataStore.GetTillgängligaBöcker();
        }

        public List<Bok> GetUpptagnaBöcker()
        {
            return DataStore.GetUpptagnaBöcker();
        }

        public int SkapaBokning(int MID, List<Bok> böcker)
        {
            int BNR = DataStore.SkapaBokning(MID, InLoggad, böcker);
            return BNR;
        }

        public int AvslutaBokning(int ID)
        {
            return DataStore.AvslutaBokning(ID);
        }

        public List<Bokning> GetBokningar()
        {
            return DataStore.GetBokningar();
        }

        public DateTime GetBokningTime(int ID)
        {
            return DataStore.GetBokningTime(ID);
        }
    }
}
