using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models;
using Expired.Services.Context;

namespace Expired.Services
{
    public class GroupService 
    {
        private readonly  DataContext _context;
        public GroupService(DataContext context)
        {
            _context = context;
        }

        public bool  AddGroup (GroupModel newGroupModel)
        {
            _context.Add(newGroupModel);
            return _context.SaveChanges() != 0;
        }

        // public bool AddMembers(int Id, string GroupMembers)
        // {

        //     return _context.
        // }

        public GroupModel GetGroupById(int Id)
        {
            return _context.GroupsInfo.SingleOrDefault(item => item.Id == Id);
        }

        public bool DeleteAGroup(int Id)
        {
            GroceryModel foundGroup = GetGroupById(Id);
            bool result = false;
            if(foundGroup != null)
            {
                foundGroup.Id = Id;
                _context.Remove<GroceryModel>(foundGroup);
                result = _context.SaveChanges() !=0;
            }
            return result;
        }

        
        
        // public bool DeleteTaskItem(TaskItemModel TaskDelete)
        // {
        //     TaskDelete.IsDeleted = true;
        //     _context.Update<TaskItemModel>(TaskDelete);
        //     return _context.SaveChanges() !=0;
           
        // }
    }
}