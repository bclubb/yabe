namespace YABE.Domain.Tests.Post
{
    using Model;
    using Test.Extensions;
    using NUnit.Framework;

    public class PostSpecification : ISpecification
    {
        protected PostEntity post;

        [SetUp]
        public void SetUp()
        {
            post = new PostEntity();
            Under_These_Conditions();
            When();
        }

        public virtual void Under_These_Conditions()
        {
            // do nothing
        }

        public virtual void When()
        {
            // do nothing
        }
    }
}