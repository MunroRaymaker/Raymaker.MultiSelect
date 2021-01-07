using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Raymaker.MultiSelect.Models;

namespace Raymaker.MultiSelect.Pages
{
    public class ListModel : PageModel
    {
        private List<string> _toppings = new[]{ "Cheese", "Tomatoes", "Mozzarella", "Peperoni", "Onions" }.ToList();

        [BindProperty]
        public CustomerModel Customer { get; set; }

        public void OnGet()
        {
            ViewData["PizzaToppings"] = new SelectList(this._toppings);
        }

        public void OnPostSubmit()
        {
            // Order the pizza
        }
    }
}
