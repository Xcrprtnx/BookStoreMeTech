using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using BookStoreMeTech.Application.Contracts.Dtos;
using BookStoreMeTech.Services;

namespace BookStoreMeTech.Controllers
{
    [Route("api/books")]
    public class BookController : AbpController
    {
        private readonly IBookAppService _bookAppService;

        public BookController(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        [HttpGet]
        public async Task<List<BookDto>> GetListAsync()
        {
            return await _bookAppService.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<BookDto> GetAsync(Guid id)
        {
            return await _bookAppService.GetAsync(id);
        }

        [HttpPost]
        public async Task<BookDto> CreateAsync(BookCreateUpdateDto input)
        {
            return await _bookAppService.CreateAsync(input);
        }

        [HttpPut("{id}")]
        public async Task<BookDto> UpdateAsync(Guid id, BookCreateUpdateDto input)
        {
            return await _bookAppService.UpdateAsync(id, input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _bookAppService.DeleteAsync(id);
        }
    }
}
