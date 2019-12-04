using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LmsData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LMS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository _context;

        public IndexModel(ILogger<IndexModel> logger, IRepository context)
        {
            _logger = logger;
            _context = context;
        }
        public IEnumerable<ComputerModel> ComputersList { get; set; }

        public void OnGet()
        {
            ComputersList = this._context.GetAllComputers();
        }
    }
}
