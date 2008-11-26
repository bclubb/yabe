namespace YABE.Web.Tests.Controllers
{
    #region Usings 

    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Components;
    using Domain.Model;
    using Domain.Repositories;
    using Model;
    using NUnit.Framework;
    using Rhino.Mocks;
    using Test.Extensions;
    using Web.Controllers;

    #endregion

    public class BlogControllerSpecification : WebSpecification
    {
        protected BlogController controller;
        protected IBlogRepository repository;
        protected IAppContext appContext;

        public override void SetUp()
        {
            base.SetUp();

            repository = MockRepository.GenerateMock<IBlogRepository>();
            appContext = MockRepository.GenerateStub<IAppContext>();
            controller = new BlogController(repository, appContext);
            controller.ControllerContext = new ControllerContext(mockContext, new RouteData(), controller);

            Under_These_Conditions();
            When();
        }
    }

    [TestFixture]
    public class When_Getting_Create : BlogControllerSpecification
    {
        private ActionResult result;

        public override void Under_These_Conditions()
        {
            // do nothing
        }

        public override void When()
        {
            result = controller.Create();
        }

        [Test]
        public void Should_Display_Default_View()
        {
            var viewResult = result as ViewResult;
            viewResult.ShouldNotBeNull();
        }
    }

    [TestFixture]
    public class When_Posting_Create_And_The_Blog_Is_Not_Vaild : BlogControllerSpecification
    {
        private ActionResult actionResult;
        private CreateBlogModel model;

        public override void Under_These_Conditions()
        {
            model = MockRepository.GenerateStub<CreateBlogModel>();
            model.Blog = MockRepository.GenerateStub<BlogEntity>();

            IList<RuleViolation> violations = new List<RuleViolation>();
            violations.Add(new RuleViolation("Blog.Test1", "This is a test"));
            violations.Add(new RuleViolation("Blog.Test2", "This is a test"));

            model.Blog.Expect(x => x.Validate()).Throw(new RuleViolationException(violations));
        }

        public override void When()
        {
            actionResult = controller.Create(model);
        }

        [Test]
        public void Should_Set_Violations_In_ModelState()
        {
            controller.ViewData.ModelState.Count.ShouldBe(2);
        }

        [Test]
        public void ModelState_Key_Should_Have_Object_Prefix()
        {
            controller.ViewData.ModelState["Blog.Test1"].ShouldNotBeNull();
            controller.ViewData.ModelState["Blog.Test2"].ShouldNotBeNull();
        }

        [Test]
        public void Should_Display_Default_View()
        {
            var result = actionResult as ViewResult;
            result.ShouldNotBeNull();
        }
    }

    [TestFixture]
    public class When_Posting_Create_And_The_Blog_Is_Valid : BlogControllerSpecification
    {
        private ActionResult actionResult;
        private CreateBlogModel model;

        public override void Under_These_Conditions()
        {
            model = new CreateBlogModel();
            model.Blog = MockRepository.GenerateStub<BlogEntity>();

            // mocked to prevent the method from actually validating and throwing the exception
            model.Blog.Stub(x => x.Validate());

            repository.Expect(x => x.Save(model.Blog));
        }

        public override void When()
        {
            actionResult = controller.Create(model);
        }

        [Test]
        public void Should_Set_Default_Result_To_Redirect_To_Blog_Options()
        {
            var redirectResult = actionResult as RedirectToRouteResult;
            redirectResult.ShouldNotBeNull();
            redirectResult.Values["Action"].ShouldBe("Options");
        }

        [Test]
        public void Should_Use_Repository_To_Save_Blog()
        {
            repository.VerifyAllExpectations();
        }
    }

    [TestFixture]
    public class When_getting_options : BlogControllerSpecification
    {
        private ActionResult result;
        private BlogEntity blog;

        public override void Under_These_Conditions()
        {
            blog = new BlogEntity();
            blog.Options.NumberOfPostsToShowOnHomePage = 4;

            appContext.Expect(x => x.CurrentBlog).Return(blog);
        }

        public override void When()
        {
            result = controller.Options();
        }

        [Test]
        public void Should_set_the_default_action_to_show_options_view()
        {
            var viewResult = result as ViewResult;
            viewResult.ShouldNotBeNull();
        }

        [Test]
        public void Should_set_the_correct_model()
        {
            var viewResult = (ViewResult) result;
            viewResult.ViewData.Model.ShouldBeOfType(typeof(UpdateBlogOptionsModel));
        }

        [Test]
        public void Should_set_the_correct_model_data()
        {
            var viewResult = (ViewResult)result;
            var model = (UpdateBlogOptionsModel) viewResult.ViewData.Model;

            model.NumberOfPostsToShowOnHomePage = 4;
        }
    }

    [TestFixture]
    public class When_posting_options : BlogControllerSpecification
    {
        private UpdateBlogOptionsModel optionsModel;
        private ActionResult result;
        private BlogEntity blog;

        public override void Under_These_Conditions()
        {
            blog = new BlogEntity();
            optionsModel = new UpdateBlogOptionsModel();
            appContext.Expect(x => x.CurrentBlog).Return(blog).Repeat.Any();

            repository.Expect(x => x.Save(appContext.CurrentBlog));
        }

        public override void When()
        {
            result = controller.Options(optionsModel);
        }

        [Test]
        public void should_save_the_blog()
        {
            repository.VerifyAllExpectations();
        }

        [Test]
        public void should_set_the_default_view_to_options()
        {
            (result as ViewResult).ShouldNotBeNull();
        }

        [Test]
        public void should_set_success_message()
        {
            optionsModel = ((ViewResult) result).ViewData.Model as UpdateBlogOptionsModel;
            optionsModel.ShouldNotBeNull();

            optionsModel.Message.ShouldNotBeEmpty();
        }
    }
}
    