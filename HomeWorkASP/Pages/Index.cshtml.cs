using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWorkASP.Pages
{
    public class IndexModel : PageModel
    {
        public string Message1 { get; set; }
        public string Message2 { get; set; }
        public string Message3 { get; set; }
        public string Message4 { get; set; }
        public void OnGet()
        {

        }

        public void OnPost(string? name,string? surname,string? birthday, string? profession, string? school)
        {
            if (name != null && surname != null && birthday != null && profession != null && school != null)
            {
                Message1 = name + " " + surname;
                Message2 = birthday;
                Message3 = profession;
                Message4 = school;
            }
            else { Message1 = "Данные неккоректны!"; }
        }
    }
}