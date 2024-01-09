using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    class AddUserViewModel
    {
        // Champ privé pour stocker l'objet User
        private User _User;

        // Propriété publique pour accéder à l'objet User
        public User User { get => _User; set => _User = value; }

        // Constructeur par défaut qui initialise un nouvel objet User
        public AddUserViewModel()
        {
            User = new User();
        }

        // Méthode interne permettant d'ajouter un utilisateur à la base de données
        internal void Add()
        {
            using (DbMegacastingContext context = new())
            {
                // Vérification que les champs ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(User.Lastname)
                     || string.IsNullOrWhiteSpace(User.Firstname)
                     || string.IsNullOrWhiteSpace(User.Email)
                     || string.IsNullOrWhiteSpace(User.Password)))
                {
                    // Ajout de l'utilisateur à la base de données et sauvegarde des modifications
                    context.Add(User);
                    context.SaveChanges();
                }
            }
        }
    }
}
