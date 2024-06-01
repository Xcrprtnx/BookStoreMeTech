using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreMeTech.Entities;

namespace BookStoreMeTech.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetListAsync();
        Task<User> GetAsync(Guid id);
        Task<User> InsertAsync(User user);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(Guid id);
    }
}
