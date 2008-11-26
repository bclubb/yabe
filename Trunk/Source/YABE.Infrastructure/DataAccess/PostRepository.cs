namespace YABE.Infrastructure.DataAccess
{
    using System;
    using System.Collections.Generic;
    using Castle.Services.Transaction;
    using Domain.Model;
    using Domain.Repositories;
    using Query;
    using Rhino.Commons;

    [Transactional]
    public class PostRepository : IPostRepository
    {
        private readonly IRepository<PostEntity> repository;

        public PostRepository(IRepository<PostEntity> repository) { this.repository = repository; }

        #region IPostRepository Members

	[That's Crazy]
        public IList<PostEntity> FetchCurrentPosts(int numberToReturn)
        {
#warning FetchCurrentPosts is not implmented
            var criteria = Where.PostEntity.DatePublished.IsNotNull.ToDetachedCriteria();
            criteria.SetMaxResults(numberToReturn);

            repository.FindAll(criteria, OrderBy.PostEntity.DateCreated.Asc);

            return new List<PostEntity>();
        }

        [Transaction]
        public void Save(PostEntity post) { repository.SaveOrUpdate(post); }

        #endregion
    }
}
