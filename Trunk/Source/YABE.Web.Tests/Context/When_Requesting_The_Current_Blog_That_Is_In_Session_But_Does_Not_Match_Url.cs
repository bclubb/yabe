namespace YABE.Web.Tests.Context
{
    using System;
    using Domain.Model;
    using NUnit.Framework;
    using Rhino.Mocks;
    using Test.Extensions;

    [TestFixture]
    public class When_Requesting_The_Current_Blog_That_Is_In_Session_But_Does_Not_Match_Url : ContextSpecification
    {
        protected BlogEntity currentBlog;

        public override void Under_These_Conditions()
        {
            mockSession.Add("blog", new BlogEntity() {Host="somedomain"});
            mockRequest.Expect(x => x.Url).Return(new Uri("http://localhost/")).Repeat.Any();
            mockRepository.Expect(x => x.Fetch("localhost")).Return(new BlogEntity() { Host = "localhost" });
        }

        public override void When()
        {
            currentBlog = context.CurrentBlog;
        }

        [Test]
        public void Should_Not_Be_Null()
        {
            currentBlog.ShouldNotBeNull();
        }

        [Test]
        public void Should_Have_Correct_Host()
        {
            currentBlog.Host.ShouldBe("localhost");
        }

        [Test]
        public void Should_Put_New_Blog_In_Session()
        {
            mockSession["blog"].ShouldNotBeNull();
            var blog = mockSession["blog"] as BlogEntity;
            blog.Host.ShouldBe("localhost");
        }

        [Test]
        public void Should_Fetch_Blog_From_Db()
        {
            mockRepository.VerifyAllExpectations();
        }
    }
}