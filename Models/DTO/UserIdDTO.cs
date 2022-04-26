using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Models.DTO
{
    public class UserIdDTO
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
         public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}