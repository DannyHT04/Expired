using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Expired.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly GroupService _data;
        public GroupController(GroupService dataFromService)
        {
            _data = dataFromService;
        }
        //Add A Group
        public bool AddGroup (GroupModel newGroupModel)
        {
            return _data.AddGroup(newGroupModel);
        }
        
    }
}