using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreMeTech.Entities;

namespace BookStoreMeTech.Domain.Repositories
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetListAsync();
        Task<Review> GetAsync(Guid id);
        Task<Review> InsertAsync(Review review);
        Task<Review> UpdateAsync(Review review);
        Task DeleteAsync(Guid id);
    }
}
