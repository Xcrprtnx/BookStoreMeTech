using System;
using System.Collections.Generic;

namespace BookStoreMeTech.Application.Contracts.Dtos
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public decimal Price { get; set; }
        public double AverageRating { get; set; }
        public ICollection<ReviewDto> Reviews { get; set; }
    }
}
