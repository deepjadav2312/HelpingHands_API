﻿using HelpingHands_Utility;using HelpingHands_Web.Models;using HelpingHands_Web.Models.DTO;using HelpingHands_Web.Models.VM;using HelpingHands_Web.Service.IService;namespace HelpingHands_Web.Service{    public class ReviewService : BaseService, IReviewService    {        private readonly IHttpClientFactory _clientFactory;        private string categoryUrl;        public ReviewService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            categoryUrl = configuration.GetValue<string>("ServiceUrls:HelpingHandAPI");        }        public Task<T> CreateAsync<T>(ReviewCreateVM dto, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = categoryUrl + "/api/v1/ReviewAPI/CreateReview",                Token = token            });        }        public Task<T> DeleteAsync<T>(int id, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = categoryUrl + "/api/v1/ReviewAPI/DeleteReview/" + id,                Token = token            });        }        public Task<T> GetAllAsync<T>(string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = categoryUrl + "/api/v1/ReviewAPI/GetReviews",                Token = token            });        }

        public Task<T> ReviewByPagination<T>(string term, string orderBy, int currentPage, string token)        {
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{categoryUrl}/api/v1/ReviewAPI/ReviewByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = apiUrl,                Token = token            });        }        public Task<T> GetAsync<T>(int id, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = categoryUrl + "/api/v1/ReviewAPI/GetReview/" + id,                Token = token            });        }        public Task<T> UpdateAsync<T>(ReviewUpdateDTO dto, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = categoryUrl + "/api/v1/ReviewAPI/UpdateReview/" + dto.Id,                Token = token            });        }    }}