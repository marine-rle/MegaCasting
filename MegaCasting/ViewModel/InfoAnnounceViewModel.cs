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

        // Propriété publique permettant d'accéder et de définir la valeur du champ _Announce
        public Announce Announce
        {
            get => _Announce; // Obtient la valeur du champ _Announce
            set => _Announce = value; // Définit la valeur du champ _Announce
        }

        // Constructeur de la classe prenant un identifiant d'annonce en paramètre
        public InfoAnnounceViewModel(int identifierAnnounce)
        {
            using (DbMegacastingContext context = new())
            {
                // Récupération de la première annonce correspondant à l'identifiant spécifié
                Announce = context.Announces.First(announce => announce.ID == identifierAnnounce);
            }
        }
    }
}
