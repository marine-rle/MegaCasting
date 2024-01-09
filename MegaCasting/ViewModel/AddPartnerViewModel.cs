using MegaCasting.Class; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    class AddPartnerViewModel
    {
        // Champ privé représentant un objet Partner
        private Partner _Partner;

        // Propriété publique exposant l'objet Partner, avec accesseurs en lecture et écriture
        public Partner Partner { get => _Partner; set => _Partner = value; }

        // Constructeur par défaut initialisant un nouvel objet Partner lors de la création du ViewModel
        public AddPartnerViewModel()
        {
            Partner = new Partner();
        }

        // Méthode interne permettant d'ajouter un partenaire à la base de données
        internal void Add()
        {
            using (DbMegacastingContext context = new())
            {
                // Vérification que les champs essentiels du partenaire ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(Partner.Label)
                    || string.IsNullOrWhiteSpace(Partner.SIRET)
                    || string.IsNullOrWhiteSpace(Partner.Description)))
                {
                    // Ajout du partenaire à la base de données et sauvegarde des modifications
                    context.Add(Partner);
                    context.SaveChanges();
                }
            }
        }
    }
}
