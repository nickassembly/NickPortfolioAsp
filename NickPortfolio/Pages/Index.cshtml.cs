using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NickPortfolio.Messaging;

namespace NickPortfolio.Pages
{
   public class IndexModel : PageModel
   {
      private readonly ILogger<IndexModel> _logger;

      public IndexModel(ILogger<IndexModel> logger)
      {
         _logger = logger;
      }

    //  public Email Email { get; set; }

      public void OnGet()
      {

      }
    
   }
 
}
