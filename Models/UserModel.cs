using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? GroupId { get; set; }
        public string? Username { get; set; }
        public string? Salt { get; set; }
        public string? Hash { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool DeleteUser { get; set; }

        public UserModel(){}
    }
}