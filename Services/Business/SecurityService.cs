using Learning01ADN.Models;
using Learning01ADN.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning01ADN.Services.Business
{
    public class SecurityService
    {
        SecurityDAO daoService = new SecurityDAO();

        public bool Authenticate(UserModel user)
        {
            return daoService.FindByUser(user);
        }
    }
}