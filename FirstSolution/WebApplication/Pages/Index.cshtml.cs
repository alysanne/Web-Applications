using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Primitives;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        public StringValues Name;
        public StringValues Greeting;
        
        public void OnPost()
        {
            var formName = Request.Form["name"];
            this.Name = formName;
            this.Greeting = "Hello, " + formName;
        }
    }
}
