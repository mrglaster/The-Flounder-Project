using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glossa_App.Data.Repository.Interfaces
{
    internal interface IAuthenticationRepository
    {
        public Task<string> AuthenticateUser(string _login, string _password);
        public Task<string> RegistrationUser(string _login, string _password, string _email);
    }
}
