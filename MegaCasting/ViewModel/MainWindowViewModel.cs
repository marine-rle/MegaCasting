using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    class MainWindowViewModel
    {

        #region Fields

        // Collection d'utilisateurs
        private ObservableCollection<User> _Users;

        // Utilisateur sélectionné
        private User? _SelectedUser;

        // Collection de partenaires
        private ObservableCollection<Partner> _Partners;
        // Partenaire sélectionné
        private Partner? _SelectedPartner;

        // Collection d'annonces
        private ObservableCollection<Announce> _Announces;
        // Annonce sélectionnée
        private Announce? _SelectedAnnounce;

        #endregion


        #region Properties

        // Propriété pour accéder à la collection d'utilisateurs
        public ObservableCollection<User> Users { get => _Users; set => _Users = value; }

        // Propriété pour accéder à l'utilisateur sélectionné
        public User? SelectedUser { get => _SelectedUser; set => _SelectedUser = value; }

        // Propriété pour accéder à la collection de partenaires
        public ObservableCollection<Partner> Partners { get => _Partners; set => _Partners = value; }

        // Propriété pour accéder au partenaire sélectionné
        public Partner? SelectedPartner { get => _SelectedPartner; set => _SelectedPartner = value; }

        // Propriété pour accéder à la collection d'annonces
        public ObservableCollection<Announce> Announces { get => _Announces; set => _Announces = value; }

        // Propriété pour accéder à l'annonce sélectionnée
        public Announce? SelectedAnnounce { get => _SelectedAnnounce; set => _SelectedAnnounce = value; }

        #endregion


        #region Constructors

        // Constructeur de la classe MainWindowViewModel
        public MainWindowViewModel()
        {
            // Initialisation des collections à partir des données de la base de données
            using (DbMegacastingContext context = new())
            {
                Users = new ObservableCollection<User>(context.Users.ToList());
                Partners = new ObservableCollection<Partner>(context.Partners.ToList());
                Announces = new ObservableCollection<Announce>(context.Announces.ToList());
            }
        }

        #endregion



        // Méthode interne pour mettre à jour un utilisateur dans la base de données
        internal void UpdateUser()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedUser);
                context.SaveChanges();
            }
        }

        // Méthode interne pour mettre à jour un partenaire dans la base de données
        internal void UpdatePartner()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedPartner);
                context.SaveChanges();
            }
        }

        // Méthode interne pour mettre à jour une annonce dans la base de données
        internal void UpdateAnnounce()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedAnnounce);
                context.SaveChanges();
            }
        }

        // Méthode interne pour ajouter un utilisateur à la base de données
        internal void AddUser()
        {
            User user = new User();
            using (DbMegacastingContext context = new())
            {
                context.Users.Add(user);
                context.SaveChanges();
                Users.Add(user);
            }
        }

        // Méthode interne pour ajouter un partenaire à la base de données
        internal void AddPartner()
        {
            Partner partner = new Partner();
            using (DbMegacastingContext context = new())
            {
                context.Partners.Add(partner);
                context.SaveChanges();
                Partners.Add(partner);
            }
        }

        // Méthode interne pour ajouter une annonce à la base de données
        internal void AddAnnounce()
        {
            Announce announce = new Announce();
            using (DbMegacastingContext context = new())
            {
                context.Announces.Add(announce);
                context.SaveChanges();
                Announces.Add(announce);
            }
        }

        // Méthode interne pour supprimer un utilisateur de la base de données
        internal void RemoveUser()
        {
            using (DbMegacastingContext context = new())
            {
                context.Users.Remove(SelectedUser);
                context.SaveChanges();
                Users.Remove(SelectedUser);
            }
        }

        // Méthode interne pour supprimer un partenaire de la base de données
        internal void RemovePartner()
        {
            using (DbMegacastingContext context = new())
            {
                context.Partners.Remove(SelectedPartner);
                context.SaveChanges();
                Partners.Remove(SelectedPartner);
            }
        }

        // Méthode interne pour supprimer une annonce de la base de données
        internal void RemoveAnnounce()
        {
            using (DbMegacastingContext context = new())
            {
                context.Announces.Remove(SelectedAnnounce);
                context.SaveChanges();
                Announces.Remove(SelectedAnnounce);
            }
        }

        // Méthode interne pour rafraîchir les collections à partir de la base de données
        internal void Refresh()
        {
            this.Users.Clear();
            this.Partners.Clear();
            this.Announces.Clear();

            using (DbMegacastingContext context = new())
            {
                context.Users.ToList().ForEach(userTemp => this.Users.Add(userTemp));
                context.Partners.ToList().ForEach(partnerTemp => this.Partners.Add(partnerTemp));
                context.Announces.ToList().ForEach(announceTemp => this.Announces.Add(announceTemp));
            }
        }
    }
}