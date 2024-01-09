// InfoUserViewModel.cs
using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

namespace MegaCasting.ViewModel
{
    internal class InfoUserViewModel
    {
        // Champ privé pour stocker l'objet User.
        private User _User;

        // Propriété publique permettant d'accéder et de définir l'objet User.
        public User User
        {
            get => _User; 
            set => _User = value; 
        }

        // Constructeur de la classe prenant en paramètre l'identifiant de l'utilisateur.
        public InfoUserViewModel(int identifierUser)
        {
            using (DbMegacastingContext context = new())
            {
                // Récupération du premier utilisateur correspondant à l'identifiant spécifié.
                User = context.Users.First(user => user.Id == identifierUser);
            }
        }
    }
}
