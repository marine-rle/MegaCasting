using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    internal class InfoAnnounceViewModel
    {
        private Announce _Announce;

        public Announce Announce
        {
            get => _Announce;
            set => _Announce = value;
        }

        public InfoAnnounceViewModel(int identifierAnnounce)
        {
            using (DbMegacastingContext context = new())
            {
                Announce = context.Announces.First(announce => announce.ID == identifierAnnounce);
            }
        }
    }
}
