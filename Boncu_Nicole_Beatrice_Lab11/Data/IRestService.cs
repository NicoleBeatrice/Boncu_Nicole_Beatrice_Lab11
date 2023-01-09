using System.Threading.Tasks;
using Boncu_Nicole_Beatrice_Lab11.Models;


namespace Boncu_Nicole_Beatrice_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
