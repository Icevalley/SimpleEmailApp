using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleEmailApp.Models;

namespace SimpleEmailApp.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request)
        {
            throw new NotImplementedException();
        }
    }
}