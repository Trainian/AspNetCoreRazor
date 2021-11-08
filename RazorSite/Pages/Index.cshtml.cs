using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorSite.Context;

namespace RazorSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private RazorSiteContext _db;

        public IndexModel(ILogger<IndexModel> logger, RazorSiteContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            
        }
    }
}
