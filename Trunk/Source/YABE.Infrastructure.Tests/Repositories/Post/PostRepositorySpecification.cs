namespace YABE.Infrastructure.Tests.Repositories.Post
{
    using Domain.Model;
    using Rhino.Commons;

    public class PostRepositorySpecification : RepositorySpecification
    {
        protected override void ClearAllData()
        {
            Repository<PostEntity>.DeleteAll();
            Repository<BlogEntity>.DeleteAll();

            UnitOfWork.Current.Flush();
        }
    }
}