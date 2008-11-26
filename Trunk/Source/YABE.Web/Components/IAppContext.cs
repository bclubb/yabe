namespace YABE.Web.Components
{
    using Domain.Model;

    public interface IAppContext
    {
        BlogEntity CurrentBlog { get; }
    }
}