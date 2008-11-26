namespace YABE.Domain.Repositories
{
    using Model;

    public interface IBlogRepository
    {
        BlogEntity Fetch(string host);
        void Save(BlogEntity blog);
    }
}