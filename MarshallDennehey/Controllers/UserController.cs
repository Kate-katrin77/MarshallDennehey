using MarshallDennehey.ViewModels;
using System.Web.Mvc;

namespace MarshallDennehey.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(new UserVM
            {
                Email = "Email@gmail.com",
                Id=5
            });
        }

        [HttpPost, Route("{id}")]
        public ActionResult Edit(int id, UserVM collection)
        {
            return RedirectToAction("Index");
        }
    }
}

