using System;

namespace BookStoreMeTech.Application.Contracts.Dtos
{
    public class ReviewDto
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid UserId { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
    }
}
