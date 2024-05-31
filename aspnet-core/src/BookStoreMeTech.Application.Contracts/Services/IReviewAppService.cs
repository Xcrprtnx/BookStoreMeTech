using BookStoreMeTech.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProBookStoreMeTech.Application.Contracts.Services
{
    public interface IReviewAppService
    {
        Task<List<ReviewDto>> GetListAsync(Guid bookId);
        Task<ReviewDto> GetAsync(Guid id);
        Task<ReviewDto> CreateAsync(ReviewDto input);
        Task<ReviewDto> UpdateAsync(Guid id, ReviewDto input);
        Task DeleteAsync(Guid id);
    }
}
