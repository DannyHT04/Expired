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

        //Add an Item
        [HttpPost("AddItem/{Id}/{UserId}/{ItemId}")]
        public bool AddItem(int Id, int UserId, int ItemId)
        {
            return _data.AddItem(Id, UserId, ItemId);
        }

        //Delete an Item
        [HttpPost("DeleteItem/{Id}/{UserId}/{ItemId}")]
        public bool DeleteItem(int Id, int UserId, int ItemId)
        {
            return _data.AddItem(Id, UserId, ItemId);
        }
    }
}