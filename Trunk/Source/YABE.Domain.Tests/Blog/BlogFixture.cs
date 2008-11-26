namespace YABE.Domain.Tests.Blog
{
    using Model;
    using NUnit.Framework;
    using Test.Extensions;

    [TestFixture]
    public class BlogFixture
    {
        [Test]
        public void Can_Create_Blog()
        {
            var blog = new BlogEntity();
            blog.ShouldNotBeNull();
        }

        [Test]
        public void Creating_A_Blog_Creates_Options()
        {
            var blog = new BlogEntity();
            blog.Options.ShouldNotBeNull();
        }

        [Test]
        public void Can_Get_Set_Options_NumberOfPostsToShowOnHomePage()
        {
            var blog = new BlogEntity();
            blog.Options.NumberOfPostsToShowOnHomePage = 2;
            blog.Options.NumberOfPostsToShowOnHomePage.ShouldBe(2);
        }

        [Test]
        public void Can_Get_And_Set_Host()
        {
            var blog = new BlogEntity();
            blog.Host = "localhost";
            blog.Host.ShouldBe("localhost");
        }
    }
}