namespace YABE.Web.Tests.Context
{
    using System;
    using Domain.Model;
    using NUnit.Framework;
    using Rhino.Mocks;
    using Test.Extensions;

    [TestFixture]
    public class When_Requesting_The_Current_Blog_That_Is_In_Session : ContextSpecification
    {
        protected BlogEntity currentBlog;
        private BlogEntity testBlog;

        public override void Under_These_Conditions()
        {
            testBlog = new BlogEntity() { Host = "localhost"};
            mockSession.Add("blog", testBlog);
            mockRequest.Expect(x => x.Url).Return(new Uri("http://localhost/")).Repeat.Any();
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
        public void Should_Be_The_Same_As_The_One_In_Session()
        {
            currentBlog.ShouldBeTheSameAs(testBlog);
        }
    }
}