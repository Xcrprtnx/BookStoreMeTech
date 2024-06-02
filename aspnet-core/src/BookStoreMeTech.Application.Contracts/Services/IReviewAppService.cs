using Volo.Abp.Application.Services;
using System;
using BookStoreMeTech.Application.Contracts.Dtos;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BookStoreMeTech.Application.Contracts.Services
{
    public interface IReviewAppService : IApplicationService
    {
        Task<ReviewDto> GetAsync(Guid id);
        Task<List<ReviewDto>> GetListAsync();
        Task<ReviewDto> CreateAsync(ReviewCreateUpdateDto input);
        Task<ReviewDto> UpdateAsync(Guid id, ReviewCreateUpdateDto input);
        Task DeleteAsync(Guid id);
    }
}
