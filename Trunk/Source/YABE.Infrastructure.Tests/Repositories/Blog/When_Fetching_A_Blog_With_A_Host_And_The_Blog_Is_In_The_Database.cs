namespace YABE.Infrastructure.Tests.Repositories.Blog
{
    using Domain.Model;
    using Domain.Repositories;
    using NUnit.Framework;
    using Rhino.Commons;
    using Test.Extensions;

    [TestFixture]
    public class When_Fetching_A_Blog_With_A_Host_And_The_Blog_Is_In_The_Database : BlogRepositorySpecification
    {
        private BlogEntity fetchedBlog;
        private IBlogRepository repository;

        public override void Under_These_Conditions()
        {
            repository = IoC.Resolve<IBlogRepository>();
            var blog = new BlogEntity {Host = "localhost"};

            Repository<BlogEntity>.SaveOrUpdate(blog);

            UnitOfWork.Current.Flush();
        }

        public override void When() { fetchedBlog = repository.Fetch("localhost"); }

        [Test]
        public void Should_Not_Be_Null() { fetchedBlog.ShouldNotBeNull(); }
    }
}