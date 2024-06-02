using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using BookStoreMeTech.Application.Contracts.Dtos;
using BookStoreMeTech.Application.Contracts.Services;

namespace BookStoreMeTech.Controllers
{
    [Route("api/users")]
    public class UserController : AbpController
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public async Task<List<UserDto>> GetListAsync()
        {
            return await _userAppService.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDto> GetAsync(Guid id)
        {
            return await _userAppService.GetAsync(id);
        }

        [HttpPost]
        public async Task<UserDto> CreateAsync(UserCreateUpdateDto input)
        {
            return await _userAppService.CreateAsync(input);
        }

        [HttpPut("{id}")]
        public async Task<UserDto> UpdateAsync(Guid id, UserCreateUpdateDto input)
        {
            return await _userAppService.UpdateAsync(id, input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _userAppService.DeleteAsync(id);
        }
    }
}
