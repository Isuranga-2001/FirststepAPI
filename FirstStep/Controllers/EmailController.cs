﻿using FirstStep.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using FirstStep.Services.EmailSevices;

/*Controller for Email Service*/

namespace FirstStep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService) {
            _emailService = emailService;
        }

        [HttpPost]
        [Route("RequestOTP/email={email}/fullname={fullName}")]
        public IActionResult RequestOTP(string email, string fullName)
        {
            _emailService.SendOTPEmail(email, fullName);
            return Ok();
        }

        [HttpPost]
        [Route("VerifyEmail/email={email}/otp={otp}")]
        public async Task<IActionResult> OTPCheck(string email, string otp)
        {
            if(await _emailService.VerifyOTP(new EmailVerifyDto { email = email, otp = otp }))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
