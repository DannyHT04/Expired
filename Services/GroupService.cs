using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models;
using Expired.Services.Context;
using Microsoft.AspNetCore.Mvc;

namespace Expired.Services
{
    public class GroupService
    {
        private readonly DataContext _context;
        public GroupService(DataContext context)
        {
            _context = context;
        }

        public bool DoesGroupExist(string? GroupName) 
        {
            
            return _context.GroupsInfo.SingleOrDefault( Group => Group.GroupName == GroupName) != null;
        }
        public bool AddGroup(GroupModel newGroupModel)
        {
            bool result = false;
           if(!DoesGroupExist(newGroupModel.GroupName)){
               _context.Add(newGroupModel);
               result = _context.SaveChanges() != 0;
           }
            
            return result;
        }


        public GroupModel GetGroupById(int Id)
        {
            return _context.GroupsInfo.SingleOrDefault(item => item.Id == Id);
        }

        public bool DeleteAGroup(int Id)
        {
            GroupModel foundGroup = GetGroupById(Id);
            bool result = false;
            if (foundGroup != null)
            {
                foundGroup.Id = Id;
                _context.Remove<GroupModel>(foundGroup);
                result = _context.SaveChanges() != 0;
            }
            return result;
        }

        public bool EditGroupName(int Id, string? newGroupName)
        {
            GroupModel foundUser = GetGroupById(Id);
            bool result = false;
            if (foundUser != null)
            {
                foundUser.GroupName = newGroupName;
                _context.Update<GroupModel>(foundUser);
                result = _context.SaveChanges() != 0;
            }
            return result;
        }
        public bool EditGroupPassword(int Id, string? newPassword)
        {
            GroupModel foundUser = GetGroupById(Id);
            bool result = false;
            if (foundUser != null)
            {
                foundUser.GroupPassword = newPassword;
                _context.Update<GroupModel>(foundUser);
                result = _context.SaveChanges() != 0;
            }
            return result;
        }

    }
}