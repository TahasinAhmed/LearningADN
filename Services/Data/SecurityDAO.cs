using Learning01ADN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning01ADN.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(UserModel user)
        {
            return (user.UserName == "Siam" && user.Password == "Secret");
            
        }
    }
}