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

        [HttpPost("AddItem")]
        public bool AddItem(ItemModel newItem)
        {
            return  _data.AddItem(newItem);
        }

        [HttpGet("GetItems")]

        public IEnumerable<ItemModel>GetAllItems()
        {
            return _data.GetAllItems();
        }

        [HttpGet("GetItemsById/{Id}")]
        public ItemModel GetItemById(int Id)
        {
            return _data.GetItemById(Id);
        }

        [HttpGet("GetItemsByUserId/{UserId}")]

        public IEnumerable<ItemModel>GetItemsByUserId(int UserId)
        {
            return _data.GetItemByUserId(UserId);
        }

        [HttpGet("GetByProductName/{ProductName}")]
        public IEnumerable<ItemModel>GetByProductName(string ProductName)
        {
            return _data.GetByProductName(ProductName);
        }

        [HttpGet("GetByDateOfExpiration/{DateOfExpiration}")]
        public IEnumerable<ItemModel>GetByDateOfExpiration(string DateOfExpiration)
        {
            return _data.GetByDateOfExpiration(DateOfExpiration);
        }

        [HttpGet("GetByOwner/{Owner}")]
        public IEnumerable<ItemModel>GetByOwner(string Owner)
        {
            return _data.GetByOwner(Owner);
        }

        [HttpGet("GetByCategory/{Category}")]
        public IEnumerable<ItemModel>GetByCategory(string Category)
        {
            return _data.GetByCategory(Category);
        }

        [HttpGet("GetByGroceryList/{GrocderyList}")]
        public IEnumerable<ItemModel> GetGroceryList()
        {
            return _data.GetGroceryList();
        }

        [HttpGet("GetByDeletedItem/{DeletedItem}")]
        public IEnumerable<ItemModel> GetIsDeleted()
        {
            return _data.GetIsDeleted();
        }

        [HttpPost("UpdateItem")]
        public bool UpdateItem(ItemModel updatedItem)
        {
            return _data.UpdateItem(updatedItem);
        }

        [HttpPost("DeleteItem")]
        public bool DeleteItem(ItemModel deletedItem)
        {
            return _data.DeleteItem(deletedItem);
        }
    }
}