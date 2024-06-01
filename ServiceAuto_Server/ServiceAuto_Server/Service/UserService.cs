﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using ServiceAuto_Server.Domain;
using ServiceAuto_Server.Repository;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using System.Data;

namespace ServiceAuto_Server.Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]
    internal class UserService : IUserService
    {
        private IUserRepository iUserRepository;

        public UserService()
        {
            this.iUserRepository = new UserRepository();
        }

        public bool AddUser(User user)
        {
            return this.iUserRepository.AddUser(user);
        }

        public bool LoginUser(string username, string password)
        {
            return this.iUserRepository.LoginUser(username, password);
        }

        public string GetRole(string username, string password)
        {
            return this.iUserRepository.GetRole(username, password);
        }

        public bool DeleteUser(uint userID) 
        {
            return this.iUserRepository.DeleteUser(userID);
        }

        public bool UpdateUser(User user)
        {
            return this.iUserRepository.UpdateUser(user);
        }

        public DataTable UserTable()
        {
            return this.iUserRepository.UserTable();
        }

        public List<User> UserList()
        {
            return this.iUserRepository.UserList();
        }

        public List<User> UserList_Role(int searchedRole)
        {
            return this.UserList_Role(searchedRole);
        }

        public User SearchUserByID(string id)
        {
            return this.iUserRepository.SearchUserByID(id);
        }

        public List<User> SearchUserByUsername(string username)
        {
            return this.iUserRepository.SearchUserByUsername(username);
        }

        public List<User> SearchUserByRole(string role)
        {
            return this.iUserRepository.SearchUserByRole(role);
        }
    }
}
