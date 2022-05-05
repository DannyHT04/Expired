using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models;
using Expired.Services.Context;
using Microsoft.AspNetCore.Mvc;

namespace Expired.Services
{
    public class ItemService
    {
        private readonly DataContext _context;

        public ItemService(DataContext context)
        {
            _context = context;
        }

        //creating items models
        public bool AddItem(ItemModel newItemModel)
        {
            _context.Add(newItemModel);

            return _context.SaveChanges() != 0;
        }

        //returns items own by the user by the user id
        public IEnumerable<ItemModel> GetAllUserItemsByUserId(int userId)
        {
            return _context.ItemInfo.Where(item => item.UserId == userId);
        }

        //returns items own by the group by the group id
        public IEnumerable<ItemModel> GetAllGroupItems(int GroupId)
        {
            return _context.ItemInfo.Where(item => item.GroupId == GroupId);
        }

        // getting the item by item's Id
        public ItemModel GetItemById(int Id)
        {
            return _context.ItemInfo.SingleOrDefault(item => item.Id == Id);
        }

        //getting item by item's expirations
        public IEnumerable<ItemModel> GetByDateOfExpiration(string DateOfExpiration)
        {
            return _context.ItemInfo.Where(item => item.DateOfExpiration == DateOfExpiration);
        }

        public IEnumerable<ItemModel> GetByOwner(string Owner)
        {
            return _context.ItemInfo.Where(item => item.Owner == Owner);
        }

        // public IEnumerable<ItemModel> GetByCategory(string Category)
        // {
        //     return _context.ItemInfo.Where(item => item.Category == Category);
        // }

        public IEnumerable<ItemModel> GetGroceryList(bool isGroceryList)
        {
            return _context.ItemInfo.Where(item => item.isGroceryList);
        }

        public IEnumerable<ItemModel> GetIsDeleted(bool isDeleted)
        {
            return _context.ItemInfo.Where(item => item.isDeleted);
        }

        public bool DoesGroupExist(int GroupId)
        {
            return _context.ItemInfo.SingleOrDefault(item => item.GroupId == GroupId) != null;
        }
        
        // change bool of isGroceryList 
        public bool AddToGroceryList(int Id)
        {
            bool result = false;
            ItemModel foundItem  = GetItemById(Id);
            if(foundItem != null)
            {
                foundItem.isGroceryList = !foundItem.isGroceryList;
                _context.Update<ItemModel>(foundItem);
                result = _context.SaveChanges() != 0;
            }
            return result;
        }

        //getting the grocery list by users
        public IEnumerable<ItemModel> GetGroceryListByUserId(int UserId)
        {
            return _context.ItemInfo.Where(item => item.UserId == UserId && item.isGroceryList == true);
        }
        //getting the grocery list by group id
        public IEnumerable<ItemModel> GetGroceryListByGroupId(int GroupId)
        {
            return _context.ItemInfo.Where(item => item.GroupId == GroupId && item.isGroceryList == true);
        }
        
        // delete an item with the item id
        public bool DeleteItem(int Id)
        {
            bool result = false;
            ItemModel foundItem = GetItemById(Id);
            if(foundItem != null)
            {
                _context.Remove<ItemModel>(foundItem);
                result = _context.SaveChanges() != 0; 
            }
            return result;
        }

        public bool UpdateItem(ItemModel ItemToUpdate)
        {
            _context.Update<ItemModel>(ItemToUpdate);
            return _context.SaveChanges() !=0;
        }
    }
}