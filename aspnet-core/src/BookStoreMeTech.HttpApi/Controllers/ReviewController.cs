using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using BookStoreMeTech.Application.Contracts.Dtos;
using BookStoreMeTech.Application.Contracts.Services;

namespace BookStoreMeTech.Controllers
{
    [Route("api/reviews")]
    public class ReviewController : AbpController
    {
        private readonly IReviewAppService _reviewAppService;

        public ReviewController(IReviewAppService reviewAppService)
        {
            _reviewAppService = reviewAppService;
        }

        [HttpGet]
        public async Task<List<ReviewDto>> GetListAsync()
        {
            return await _reviewAppService.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ReviewDto> GetAsync(Guid id)
        {
            return await _reviewAppService.GetAsync(id);
        }

        [HttpPost]
        public async Task<ReviewDto> CreateAsync(ReviewCreateUpdateDto input)
        {
            return await _reviewAppService.CreateAsync(input);
        }

        [HttpPut("{id}")]
        public async Task<ReviewDto> UpdateAsync(Guid id, ReviewCreateUpdateDto input)
        {
            return await _reviewAppService.UpdateAsync(id, input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _reviewAppService.DeleteAsync(id);
        }
    }
}
