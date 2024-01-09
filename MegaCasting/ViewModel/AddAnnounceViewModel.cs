using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    internal class AddAnnounceViewModel
    {



        private Announce _Announce;

        public Announce Announce { get => _Announce; set => _Announce = value; }



        public AddAnnounceViewModel()
        {
            Announce = new Announce();
        }


        internal void Add()
        {
            using (DbMegacastingContext context = new())
            {
                if (string.IsNullOrWhiteSpace(Announce.Title))
                {

                }
                else if (string.IsNullOrWhiteSpace(Announce.Content))
                {

                }
                {
                    context.Add(Announce);
                    context.SaveChanges();
                }
            }
        }
    }
}
