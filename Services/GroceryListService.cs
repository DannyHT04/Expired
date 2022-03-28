using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Services
{
    public class GroceryListService
    {
        private readonly DataContext _context;
        public GroceryListService(DataContext context)
        {
            _context = context;
        }

        public bool AddItemToGroceryList (GroceryModel newGroceryModel)
        {
            _context.Add(newGroceryModel);
            return _context.SaveChanges() != 0;
        }

        public bool DeleteItem(int Id, int UserId, int ItemId)
        {
            GroceryModel DeleteGroceryItem = GetGroceryById(Id, UserId, ItemId);
            bool result = false;
            if(DeleteGroceryItem != null)
            {
                DeleteGroceryItem.Id = id;
                DeleteGroceryItem.UserId = userId;
                DeleteGroceryItem.ItemId = itemId;
                _context.Remove<GroceryModel>(DeleteGroceryItem);
                result = _context.SaveChanges() != 0;
            }
            return result;
        }

        public GroceryModel GetGroceryListByUserID(int Id)
        {
            return _context.GroceryInfo.SingleOrDefault(item => item.id == Id);
        }

        // public GroceryModel NewGroceryList(GroceryModel)
        // {
            
        // }
    }
}