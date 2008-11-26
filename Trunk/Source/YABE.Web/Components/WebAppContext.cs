namespace YABE.Web.Components
{
    using System.Web;
    using Domain.Model;
    using Domain.Repositories;

    public class WebAppContext : IAppContext
    {
        private readonly HttpContextBase context;
        private readonly IBlogRepository blogRepository;

        public WebAppContext(HttpContextBase context, IBlogRepository blogRepository)
        {
            this.context = context;
            this.blogRepository = blogRepository;
        }

        public BlogEntity CurrentBlog
        {
            get
            {
                var host = context.Request.Url.Host;

                var blog = context.Session["blog"] as BlogEntity;

                if (blog == null)
                {
                    blog = blogRepository.Fetch(host);
                    context.Session.Add("blog", blog);
                    return blog;
                }

                if ((blog != null) && (!blog.Host.Equals(host)))
                {
                    blog = blogRepository.Fetch(host);
                    context.Session["blog"] = blog;
                }

                return blog;
            }
        }
    }
}