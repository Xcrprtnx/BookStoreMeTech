using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreMeTech.Application.Contracts.Dtos;

namespace BookStoreMeTech.Application.Contracts.Services
{
    public interface IUserAppService
    {
        Task<List<UserDto>> GetListAsync();
        Task<UserDto> GetAsync(Guid id);
        Task<UserDto> CreateAsync(UserCreateUpdateDto input);
        Task<UserDto> UpdateAsync(Guid id, UserCreateUpdateDto input);
        Task DeleteAsync(Guid id);
    }
}
