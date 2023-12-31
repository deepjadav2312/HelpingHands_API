﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using HelpingHands_Web.Models;
using HelpingHands_Web.Service.IService;
using HelpingHands_Utility;
using HelpingHands_Web.Models.DTO;

namespace HelpingHands_Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDTO obj = new();
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequestDTO obj)
        {
            APIResponse response = await _authService.LoginAsync<APIResponse>(obj);
            if (response != null && response.IsSuccess)
            {
                LoginResponseDTO model = JsonConvert.DeserializeObject<LoginResponseDTO>(Convert.ToString(response.Result));

                var handler = new JwtSecurityTokenHandler();
                var jwt = handler.ReadJwtToken(model.Token);

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, jwt.Claims.FirstOrDefault(u => u.Type == "unique_name").Value));
                identity.AddClaim(new Claim(ClaimTypes.Role, jwt.Claims.FirstOrDefault(u => u.Type == "role").Value));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, jwt.Claims.FirstOrDefault(u => u.Type == "nameid").Value));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);


                HttpContext.Session.SetString(SD.SessionToken, model.Token);

                if (principal.IsInRole("Customer"))
                {
                    return RedirectToAction("Index", "Home", new { area = "Customer" });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
            }
            else
            {
                if (response.ErrorMessages.Count > 0)
                {
                    // ModelState.AddModelError("CustomError", response.ErrorMessages.FirstOrDefault());
                    TempData["error"] = response.ErrorMessages.FirstOrDefault();
                    
                }
                return View(obj);
            }
            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterationRequestDTO obj)
        {
            APIResponse result = await _authService.RegisterAsync<APIResponse>(obj);
            if (result != null && result.IsSuccess)
            {
                return RedirectToAction("Login");
            }
            else
            {
                if (result.ErrorMessages.Count > 0)
                {
                    // ModelState.AddModelError("CustomError", response.ErrorMessages.FirstOrDefault());
                    TempData["error"] = result.ErrorMessages.FirstOrDefault();
                }
                return View();
            }
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.SetString(SD.SessionToken, "");
            // return RedirectToAction("Index", "Home");
            return RedirectToAction("Index", "Home", new { area = "Customer" });
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
