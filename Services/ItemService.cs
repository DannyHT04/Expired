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

        public bool AddItem(ItemModel newItemModel)
        {
            _context.Add(newItemModel);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<ItemModel> GetAllUserItemsByUserId(int userId)
        {
            return _context.ItemInfo.Where(item => item.UserId == userId);
        }

        public ItemModel GetItemById(int id)
        {
            return _context.ItemInfo.SingleOrDefault(item => item.Id == id);
        }

        ///////////////DO WE NEED THIS??//////////////////
        // public ItemModel GetByProductName(string ProductName)
        // {
        //     return _context.ItemInfo.SingleOrDefault(item => item.ProductName == ProductName);
        // }

        public IEnumerable<ItemModel> GetByDateOfExpiration(string DateOfExpiration)
        {
            return _context.ItemInfo.Where(item => item.DateOfExpiration == DateOfExpiration);
        }

        public IEnumerable<ItemModel> GetByOwner(string Owner)
        {
            return _context.ItemInfo.Where(item => item.Owner == Owner);
        }

        public IEnumerable<ItemModel> GetByCategory(string Category)
        {
            return _context.ItemInfo.Where(item => item.Category == Category);
        }

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
        
   
        // group grocery List
        // if item is in a group AND isGroceryList = true
        // then return all items that is true to group list


        // public bool AddItemToGroceryList(GroupModel newGroupModel)
        // {
        //     bool result = false;
        //     if(!DoesGroupExist)
           

        //     GroupModel Id = ItemModel GroupId
    
        // }



             // user grocery list
        // if the item of the user isGroceryList = True
        // then return all items that is true to user's grocery list



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
    }
}