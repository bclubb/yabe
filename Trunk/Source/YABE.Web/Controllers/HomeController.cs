namespace YABE.Web.Controllers
{
    using System.Web.Mvc;
    using Castle.Core.Logging;
    using Components;
    using Domain.Repositories;
    using Model;

    public class HomeController : Controller
    {
        private readonly IAppContext appContext;
        private readonly IPostRepository repository;
        private readonly ILogger log = NullLogger.Instance;

        public HomeController(IAppContext appContext, IPostRepository repository)
        {
            this.appContext = appContext;
            this.repository = repository;
        }

        [AcceptVerbs("GET")]
        public ActionResult Index()
        {
            if (appContext.CurrentBlog == null)
            {
                log.Info("Current blog not found, redirecting to ~/Blog/Create");
                return RedirectToRoute(new {Controller = "Blog", Action = "Create"});
            }

            var response = new HomeIndexResponse();

            response.Posts = repository.FetchCurrentPosts(appContext.CurrentBlog.Options.NumberOfPostsToShowOnHomePage);

            return View("Index", response);
        }
    }
}