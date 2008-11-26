namespace YABE.Domain.Tests.Blog
{
    using Model;
    using NUnit.Framework;
    using Test.Extensions;

    public class BlogSpecification : ISpecification
    {
        protected BlogEntity blog;

        [SetUp]
        public virtual void SetUp()
        {
            blog = new BlogEntity();
    
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