namespace YABE.Domain.Tests.Post
{
    using System;
    using Model;
    using NUnit.Framework;
    using Test.Extensions;

    [TestFixture]
    public class PostFixture
    {
        [Test]
        public void Can_Create_Post()
        {
            var post = new PostEntity();
            post.ShouldNotBeNull();
        }

        [Test]
        public void Can_Get_Date()
        {
            var post = new PostEntity();
            post.DateCreated.ShouldNotBeNull();
        }

        [Test]
        public void Can_Get_Set_DatePublished()
        {
            var post = new PostEntity();
            post.DatePublished = DateTime.Today;
            post.DatePublished.ShouldBe(DateTime.Today);
        }

        [Test]
        public void Can_Get_Set_Title()
        {
            var post = new PostEntity();
            post.Title = "This is a Test";
            post.Title.ShouldBe("This is a Test");
        }

        [Test]
        public void Can_Get_Set_Text()
        {
            var post = new PostEntity();
            post.Text = "This is some text";
            post.Text.ShouldBe("This is some text");
        }

        [Test]
        public void Can_Get_Set_Blog()
        {
            var post = new PostEntity();
            post.Blog = new BlogEntity();
            post.Blog.ShouldNotBeNull();
        }

        [Test]
        public void Can_Get_Set_Slug()
        {
            var post = new PostEntity();
            post.Slug = "a-clean-url";
            post.Slug.ShouldBe("a-clean-url");
        }
    }
}