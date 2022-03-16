using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpiredBack.Models;
using ExpiredBack.Services.Context;

namespace Expired.Services
{
    public class ItemService
    {
        private readonly DataContext _context;

        public ItemService (DataContext context)
        {
            _context = context;
        }

        public bool AddItem(ItemModel newItemModel)
        {
            _context.Add(newItemModel);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<ItemModel>GetAllItems()
        {
            return _context.ItemInfo;
        }

        public ItemModel GetItemById(int id)
        {
            return _context.ItemInfo.SingleOrDefault( item => item.Id == id);
        }

        public IEnumerable<ItemModel> GetItemByUserId(int UserId)
        {
            return _context = ItemInfo.Where(item => item.UserId == UserId);
        }

        public IEnumerable<ItemModel> GetByProductName(string ProductName)
        {
            return _context = ItemInfo.Where( item => item.ProductName == productName);
        }

        public IEnumerable<ItemModel> GetByDateOfExpiration(string DateOfExpiration)
        {
            return _context = ItemInfo.Where( item => item.DateOfExpiration == DateOfExpiration);
        }

        public IEnumerable<ItemModel> GetByOwner (string Owner)
        {
            return _context = ItemInfo.Where( item => item.Owner == Owner);
        }

        public IEnumerable<ItemModel> GetByCategory(string Category)
        {
            return _context = ItemInfo.Where( item => item.Category == Category);
        }

        public IEnumerable<ItemModel> GetGroceryList(string isGroceryList)
        {
            return _context = ItemInfo.Where( item => item.isGroceryList == isGroceryList);
        }

        public IEnumerable<ItemModel> GetIsDeleted(bool isDeleted)
        {
            return _context = ItemInfo.Where( item => item.isDeleted == isDeleted);
        }
    }
}