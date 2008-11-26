namespace YABE.Web.Controllers
{
    using System.Web.Mvc;
    using Components;
    using Domain.Model;
    using Domain.Repositories;
    using Extensions;
    using Model;

    public class BlogController : Controller
    {
        private readonly IBlogRepository repository;
        private readonly IAppContext appContext;

        public BlogController(IBlogRepository repository, IAppContext appContext)
        {
            this.repository = repository;
            this.appContext = appContext;
        }

        [AcceptVerbs("GET")]
        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs("POST")]
        public ActionResult Create([Bind(Prefix="")]CreateBlogModel model)
        {
            if (!ViewData.ModelState.IsValid) { return View(model); }

            var blog = model.Blog;

            try
            {
                blog.Validate();

                repository.Save(blog);

                return RedirectToAction("Options");
            }
            catch(RuleViolationException ex)
            {
                ViewData.ModelState.AddRuleViolations(ex.Violations);
                return View(model);
            }
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Options() 
        {
            return View(new UpdateBlogOptionsModel(appContext.CurrentBlog.Options));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Options([Bind(Prefix="")]UpdateBlogOptionsModel model)
        {
            if (!ViewData.ModelState.IsValid) { return View(model); }

            appContext.CurrentBlog.Options.NumberOfPostsToShowOnHomePage = model.NumberOfPostsToShowOnHomePage;

            try
            {
                repository.Save(appContext.CurrentBlog);
                model.Message = "Options Successfully Saved";
                return View(model);
            }
            catch (RuleViolationException ex)
            {
                ViewData.ModelState.AddRuleViolations(ex.Violations);
                return View(model);
            }
        }
    }
}
