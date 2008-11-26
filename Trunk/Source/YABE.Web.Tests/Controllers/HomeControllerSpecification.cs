namespace YABE.Web.Tests.Controllers.Home
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Components;
    using Domain.Model;
    using Domain.Repositories;
    using Model;
    using NUnit.Framework;
    using Rhino.Mocks;
    using Test.Extensions;
    using Web.Controllers;

    public class HomeControllerSpecification : WebSpecification
    {
        protected IAppContext appContextMock;
        protected HomeController controller;
        protected IPostRepository mockRepository;

        public override void SetUp()
        {
            base.SetUp();

            appContextMock = MockRepository.GenerateStub<IAppContext>();
            mockRepository = MockRepository.GenerateMock<IPostRepository>();
            controller = new HomeController(appContextMock, mockRepository);

            Under_These_Conditions();
            When();
        }
    }

    [TestFixture]
    public class When_Getting_Index_And_The_Current_Blog_Is_Null : HomeControllerSpecification
    {
        private ActionResult actionResult;

        public override void Under_These_Conditions()
        {
            appContextMock.Expect(x => x.CurrentBlog).Return(null);
        }

        public override void When()
        {
            actionResult = controller.Index();
        }

        [Test]
        public void Should_Redirect_To_New_Blog()
        {
            var result = actionResult as RedirectToRouteResult;

            result.ShouldNotBeNull();
            result.Values["Controller"].ShouldBe("Blog");
            result.Values["Action"].ShouldBe("Create");
        }
    }

    [TestFixture]
    public class When_Getting_Index_And_The_Current_Blog_Is_Not_Null : HomeControllerSpecification
    {
        private ActionResult actionResult;
        private BlogEntity blog;

        public override void Under_These_Conditions()
        {
            blog = new BlogEntity();
            blog.Options.NumberOfPostsToShowOnHomePage = 2;

            appContextMock.Stub(x => x.CurrentBlog).Return(blog);
            mockRepository.Expect(x => x.FetchCurrentPosts(2)).Return(new List<PostEntity>());
        }

        public override void When()
        {
            actionResult = controller.Index();
        }

        [Test]
        public void Should_Render_Index_View()
        {
            var result = actionResult as ViewResult;
            result.ShouldNotBeNull();
            result.ViewName.ShouldBe("Index");
        }

        [Test]
        public void Should_Set_Response_In_ViewData()
        {
            var result = actionResult as ViewResult;
            var response = result.ViewData.Model as HomeIndexResponse;

            response.ShouldNotBeNull();
        }

        [Test]
        public void Should_Set_Current_Posts_In_ViewData()
        {
            var result = actionResult as ViewResult;
            var response = result.ViewData.Model as HomeIndexResponse;

            response.Posts.ShouldNotBeNull();
        }

        [Test]
        public void Should_Request_The_Correct_Number_Of_Posts_From_The_Repository()
        {
            mockRepository.VerifyAllExpectations();
        }
    }
} 