using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace personInfo.Pages
{
    public class PersonalInfoModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var name = Request.Form["Name"];
            var email = Request.Form["Email"];
            ViewData["Personal Info"] = $"{name}, information will be sent to {email}";
        }
    }
}
