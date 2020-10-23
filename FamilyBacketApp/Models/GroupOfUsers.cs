using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBacketApp.Models
{
    class GroupOfUsers
    {
        ICollection<User> users;
        ItemList groupLisOfItemToBuy;
        public GroupOfUsers() {
            users = new List<User>();
        }
    }
}
