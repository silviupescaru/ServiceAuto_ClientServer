using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using ServiceAuto_Server.Domain;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceAuto_Server.Service
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        bool AddUser(User user);

        [OperationContract]
        bool LoginUser(string username, string password);

        [OperationContract]
        string GetRole(string username, string password);

        [OperationContract]
        bool DeleteUser(uint userID);

        [OperationContract]
        bool UpdateUser(User user);

        [OperationContract]
        DataTable UserTable();

        [OperationContract]
        List<User> UserList();

        [OperationContract]
        List<User> UserList_Role(int searchedRole);

        [OperationContract]
        User SearchUserByID(string id);

        [OperationContract]
        List<User> SearchUserByUsername(string username);

        [OperationContract]
        List<User> SearchUserByRole(string role);
    }
}
