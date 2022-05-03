using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models.DTO;
using Expired.Models;
using Expired.Services;
using Microsoft.AspNetCore.Mvc;


namespace Expired.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _data;

        public UserController(UserService _dataFromService)
        {
            _data = _dataFromService;
        }

        //Add a User
        [HttpPost("AddUser")]
        public bool AddUser(CreateAccountDTO UserToAdd)
        {
            return _data.AddUser(UserToAdd);
        }

        //Add a user to a group by user Id and group ID
        [HttpPost("AddUserToGroup/{Id}/{GroupId}")]
        public bool AddUserToGroup(int Id, int GroupId)
        {
            return _data.AddUserToGroup(Id, GroupId);
        }

        //Login
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDTO User)
        {
            return _data.Login(User);
        }

        //Update A User By Id & Username
        [HttpPost("UpdateUser/{id}/{newUsername}")]
        public bool UpdateUsername(int id, string newUsername)
        {
            return _data.UpdateUsername(id, newUsername);
        }

        //Does user exist
        [HttpGet("DoesUserExist/{Username}")]
        public bool DoesUserExist(string? Username)
        {
            return _data.DoesUserExist(Username);
        }
        //Delete A User
        [HttpPost("DeleteUser/{UserName}")]
        public bool DeleteUser(string? Username)
        {
            return _data.DeleteUser(Username);
        }
        //Get a user information from username
        [HttpGet("GetUserInfoByUsername/{username}")]
        public UserModel GetUserByUsername(string? username)
        {
            return _data.GetUserByUsername(username);
        }
    }
}