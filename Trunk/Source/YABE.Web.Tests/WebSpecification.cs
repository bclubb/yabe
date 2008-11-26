namespace YABE.Web.Tests
{
    using System.Collections.Specialized;
    using System.Web;
    using NUnit.Framework;
    using Rhino.Mocks;
    using Test.Extensions;

    public class WebSpecification : ISpecification
    {
        protected HttpContextBase mockContext;
        protected HttpRequestBase mockRequest;
        protected MockSession mockSession;
        protected NameValueCollection formCollection;
        protected NameValueCollection querystringCollection;

        [SetUp]
        public virtual void SetUp()
        {
            mockRequest = MockRepository.GenerateStub<HttpRequestBase>();
            mockContext = MockRepository.GenerateStub<HttpContextBase>();
            mockSession = new MockSession();

            formCollection = new NameValueCollection();
            querystringCollection = new NameValueCollection();

            mockRequest.Stub(x => x.Form).Return(formCollection);
            mockRequest.Stub(x => x.QueryString).Return(querystringCollection);

            mockContext.Stub(x => x.Request).Return(mockRequest);
            mockContext.Stub(x => x.Session).Return(mockSession);
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