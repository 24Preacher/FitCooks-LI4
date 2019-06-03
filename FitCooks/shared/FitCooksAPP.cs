using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FitCooks.Models;
using static FitCooks.Models.Utilizador;

namespace FitCooks.shared
{
    public class FitcooksAPP
    {
        private FitCooksContext _context;


        public FitcooksAPP(FitCooksContext context)
        {
            _context = context;
        }

        public Utilizador[] getUsers()
        {
            return _context.utilizadores.ToArray();
        }

        public bool validateUser(Utilizador user)
        {
            user.password = MyHelpers.HashPassword(user.password);
            var returnedUser = _context.utilizadores.Where(b => b.username == user.username && b.password == user.password).FirstOrDefault();

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
            string username = user.username;
            int query = _context.utilizadores.Where(u => u.username == username).Count();
        
            if(query != 0)
            {
                return false;
            }

            user.password = MyHelpers.HashPassword(user.password);
            _context.utilizadores.Add(user);
            _context.SaveChanges();
            return true;
        }

        
    }
}
