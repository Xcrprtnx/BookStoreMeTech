using BookStoreMeTech.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreMeTech.Services
{
    public interface IBookAppService
    {
        Task<BookDto> GetAsync(Guid id);
        Task<List<BookDto>> GetListAsync();
        Task<BookDto> CreateAsync(BookCreateUpdateDto input);
        Task<BookDto> UpdateAsync(Guid id, BookCreateUpdateDto input);
        Task DeleteAsync(Guid id);
    }
}
