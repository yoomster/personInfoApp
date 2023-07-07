using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace personInfo.Pages
{
    public class AddressInfoModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost()
        {
            var name = Request.Form ["Name"];
            var address = Request.Form ["Address"];
            ViewData ["Address Info"] = $"{name}, address is changed to {address}";
        }
    }
}
