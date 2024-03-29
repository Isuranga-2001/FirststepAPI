﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FirstStep.Models
{
    [PrimaryKey(nameof(email))]
    public class OTPRequests  //Email address and OTP stores in here
    {
        [EmailAddress]
        public required string email { get; set; }

        public required string otp { get; set; }
    }
}
