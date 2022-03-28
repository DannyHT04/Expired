using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models;
using Expired.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // public GroceryModel GetGroceryListByID (int Id)
        // {
        //     return  _context.GroceryInfo.SingleOrDefault(item => item.Id == Id);
        // }        
        // public bool DeleteItem(int Id, int UserId, int ItemId)
        // {
        //     GroceryModel DeleteGroceryItem = GetGroceryListByUserID(UserId);
        //     bool result = false;
        //     if(DeleteGroceryItem != null)
        //     {
        //         DeleteGroceryItem.Id = Id;
        //         DeleteGroceryItem.UserId = UserId;
        //         DeleteGroceryItem.ItemId = ItemId;
        //         _context.Remove<GroceryModel>(DeleteGroceryItem);
        //         result = _context.SaveChanges() != 0;
        //     }
        //     return result;
        // }

        public IEnumerable<GroceryModel> GetGroceryListByUserID(int UserId)
        {
            return _context.GroceryInfo.Where(item => item.UserId == UserId);
        }

        // public GroceryModel NewGroceryList(GroceryModel)
        // {
            
        // }
    }
}