using BookStoreMeTech.Application.Contracts.Dtos;
using BookStoreMeTech.Domain.Repositories;
using BookStoreMeTech.Entities;
using BookStoreMeTech.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace BookStoreMeTech.Application
{
    public class BookAppService : ApplicationService, IBookAppService
    {
        // Assuming you have a repository for books
        private readonly IBookRepository _bookRepository;

        public BookAppService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookDto> GetAsync(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);
            return ObjectMapper.Map<Book, BookDto>(book);
        }

        public async Task<List<BookDto>> GetListAsync()
        {
            var books = await _bookRepository.GetListAsync();
            return ObjectMapper.Map<List<Book>, List<BookDto>>(books);
        }

        public async Task<BookDto> CreateAsync(BookCreateUpdateDto input)
        {
            var book = ObjectMapper.Map<BookCreateUpdateDto, Book>(input);
            await _bookRepository.InsertAsync(book);
            return ObjectMapper.Map<Book, BookDto>(book);
        }

        public async Task<BookDto> UpdateAsync(Guid id, BookCreateUpdateDto input)
        {
            var book = await _bookRepository.GetAsync(id);
            ObjectMapper.Map(input, book);
            await _bookRepository.UpdateAsync(book);
            return ObjectMapper.Map<Book, BookDto>(book);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _bookRepository.DeleteAsync(id);
        }
    }
}
