namespace YABE.Infrastructure.Tests.Repositories
{
    using DataAccess;
    using NUnit.Framework;
    using Rhino.Commons.ForTesting;
    using Test.Extensions;

    public class RepositorySpecification : DatabaseTestFixtureBase, ISpecification
    {
        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            IntializeNHibernateAndIoC(PersistenceFramework.NHibernate,          // Persistence Framework
                                      "Castle.config",                          // Configuration
                                      DatabaseEngine.MsSql2005,                 // Database Type
                                      "YABE_Test",                              // Database Name
                                      @"(local)\SQL2005",                       // Server Name
                                      false,                                    // Create Schema
                                      MappingInfo.FromAssemblyContaining<BlogRepository>(), // NH Mappings
                                      null);
        }

        [SetUp]
        public void SetUp()
        {
            CurrentContext.CreateUnitOfWork();

            Under_These_Conditions();
            When();
        }

        [TearDown]
        public virtual void TearDown()
        {
            ClearAllData();
            CurrentContext.DisposeUnitOfWork();
        }

        #region Template Methods

        public virtual void Under_These_Conditions()
        {
            // do nothing
        }

        public virtual void When()
        {
            // do nothing
        }

        protected virtual void ClearAllData()
        {
            // do nothing
        }

        #endregion
    }
}