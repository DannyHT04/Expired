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

        public IEnumerable<GroupModel> GetAllGroups()
        {
            return _context.GroupsInfo;
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

        public bool AddUsersNameToGroup(int Id, string Name)
        {
            bool result = false;
            GroupModel foundGroup = GetGroupById(Id);
            if(foundGroup != null)
            {
                foundGroup.UserNameInGroup = foundGroup.UserNameInGroup + "," + Name;
                 _context.Update<GroupModel>(foundGroup);
                 result = _context.SaveChanges()!=0;
            }
            return result;
        }


        public List<GroupModel> GetGroupsByUserId(string userId)
        {
            List<GroupModel> AllGroupsFromUser = new List<GroupModel>();
            var groupsFromUsersId = GetAllGroups().ToList();
            for (int i=0; i < groupsFromUsersId.Count; i++){
                GroupModel Group = groupsFromUsersId[i];
                var GroupArr = Group.UsersIdInGroup.Split(",");
                for(int j = 0; j< GroupArr.Length; j++){
                    if(GroupArr[j].Contains(userId)){
                        groupsFromUsersId.Add(Group);
                    }
                }
            }
            return groupsFromUsersId;
        }
    }
}