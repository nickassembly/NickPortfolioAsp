using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NickPortfolio.Models;

namespace NickPortfolio.Pages
{
   public class IndexModel : PageModel
   {
      private readonly ILogger<IndexModel> _logger;

      public IndexModel(ILogger<IndexModel> logger)
      {
         _logger = logger;
      }

      public void OnGet()
      {

      }

      [BindProperty]
      public Email sendMail { get; set; }

      // TODO: Implement Razor Page contact form
      public async Task OnPost()
      {

         using (MailMessage mail = new MailMessage())
         {
            string To = "guerratechinfo@gmail.com";
            string Subject = sendMail.Subject; // Need to add to form
            string Body = sendMail.Message;
            mail.From = new MailAddress(""); // user enterned variable passed in
            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = false;

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
               smtp.UseDefaultCredentials = false;
               smtp.Credentials = new NetworkCredential("guerratechinfo@gmail.com", "&&&&&&&");
               smtp.EnableSsl = true;
               smtp.Send(mail);
            }

         }

      }



   }
}
