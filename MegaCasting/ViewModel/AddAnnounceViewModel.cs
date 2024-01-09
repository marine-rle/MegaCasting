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
        // Champ privé représentant une annonce
        private Announce _Announce;

        // Propriété publique permettant l'accès à l'annonce
        public Announce Announce { get => _Announce; set => _Announce = value; }

        // Constructeur par défaut de la classe
        public AddAnnounceViewModel()
        {
            // Initialisation de l'annonce lors de la création de l'objet
            Announce = new Announce();
        }

        // Méthode interne pour ajouter une annonce à la base de données
        internal void Add()
        {
            using (DbMegacastingContext context = new())
            {
                // Vérification des conditions avant d'ajouter l'annonce à la base de données
                if (!(string.IsNullOrWhiteSpace(Announce.Title)
                     || string.IsNullOrWhiteSpace(Announce.Content)
                     || (Announce.StartDate == null)
                     || (Announce.EndDate == null)))
                {
                    // Ajout de l'annonce au contexte de base de données
                    context.Add(Announce);

                    // Sauvegarde des modifications dans la base de données
                    context.SaveChanges();
                }
            }
        }
    }
}
