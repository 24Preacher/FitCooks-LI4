﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FitCooks.Models;

namespace FitCooks.shared
{
    public class UserHandling
    {
        private readonly UserContext _context;
        public UserHandling(UserContext context)
        {
            _context = context;
        }

        public User[] getUsers()
        {
            return _context.user.ToArray();
        }

        public User getUser(int id)
        {
            return _context.user.Find(id);
        }

        public bool validateUser(User user)
        {
            user.password = MyHelpers.HashPassword(user.password);
            var returnedUser = _context.user.Where(b => b.username == user.username && b.password == user.password).FirstOrDefault();

            if (returnedUser == null)
            {
                return false;
            }
            return true;
        }

        public bool registerUser(User user)
        {
            user.password = MyHelpers.HashPassword(user.password);
            _context.user.Add(user);
            _context.SaveChanges();
            return true;
        }

       


    }
}
