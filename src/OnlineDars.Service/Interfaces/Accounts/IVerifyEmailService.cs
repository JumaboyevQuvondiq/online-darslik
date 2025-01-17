﻿using OnlineDars.Service.Dtos.Emails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDars.Service.Interfaces.Accounts
{
    public interface IVerifyEmailService
    {
        Task<bool> SendCodeAsync(SendCodeToEmailDto sendCodeToEmailDto);

        Task<bool> VerifyEmail(EmailVerifyDto emailVerifyDto);

        Task<bool> VerifyPasswordAsync(ResetPasswordDto resetPasswordDto);
    }
}
