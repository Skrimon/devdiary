using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Devel.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"This is the welcome action method, my name is: {name}, id is {ID} ");
        }
    }
}
