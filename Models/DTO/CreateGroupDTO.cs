using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Models.DTO
{
    public class CreateGroupDTO
    {
        public int Id { get; set; }
        public string? GroupName { get; set; }
        public string? GroupPassword { get; set; }
    }
}