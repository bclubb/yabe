namespace YABE.Infrastructure.Tests.Repositories.Blog
{
    using Domain.Model;
    using Rhino.Commons;

    public class BlogRepositorySpecification : RepositorySpecification
    {
        protected override void ClearAllData()
        {
            Repository<BlogEntity>.DeleteAll();
            UnitOfWork.Current.Flush();
        }
    }
}