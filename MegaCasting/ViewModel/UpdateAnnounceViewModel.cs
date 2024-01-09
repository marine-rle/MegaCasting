using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    internal class UpdateAnnounceViewModel
    {

        private Announce _Announce;

        public Announce Announce { get => _Announce; set => _Announce = value; }



        public UpdateAnnounceViewModel(int identifierAnnounce)
        {
            using (DbMegacastingContext context = new())
            {
                Announce = context.Announces.First(announceTemp => announceTemp.ID == identifierAnnounce);
            }
        }


        internal void Update()
        {
            using (DbMegacastingContext context = new())
            {
                if (!(string.IsNullOrWhiteSpace(Announce.Title)
                   || string.IsNullOrWhiteSpace(Announce.Content)
                   || (Announce.StartDate == null))
                   || (Announce.EndDate == null))
                {
                    context.Update(Announce);
                    context.SaveChanges();
                }
            }
        }
    }
}
