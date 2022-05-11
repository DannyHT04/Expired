using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models;
using Expired.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Expired.Models.DTO;

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
        public bool AddGroup(CreateGroupDTO GroupToAdd)
        {
            bool result = false;
            GroupModel newGroup = new GroupModel();
           if(!DoesGroupExist(GroupToAdd.GroupName)){
               newGroup.Id = GroupToAdd.Id;
               newGroup.GroupName = GroupToAdd.GroupName;
               newGroup.UsersInGroup = GroupToAdd.UsersInGroup;
               newGroup.GroupPassword = GroupToAdd.GroupPassword;
               _context.Add(newGroup);
               result = _context.SaveChanges() != 0;
           }
            
            return result;
        }


        public GroupModel GetGroupById(int Id)
        {
            return _context.GroupsInfo.SingleOrDefault(item => item.Id == Id);
        }

        // public List<GroupModel> GetAllGroupByUserId(int userId)
        // {
        //     List<GroupModel> AllGroupsForUser = new List<GroupModel>();
        //     var AllGroups = AllGroups().ToList();
        //     for(int i=0; i < AllGroups.Count; i++){
        //         GroupModel Group = AllGroups[i];
        //         var GroupUsers = Group.UsersInGroup.Split(",");
        //         for(int j = 0; j< GroupUsers.Length; j++){
        //             if(GroupUsers[j].Contains(userId)){
        //                 AllGroupsForUser.Add(Group);
        //             }
        //         }
        //     }
        //     return AllUsersInGroup;
        // }
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

        public bool AddUsersToGroup(int Id, string Name)
        {
            bool result = false;
            GroupModel foundGroup = GetGroupById(Id);
            if(foundGroup != null)
            {
                foundGroup.UsersInGroup = foundGroup.UsersInGroup + "," + Name;
                 _context.Update<GroupModel>(foundGroup);
                 result = _context.SaveChanges()!=0;
            }
            return result;
        }


        // public List<GroupModel> GetUsersFromGroup(string GroupId)
        // {
        //     List<GroupModel> 
        // }
    }
}