﻿using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    internal class UpdateUserViewModel { 



        private User _User;

        public User User { get => _User; set => _User = value; }



        public UpdateUserViewModel()
        {
            User = new User();
        }


        internal void Add()
        {
            using (DbMegacastingContext context = new())
            {
                if (string.IsNullOrWhiteSpace(User.Email))
                {

                }
                else if (string.IsNullOrWhiteSpace(User.Lastname))
                {

                }
                else if (string.IsNullOrWhiteSpace(User.Firstname))
                {

                }
                else if (string.IsNullOrWhiteSpace(User.Password))
                {

                }
                else
                {
                    context.Add(User);
                    context.SaveChanges();
                }
            }
        }
    }
}
