using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? ProductName { get; set; }
        public string? DateOfExpiration { get; set; }
        public string? Owner { get; set; }
        public string? ProductImage { get; set; }
        public string? Category { get; set; }
        public bool isGroceryList { get; set; } 
        public bool isDeleted { get; set; }
        public ItemModel(){}
    }
}