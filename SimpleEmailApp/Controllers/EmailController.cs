using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace SimpleEmailApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
          [HttpPost]
          public IActionResult SendEmail(string body)
          {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("wava.mccullough70@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("wava.mccullough70@ethereal.email"));
            email.Subject = "Test Email Subject";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("wava.mccullough70@ethereal.email", "UYUhZPpqzdww7P9QGR");
            smtp.Send(email);
            smtp.Disconnect(true);

            return Ok();
          }  
    }
}