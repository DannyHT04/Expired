using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expired.Services
{
    public class GroupService
    {
        private readonly  DataContext _context;
        public GroupService (DataContext context)
        {
            _context = context;
        }

        public bool  AddGroup (GroupModel newGroupModel)
        {
            _context.Add(newGroupModel);
            return _context.SaveChanges() != 0;
        }
    }
}