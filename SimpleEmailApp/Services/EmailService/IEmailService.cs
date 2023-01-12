using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace SimpleEmailApp.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);

    }
}