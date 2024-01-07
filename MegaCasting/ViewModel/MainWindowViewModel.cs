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

        #endregion

        #region Properties

        public ObservableCollection<User> Users { get => _Users; set => _Users = value; }

        public User? SelectedUser { get => _SelectedUser; set => _SelectedUser = value; }

        public ObservableCollection<Partner> Partners { get => _Partners; set => _Partners = value; }

        public Partner? SelectedPartner { get => _SelectedPartner; set => _SelectedPartner = value; }

        #endregion

        #region Constructors


        public MainWindowViewModel()
        {
            using (DbMegacastingContext context = new())
            {
                Users = new ObservableCollection<User>(context.Users.ToList());
                Partners = new ObservableCollection<Partner>(context.Partners.ToList());
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

        internal void Refresh()
        {
            this.Users.Clear();
            this.Partners.Clear();

            using (DbMegacastingContext context = new())
            {
                context.Users.ToList().ForEach(userTemp => this.Users.Add(userTemp));
                context.Partners.ToList().ForEach(partnerTemp => this.Partners.Add(partnerTemp));
            }
        }
    }
}