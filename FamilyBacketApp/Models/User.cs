using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBacketApp.Models
{
    enum Role 
    {
        admin,
        fullPermitUser,
        limeitedPermitUser
    }
   public class User
    { 
        string Name;
        Role role;
        DateTime Bday;

       
    }
}
