using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreMeTech.Application.Contracts.Dtos;
using BookStoreMeTech.Domain.Repositories;
using BookStoreMeTech.Entities;
using BookStoreMeTech.Application.Contracts.Services;
using Volo.Abp.Application.Services;

namespace BookStoreMeTech.Application.Services
{
    public class ReviewAppService : ApplicationService, IReviewAppService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewAppService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<ReviewDto> GetAsync(Guid id)
        {
            var review = await _reviewRepository.GetAsync(id);
            return ObjectMapper.Map<Review, ReviewDto>(review);
        }

        public async Task<List<ReviewDto>> GetListAsync()
        {
            var reviews = await _reviewRepository.GetListAsync();
            return ObjectMapper.Map<List<Review, List<ReviewDto>>>(reviews);
        }

        public async Task<ReviewDto> CreateAsync(ReviewCreateUpdateDto input)
        {
            var review = ObjectMapper.Map<ReviewCreateUpdateDto, Review>(input);
            await _reviewRepository.InsertAsync(review);
            return ObjectMapper.Map<Review, ReviewDto>(review);
        }

        public async Task<ReviewDto> UpdateAsync(Guid id, ReviewCreateUpdateDto input)
        {
            var review = await _reviewRepository.GetAsync(id);
            ObjectMapper.Map(input, review);
            await _reviewRepository.UpdateAsync(review);
            return ObjectMapper.Map<Review, ReviewDto>(review);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _reviewRepository.DeleteAsync(id);
        }
    }
}
