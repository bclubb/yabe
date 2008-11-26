namespace YABE.Domain.Tests.Blog
{
    using Model;
    using NUnit.Framework;
    using Test.Extensions;

    [TestFixture]
    public class When_Validate_Is_Called_And_Blog_Is_Not_Valid : BlogSpecification
    {
        private RuleViolationException exception;

        [Test]
        public void Should_Throw_RuleException()
        {
            exception.ShouldNotBeNull();
        }

        [Test]
        public void Should_Set_RuleViolation_In_Exception()
        {
            exception.Violations.ShouldNotBeNull();
            exception.Violations.Count.ShouldBe(1);
            exception.Violations[0].Message.ShouldNotBeEmpty();
        }

        public override void Under_These_Conditions()
        {
            blog.Host = "";
        }

        public override void When()
        {
            try
            {
                blog.Validate();
            }
            catch(RuleViolationException ex)
            {
                exception = ex;
            }
        }
    }
}