namespace YABE.Infrastructure.DataAccess
{
    using Castle.Services.Transaction;
    using Domain.Model;
    using Domain.Repositories;
    using Query;
    using Rhino.Commons;

    [Transactional]
    public class BlogRepository : IBlogRepository
    {
        private readonly IRepository<BlogEntity> repository;

        public BlogRepository(IRepository<BlogEntity> repository) { this.repository = repository; }

        #region IBlogRepository Members

        public BlogEntity Fetch(string host)
        {
            return repository.FindOne(Where.BlogEntity.Host == host);
        }

        [Transaction]
        public void Save(BlogEntity blog) { repository.SaveOrUpdate(blog); }

        #endregion
    }
}