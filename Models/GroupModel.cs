using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Models
{
    public class GroupModel
    {
        public int Id { get; set; }
        public string? GroupName { get; set; }
        public string? GroupMembers { get; set; }
        public string? GroupPassword { get; set; }
        public bool IsGroupDeleted { get; set; }
        public GroupModel(){}
    }
}