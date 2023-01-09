using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boncu_Nicole_Beatrice_Lab11.Models;

namespace Boncu_Nicole_Beatrice_Lab11.Data
{
    public class ShoppingListDatabase
    {
        IRestService RestService;
        public ShoppingListDatabase(IRestService service)
        {
            RestService = service;
        }
        public Task<List<ShopList>> GetShopListsAsync()
        {
            return RestService.RefreshDataAsync();
        }

        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return RestService.SaveShopListAsync(item, isNewItem);
        }
        public Task DeleteShopListAsync(ShopList item)
        {
            return RestService.DeleteShopListAsync(item.ID);
        }

    }

}
