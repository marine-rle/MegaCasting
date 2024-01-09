using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

namespace MegaCasting.ViewModel
{
    internal class InfoPartnerViewModel
    {
        // Champ privé représentant un objet Partner
        private Partner _Partner;

        // Propriété publique permettant l'accès en lecture et en écriture à l'objet Partner
        public Partner Partner
        {
            get => _Partner;
            set => _Partner = value;
        }

        // Constructeur de la classe prenant l'identifiant du partenaire en paramètre
        public InfoPartnerViewModel(int identifierPartner)
        {
            using (DbMegacastingContext context = new())
            {
                // Récupération du premier partenaire dans la base de données ayant l'identifiant spécifié
                Partner = context.Partners.First(partner => partner.ID == identifierPartner);
            }
        }
    }
}
