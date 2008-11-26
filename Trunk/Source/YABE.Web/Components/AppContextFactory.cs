namespace YABE.Web.Components
{
    using System.Web;
    using Domain.Repositories;

    public class AppContextFactory
    {
        public IAppContext Create(IBlogRepository repository)
        {
            return new WebAppContext(new HttpContextWrapper(HttpContext.Current), repository);
        }
    }
}