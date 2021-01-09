using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Raymaker.MultiSelect.Pages
{
    public class LegacyModel : PageModel
    {
        private readonly ILogger<LegacyModel> _logger;

        public LegacyModel(ILogger<LegacyModel> logger)
        {
            this._logger = logger;
        }

        public void OnGet([FromQuery(Name = "EmpNo")] string empNo, [FromQuery(Name = "Date")] DateTime date)
        {
            
        }
    }
}