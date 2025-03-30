using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using MyApp.Models;

public class UserRepository
{
    private readonly IDbConnection _dbConnection;

    public UserRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    // Get all users
    public IEnumerable<User> GetAllUsers()
    {
        return _dbConnection.GetAll<User>();
    }

    // Get user by ID
    public User GetUserById(int id)
    {
        return _dbConnection.Get<User>(id);
    }

    // Add a new user
    public long AddUser(User user)
    {
        return _dbConnection.Insert(user);
    }

    // Update user
    public bool UpdateUser(User user)
    {
        return _dbConnection.Update(user);
    }

    // Delete user
    public bool DeleteUser(int id)
    {
        var user = _dbConnection.Get<User>(id);
        if (user == null)
            return false;
        return _dbConnection.Delete(user);
    }
}