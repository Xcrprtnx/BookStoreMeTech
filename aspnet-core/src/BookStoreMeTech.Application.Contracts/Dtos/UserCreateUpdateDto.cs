using System;

namespace BookStoreMeTech.Application.Contracts.Dtos
{
    public class UserCreateUpdateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}