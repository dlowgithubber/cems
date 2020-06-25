using CEMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CEMS.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListAsync();
        //Task AddAsync(User user);
        Task<User> FindByIdAsync(string id);
        //void Update(User user);
        //void Remove(User user);
    }
}
