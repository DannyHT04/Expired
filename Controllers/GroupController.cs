using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models;
using Expired.Models.DTO;
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
        public bool AddGroup(CreateGroupDTO GroupToAdd)
        {
            return _data.AddGroup(GroupToAdd);
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

        //Edit Group Name
        [HttpPost("EditGroupName/{Id}/{newGroupName}")]
        public bool EditGroupName(int Id, string? newGroupName)
        {
            return _data.EditGroupName(Id, newGroupName);
        }

        //Edit Group Password
        [HttpPost("EditGroupPassword/{Id}/{newPassword}")]
        public bool EditGroupPassword(int Id, string? newPassword)
        {
            return _data.EditGroupPassword(Id, newPassword);
        }

        [HttpPost("AddUsernameToGroup/{Id}/{username}")]
        public bool AddUsersToGroup(int Id, string username)
        {
            return _data.AddUsersToGroup(Id, username);
        }
    }
}