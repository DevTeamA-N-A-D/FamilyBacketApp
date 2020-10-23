using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBacketApp.Models
{
    public class ItemList
    {
        ICollection<itemToBuy> ListofItems;
        public ItemList() {
            ListofItems = new List<itemToBuy>();
        }
    }
}
