// InfoUserViewModel.cs
using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

namespace MegaCasting.ViewModel
{
    internal class InfoUserViewModel
    {
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get => _users;
            set => _users = value;
        }

        public InfoUserViewModel()
        {
            // Initialiser la liste des utilisateurs dans le constructeur
            Users = new ObservableCollection<User>();
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (DbMegacastingContext context = new())
            {
                // Charger les utilisateurs depuis la base de données
                Users = new ObservableCollection<User>(context.Users.ToList());
            }
        }
    }
}
