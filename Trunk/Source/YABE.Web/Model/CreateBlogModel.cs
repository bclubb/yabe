namespace YABE.Web.Model
{
    using Domain.Model;

    public class CreateBlogModel
    {
        public BlogEntity Blog { get; set; }

        public CreateBlogModel()
        {
            Blog = new BlogEntity();
        }
    }   
}