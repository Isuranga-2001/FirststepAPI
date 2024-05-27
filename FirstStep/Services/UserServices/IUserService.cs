﻿using FirstStep.Models.DTOs;

namespace FirstStep.Services
{
    public interface IUserService
    {
        Task<AuthenticationResult> Authenticate(LoginRequestDto userObj);

        Task<AuthenticationResult> RefreshToken(TokenApiDto tokenApiDto);

        Task<string> RegisterUser(UserRegRequestDto userObj, string? type, string? company_id);

        Task<bool> CheckEmailExist(string Email);
    }
}