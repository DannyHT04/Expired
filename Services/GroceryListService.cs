using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Services
{
    public class GroceryListService
    {
        private readonly DataContext _context;
        public GroceryListService(DataContext context)
        {
            _context = context;
        }
    }
}