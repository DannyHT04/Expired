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
    public class GroupController : ControllerBase
    {
        private readonly GroupService _data;
        public GroupController(GroupService dataFromService)
        {
            _data = dataFromService;
        }

        //Add A Group
        [HttpPost("AddGroup")]
        public bool AddGroup (GroupModel newGroupModel)
        {
            return _data.AddGroup(newGroupModel);
        }
        //Add A Member
        [HttpPost("AddMembers/{Id}/{Groupmembers}")]
        public bool AddMembers(int Id, string GroupMembers)
        {
            return _data.AddMembers(Id, GroupMembers);
        }

        //Delete a Group
        [HttpPost("DeleteAGroup/{Id}")]
        public bool DeleteAGroup(int Id)
        {
            return _data.DeleteAGroup(Id);
        }

        //Get Group By Id
        [HttpGet("GetGroupById/{Id}")]
        public GroupModel GetGroupById(int Id)
        {
            return _data.GetGroupById(Id);
        }
        
    }
}