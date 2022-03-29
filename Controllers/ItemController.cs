using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models;
using Expired.Services;
using Microsoft.AspNetCore.Mvc;

namespace Expired.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ItemService _data;

        public ItemController(ItemService dataFromService)
        {
            _data = dataFromService;
        }
        //Adding an item 
        [HttpPost("AddItem")]
        public bool AddItem(ItemModel newItem)
        {
            return  _data.AddItem(newItem);
        }
        //Getting all users items
        [HttpGet("GetAllUserItems/{userId}")]

        public IEnumerable<ItemModel>GetAllUserItemsByUserId(int userId)
        {
            return _data.GetAllUserItemsByUserId(userId);
        }

        [HttpGet("GetItemById/{Id}")]
        public ItemModel GetItemById(int Id)
        {
            return _data.GetItemById(Id);
        }
        //Getting items by users id
        [HttpGet("GetItemsByUserId/{UserId}")]

        //Getting the product name
        // [HttpGet("GetByProductName/{ProductName}")]
        // public IEnumerable<ItemModel>GetByProductName(string ProductName)
        // {
        //     return _data.GetByProductName(ProductName);
        // }
        //Getting the expiration of that item
        [HttpGet("GetByDateOfExpiration/{DateOfExpiration}")]
        public IEnumerable<ItemModel>GetByDateOfExpiration(string DateOfExpiration)
        {
            return _data.GetByDateOfExpiration(DateOfExpiration);
        }
        //Getting the owner of the item
        [HttpGet("GetByOwner/{Owner}")]
        public IEnumerable<ItemModel>GetByOwner(string Owner)
        {
            return _data.GetByOwner(Owner);
        }
        //Getting item by category
        [HttpGet("GetByCategory/{Category}")]
        public IEnumerable<ItemModel>GetByCategory(string Category)
        {
            return _data.GetByCategory(Category);
        }

        //Add Item to Grocery List
        // [HttpPost("AddItemToGroceryList/{Id}/{GroupId}")]
        // public bool AddItemToGroceryList(int Id, int GroupId)
        // {
        //     return _data.AddItemToGroceryList(Id, GroupId);
        // }

        //Add To Grocery List by ID
        [HttpPost("AddToGroceryList/{Id}")]
        public bool AddToGroceryList(int Id)
        {
            return _data.AddToGroceryList(Id);
        }

        // [HttpGet("GetByDeletedItem/{DeletedItem}")]
        // public IEnumerable<ItemModel> GetIsDeleted()
        // {
        //     return _data.GetIsDeleted();
        // }

        // [HttpPost("UpdateItem")]
        // public bool UpdateItem(ItemModel updatedItem)
        // {
        //     return _data.UpdateItem(updatedItem);
        // }

        // [HttpPost("DeleteItem")]
        // public bool DeleteItem(ItemModel deletedItem)
        // {
        //     return _data.DeleteItem(deletedItem);
        // }
    }
}