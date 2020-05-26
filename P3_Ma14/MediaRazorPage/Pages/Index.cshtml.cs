using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceReference1;

namespace MediaRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        MediaClient mc = new MediaClient();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
 
        }

        public async Task GetTaskAsync()
        {
            var x = mc.GetPhotosAsync().Result;
            var a = x;

            var posts = await mc.GetPhotosAsync();
            var b = posts;
        }
    }
}
