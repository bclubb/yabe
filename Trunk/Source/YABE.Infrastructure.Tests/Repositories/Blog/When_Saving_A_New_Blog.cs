namespace YABE.Infrastructure.Tests.Repositories.Blog
{
    using System.Collections.Generic;
    using Domain.Model;
    using Domain.Repositories;
    using NHibernate.Criterion;
    using NUnit.Framework;
    using Rhino.Commons;
    using Test.Extensions;

    [TestFixture]
    public class When_Saving_A_New_Blog : BlogRepositorySpecification
    {
        private BlogEntity blog;
        private IBlogRepository repository;

        public override void Under_These_Conditions()
        {
            repository = IoC.Resolve<IBlogRepository>();
            blog = new BlogEntity {Host = "localhost"};
            blog.Options.NumberOfPostsToShowOnHomePage = 5;
        }

        public override void When() { repository.Save(blog); }

        [Test]
        public void Should_Save_To_Database()
        {
            ICollection<BlogEntity> blogs = Repository<BlogEntity>.FindAll(DetachedCriteria.For(typeof (BlogEntity)), new Order[] {});
            blogs.Count.ShouldBe(1);
        }
    }
}