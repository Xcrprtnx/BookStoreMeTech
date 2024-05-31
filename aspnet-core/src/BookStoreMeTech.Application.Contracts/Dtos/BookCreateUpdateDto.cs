﻿using System;

namespace BookStoreMeTech.Application.Contracts.Dtos
{
    public class BookCreateUpdateDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public decimal Price { get; set; }
    }
}

