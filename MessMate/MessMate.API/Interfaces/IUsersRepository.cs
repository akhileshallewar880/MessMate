using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessMate.API.Models.Entity;

namespace MessMate.API.Interfaces
{
    public interface IUsersRepository
    {
    void Update(User user);
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User> GetUserByIdAsync(int id);
    Task<User> GetUserByUsernameAsync(string username);
    
    }
}