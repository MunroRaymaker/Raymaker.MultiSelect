using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Raymaker.MultiSelect.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            this._logger = logger;
        }

        public void OnGet([FromQuery(Name = "EmpNo")] string empNo, [FromQuery(Name = "Date")] DateTime date)
        {
            
        }
    }
}