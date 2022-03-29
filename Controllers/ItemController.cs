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

        public IEnumerable<ItemModel> GetAllUserItemsByUserId(int userId)
        {
            return _data.GetAllUserItemsByUserId(userId);
        }
        // geting all group items
        [HttpGet("GetAllGroupItems/{GroupId}")]

        public IEnumerable<ItemModel> GetAllGroupItems(int GroupId)
        {
            return _data.GetAllUserItemsByUserId(GroupId);
        }

        //Get Items by their Id
        [HttpGet("GetItemById/{Id}")]
        public ItemModel GetItemById(int Id)
        {
            return _data.GetItemById(Id);
        }
        
        //Getting the expiration of that item
        [HttpGet("GetByDateOfExpiration/{DateOfExpiration}")]
        public IEnumerable<ItemModel> GetByDateOfExpiration(string DateOfExpiration)
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
        public IEnumerable<ItemModel> GetByCategory(string Category)
        {
            return _data.GetByCategory(Category);
        }

        //Add To Grocery List by ID
        [HttpPost("AddToGroceryList/{Id}")]
        public bool AddToGroceryList(int Id)
        {
            return _data.AddToGroceryList(Id);
        }

        [HttpGet("GetGroceryListByUserId/{UserId}")]
        public IEnumerable<ItemModel> GetGroceryListByUserId(int UserId)
        {
            return _data.GetGroceryListByUserId(UserId);
        }

        [HttpGet("GetGroceryListByGroupId/{GroupId}")]
        public IEnumerable<ItemModel> GetGroceryListByGroupId(int GroupId)
        {
            return _data.GetGroceryListByGroupId(GroupId);
        }

        //Delete an Item by item id
        [HttpPost("DeleteItem/{Id}")]
        public bool DeleteItem(int Id)
        {
            return _data.DeleteItem(Id);
        }

        [HttpPost("UpdateItem")]
        public bool UpdateItem(ItemModel ItemToUpdate)
        {
            return _data.UpdateItem(ItemToUpdate);
        }
    }
}