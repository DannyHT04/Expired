using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Expired.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroceryListController : ControllerBase
    {
        private readonly GroceryListService _data;
        public GroceryListController(GroceryListService dataFromService)
        {
            _data = dataFromService;
        }

        //Add an Item from item Model
        [HttpPost("AddItemToGroceryList/{GroceryListId}/{UserId}/{ItemId}")]
        public bool AddItemToGroceryList(int Id, int UserId, int ItemId)
        {
            return _data.AddItemToGroceryList(Id, UserId, ItemId);
        }

        //Delete an Item
        [HttpPost("DeleteItem/{Id}/{UserId}/{ItemId}")]
        public bool DeleteItem(int Id, int UserId, int ItemId)
        {
            return _data.DeleteItem(Id, UserId, ItemId);
        }

        //Get Grocery List for User
        [HttpGet("GetGroceryListByUserID/{UserId}")]
        public GroceryModel GetGroceryListByUserID(int userId)
        {
            return _data.GetGroceryListByUserID(userId);
        }

        //Create New Grocery List for User
        [HttpPost("NewGroceryList")]
        public bool NewGroceryList(GroceryModel newGroceryModel)
        {
            return _data.NewGroceryList(newGroceryModel);
        }

        //Add an Item by Product Name on the Grocery List page
        [HttpPost("AddByProductName/{GroceryListId}/{ProductName}")]
        public bool AddByProductName(int Id, string? ProductName)
        {
            return _data.AddByProductName(Id, ProductName);
        }

        //Get Grocery List By Id
        [HttpGet("GetGroceryListByID/{Id}")]
        public GroceryModel GetGroceryListByID(int Id)
        {
            return _data.GetGroceryListByID(Id);
        }
    }
}