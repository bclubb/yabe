namespace YABE.Web.Tests.Context
{
    using Components;
    using Domain.Repositories;
    using Rhino.Mocks;

    public abstract class ContextSpecification : WebSpecification 
    {
        protected IBlogRepository mockRepository;
        protected WebAppContext context;

        public override void SetUp()
        {
            base.SetUp();

            mockRepository = MockRepository.GenerateStub<IBlogRepository>();
            context = new WebAppContext(mockContext, mockRepository);

            Under_These_Conditions();
            When();
        }
    }
}