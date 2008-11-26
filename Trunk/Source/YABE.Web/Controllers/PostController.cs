namespace YABE.Web.Controllers
{
    using System.Web.Mvc;

    public class PostController : Controller
    {
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Create()
        {
            return View();
        }
    }
}