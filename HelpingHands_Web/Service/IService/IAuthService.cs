﻿

using HelpingHands_Web.Models;
using HelpingHands_Web.Models.DTO;

namespace HelpingHands_Web.Service.IService
{
	public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
        Task<T> RegisterAsync<T>(RegisterationRequestDTO objToCreate);
    }
}
