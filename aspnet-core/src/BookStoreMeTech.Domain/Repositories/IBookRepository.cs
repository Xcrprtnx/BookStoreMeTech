using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreMeTech.Entities;

namespace BookStoreMeTech.Domain.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetListAsync();
        Task<Book> GetAsync(Guid id);
        Task<Book> InsertAsync(Book book);
        Task<Book> UpdateAsync(Book book);
        Task DeleteAsync(Guid id);
    }
}
