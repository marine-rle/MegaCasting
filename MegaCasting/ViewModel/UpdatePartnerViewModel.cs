using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Tls;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    internal class UpdatePartnerViewModel
    {
        // Champ privé pour stocker l'objet Partner à mettre à jour
        private Partner _Partner;

        // Propriété publique permettant d'accéder et de définir l'objet Partner
        public Partner Partner { get => _Partner; set => _Partner = value; }

        // Constructeur de la classe prenant l'identifiant du partenaire à mettre à jour en paramètre
        public UpdatePartnerViewModel(int identifierPartner)
        {
            using (DbMegacastingContext context = new())
            {
                // Récupération du partenaire à mettre à jour en fonction de son identifiant
                Partner = context.Partners.First(partnerTemp => partnerTemp.ID == identifierPartner);
            }
        }

        // Méthode interne permettant de mettre à jour les informations du partenaire
        internal void Update()
        {
            using (DbMegacastingContext context = new())
            {
                // Vérification que les champs obligatoires du partenaire ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(Partner.Label)
                   || string.IsNullOrWhiteSpace(Partner.SIRET)
                   || string.IsNullOrWhiteSpace(Partner.Description)))
                {
                    // Mise à jour de l'objet Partner dans la base de données
                    context.Update(Partner);

                    // Sauvegarde des modifications dans la base de données
                    context.SaveChanges();
                }
            }
        }
    }
}
