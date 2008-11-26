namespace YABE.Infrastructure.Tests.Repositories.Post
{
    using System;
    using System.Collections.Generic;
    using Domain.Model;
    using Domain.Repositories;
    using NHibernate.Criterion;
    using NUnit.Framework;
    using Rhino.Commons;
    using Test.Extensions;

    [TestFixture]
    public class When_Saving_A_New_Post : PostRepositorySpecification
    {
        private PostEntity post;
        private BlogEntity blog;
        private IPostRepository repository;

        public override void Under_These_Conditions()
        {
            repository = IoC.Resolve<IPostRepository>();

            blog = new BlogEntity {Host = "localhost"};

            Repository<BlogEntity>.SaveOrUpdate(blog);

            UnitOfWork.Current.Flush();

            post = new PostEntity
                       {
                           Blog = blog,
                           DatePublished = DateTime.Today,
                           Title = "Test",
                           Text = "This is a test",
                           Slug = "This-is-a-clean-url"
                       };
        }

        public override void When() { repository.Save(post); }

        [Test]
        public void Should_Save_To_Database()
        {
            ICollection<PostEntity> results = Repository<PostEntity>.FindAll(DetachedCriteria.For(typeof (PostEntity)), new Order[] {});
            results.Count.ShouldBe(1);
        }
    }
}