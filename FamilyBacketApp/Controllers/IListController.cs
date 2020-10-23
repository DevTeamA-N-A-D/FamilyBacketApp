using FamilyBacketApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBacketApp.Controllers
{
    interface IListController
    {
        void AddItemtoList(itemToBuy item, ItemList listofItem);
        itemToBuy RemoveItemFromList(itemToBuy item, ItemList listOfItem);
    }
}
