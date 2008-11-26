namespace YABE.Domain.Tests.Post
{
    using Model;
    using NUnit.Framework;
    using Test.Extensions;

    [TestFixture]
    public class When_Validate_Is_Called_And_Post_Is_Not_Valid : PostSpecification
    {
        private RuleViolationException exception;

        public override void Under_These_Conditions()
        {
            post.Text = "";
            post.Blog = null;
            post.Title = "";
            post.Slug = "";
        }

        public override void When()
        {
            try
            {
                post.Validate();
            }
            catch (RuleViolationException ex)
            {
                exception = ex;
            }
        }

        [Test]
        public void Should_Set_Violations_In_Exception()
        {
            exception.Violations.Count.ShouldBe(3);
        }
    }
}