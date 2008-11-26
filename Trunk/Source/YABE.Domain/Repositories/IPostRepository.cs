namespace YABE.Domain.Repositories
{
    using System.Collections.Generic;
    using Model;

    public interface IPostRepository
    {
        IList<PostEntity> FetchCurrentPosts(int numberToReturn);
        void Save(PostEntity post);
    }
}