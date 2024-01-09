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

        // Champ privé représentant une annonce
        private Announce _Announce;

        // Propriété publique permettant d'accéder à l'annonce et de la modifier
        public Announce Announce { get => _Announce; set => _Announce = value; }

        // Constructeur de la classe prenant en paramètre l'identifiant d'une annonce
        public UpdateAnnounceViewModel(int identifierAnnounce)
        {
            using (DbMegacastingContext context = new())
            {
                // Récupération de la première annonce correspondant à l'identifiant donné
                Announce = context.Announces.First(announceTemp => announceTemp.ID == identifierAnnounce);
            }
        }

        // Méthode interne permettant de mettre à jour une annonce dans la base de données
        internal void Update()
        {
            using (DbMegacastingContext context = new())
            {
                // Vérification que le titre et le contenu de l'annonce ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(Announce.Title) || string.IsNullOrWhiteSpace(Announce.Content)))
                {
                    // Mise à jour de l'annonce dans la base de données
                    context.Update(Announce);
                    // Sauvegarde des modifications dans la base de données
                    context.SaveChanges();
                }
            }
        }
    }
}
