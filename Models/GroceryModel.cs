using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Models
{
    public class GroceryModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int ItemId { get; set; }
        public string? ProductName { get; set; }
        public bool IsDeleted { get; set; }

        public GroceryModel(){}

    }
}