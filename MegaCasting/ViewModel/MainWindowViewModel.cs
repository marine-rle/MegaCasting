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

        private ObservableCollection<User> _Users;

        private User? _SelectedUser;


        private ObservableCollection<Partner> _Partners;
        private Partner? _SelectedPartner;

        private ObservableCollection<Announce> _Announces;
        private Announce? _SelectedAnnounce;

        #endregion

        #region Properties

        public ObservableCollection<User> Users { get => _Users; set => _Users = value; }

        public User? SelectedUser { get => _SelectedUser; set => _SelectedUser = value; }

        public ObservableCollection<Partner> Partners { get => _Partners; set => _Partners = value; }

        public Partner? SelectedPartner { get => _SelectedPartner; set => _SelectedPartner = value; }

        public ObservableCollection<Announce> Announces { get => _Announces; set => _Announces = value; }
        public Announce? SelectedAnnounce { get => _SelectedAnnounce; set => _SelectedAnnounce = value; }

        #endregion

        #region Constructors


        public MainWindowViewModel()
        {
            using (DbMegacastingContext context = new())
            {
                Users = new ObservableCollection<User>(context.Users.ToList());
                Partners = new ObservableCollection<Partner>(context.Partners.ToList());
                Announces = new ObservableCollection<Announce>(context.Announces.ToList());
            }
         
        }

        #endregion


        internal void UpdateUser()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedUser);
                context.SaveChanges();
            }
        }

        internal void UpdatePartner()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedPartner);
                context.SaveChanges();
            }
        }

        internal void UpdateAnnounce()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedAnnounce);
                context.SaveChanges();
            }
        }


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



        internal void RemoveUser()
        {

            using (DbMegacastingContext context = new())
            {
                context.Users.Remove(SelectedUser);
                context.SaveChanges();
                Users.Remove(SelectedUser);
            }
        }

        internal void RemovePartner()
        {

            using (DbMegacastingContext context = new())
            {
                context.Partners.Remove(SelectedPartner);
                context.SaveChanges();
                Partners.Remove(SelectedPartner);
            }
        }

        internal void RemoveAnnounce()
        {

            using (DbMegacastingContext context = new())
            {
                context.Announces.Remove(SelectedAnnounce);
                context.SaveChanges();
                Announces.Remove(SelectedAnnounce);
            }
        }

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