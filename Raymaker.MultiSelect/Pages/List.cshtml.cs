using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Raymaker.MultiSelect.Models;

namespace Raymaker.MultiSelect.Pages
{
    public class ListModel : PageModel
    {
        private readonly PizzaOptions options;
        
        public ListModel(IOptions<PizzaOptions> options)
        {
            this.options = options.Value;
        }

        [BindProperty]
        public CustomerModel Customer { get; set; }

        [BindProperty]
        public Delivery Delivery { get; set; }

        public void OnGet()
        {
            ViewData["PizzaToppings"] = new SelectList(this.options.Toppings);
            Delivery = this.options.Delivery;
        }

        public void OnPostSubmit()
        {
            // Order the pizza
        }
    }
}
