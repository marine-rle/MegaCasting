using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Tls;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    internal class UpdateUserViewModel {

        // Champ privé pour stocker l'utilisateur à mettre à jour
        private User _User;

        // Propriété publique pour accéder et définir l'utilisateur
        public User User { get => _User; set => _User = value; }

        // Constructeur de la classe prenant l'identifiant de l'utilisateur en paramètre
        public UpdateUserViewModel(int identifierUser)
        {
            using (DbMegacastingContext context = new())
            {
                User = context.Users.First(userTemp => userTemp.Id == identifierUser);
            }
        }

        // Méthode interne pour effectuer la mise à jour de l'utilisateur dans la base de données
        internal void Update()
        {
            using (DbMegacastingContext context = new())
            {
                // Vérification que les champs obligatoires ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(User.Email)
                   || string.IsNullOrWhiteSpace(User.Lastname)
                   || string.IsNullOrWhiteSpace(User.Firstname)
                   || string.IsNullOrWhiteSpace(User.Password)))
                {
                    // Mise à jour de l'utilisateur dans le contexte de la base de données
                    context.Update(User);

                    // Sauvegarde des modifications dans la base de données
                    context.SaveChanges();
                }
            }
        }
    }
}
