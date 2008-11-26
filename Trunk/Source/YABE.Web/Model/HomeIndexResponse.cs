namespace YABE.Web.Model
{
    using System.Collections.Generic;
    using Domain.Model;

    public class HomeIndexResponse
    {
        public IList<PostEntity> Posts { get; set; }

        public HomeIndexResponse()
        {
            Posts = new List<PostEntity>();
        }
    }
}