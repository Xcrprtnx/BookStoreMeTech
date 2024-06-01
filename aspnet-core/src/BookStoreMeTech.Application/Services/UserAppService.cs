using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreMeTech.Application.Contracts.Dtos;
using BookStoreMeTech.Application.Contracts.Services;
using BookStoreMeTech.Domain.Repositories;
using BookStoreMeTech.Entities;
using Volo.Abp.Application.Services;
using Volo.Abp.Users;

namespace BookStoreMeTech.Application.Services
{
    public class UserAppService : ApplicationService, IUserAppService
    {
        private readonly IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> GetAsync(Guid id)
        {
            var user = await _userRepository.GetAsync(id);
            return ObjectMapper.Map<User, UserDto>(user);
        }

        public async Task<List<UserDto>> GetListAsync()
        {
            var users = await _userRepository.GetListAsync();
            return ObjectMapper.Map<List<User>, List<UserDto>>(users);
        }

        public async Task<UserDto> CreateAsync(UserCreateUpdateDto input)
        {
            var user = ObjectMapper.Map<UserCreateUpdateDto, User>(input);
            await _userRepository.InsertAsync(user);
            return ObjectMapper.Map<User, UserDto>(user);
        }

        public async Task<UserDto> UpdateAsync(Guid id, UserCreateUpdateDto input)
        {
            var user = await _userRepository.GetAsync(id);
            ObjectMapper.Map(input, user);
            await _userRepository.UpdateAsync(user);
            return ObjectMapper.Map<User, UserDto>(user);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }
    }
}
