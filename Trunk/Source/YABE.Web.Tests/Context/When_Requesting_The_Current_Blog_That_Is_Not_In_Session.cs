namespace YABE.Web.Tests.Context
{
    using System;
    using Domain.Model;
    using NUnit.Framework;
    using Rhino.Mocks;
    using Test.Extensions;

    [TestFixture]
    public class When_Requesting_The_Current_Blog_That_Is_Not_In_Session : ContextSpecification
    {
        protected BlogEntity currentBlog;

        public override void  Under_These_Conditions()
        {
            mockRequest.Expect(x => x.Url).Return(new Uri("http://localhost/"));
            mockRepository.Expect(x => x.Fetch("localhost")).Return(new BlogEntity() { Host = "localhost"});
        }

        public override void When()
        {
            currentBlog = context.CurrentBlog;
        }

        [Test]
        public void Should_Fetch_Blog_From_DB()
        {
            mockRepository.VerifyAllExpectations();
        }

        [Test]
        public void Should_Not_Be_Null()
        {
            currentBlog.ShouldNotBeNull();
        }

        [Test]
        public void Should_Set_Blog_In_Session()
        {
            mockSession["blog"].ShouldNotBeNull();
        }
    }
}