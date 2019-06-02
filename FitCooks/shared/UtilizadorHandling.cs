using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FitCooks.Models;

namespace FitCooks.shared
{
    public class UtilizadorHandling
    {
        private readonly UtilizadorContext _context;
        

        public UtilizadorHandling(UtilizadorContext context)
        {
            _context = context;
        }

        public Utilizador[] getUsers()
        {
            return _context.utilizador.ToArray();
        }

        public bool validateUser(Utilizador user)
        {
            user.password = MyHelpers.HashPassword(user.password);
            var returnedUser = _context.utilizador.Where(b => b.username == user.username && b.password == user.password).FirstOrDefault();

            if (returnedUser == null)
            {
                return false;
            }
            return true;
        }

        internal bool getUser(string nome)
        {
            throw new NotImplementedException();
        }

        public bool registerUser(Utilizador user)
        {
            //string username = user.username;
            //if (_context.utilizador.Find(keyValues: username) != username)
            //{
                user.password = MyHelpers.HashPassword(user.password);
                _context.utilizador.Add(user);
                _context.SaveChanges();
                return true;
            }
            
        }
    }
