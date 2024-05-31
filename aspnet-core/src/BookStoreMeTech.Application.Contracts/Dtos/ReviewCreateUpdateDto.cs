using System;

namespace BookStoreMeTech.Application.Contracts.Dtos
{
    public class ReviewCreateUpdateDto
    {
        public Guid BookId { get; set; }
        public Guid UserId { get; set; }
        public string? Comment { get; set; }
        public int Rating { get; set; }
    }
}
