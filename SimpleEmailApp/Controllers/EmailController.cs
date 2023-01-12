using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SimpleEmailApp.Models;

namespace SimpleEmailApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailservice;

        public EmailController(IEmailService emailservice)
        {
            _emailservice = emailservice;
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            _emailservice.SendEmail(request);

            return Ok();
        }
    }
}