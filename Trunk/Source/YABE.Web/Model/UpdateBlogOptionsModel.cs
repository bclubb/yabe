namespace YABE.Web.Model
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Domain.Model;

    public class UpdateBlogOptionsModel
    {
        public UpdateBlogOptionsModel() {}
        public UpdateBlogOptionsModel(BlogOptions options)
        {
            NumberOfPostsToShowOnHomePage = options.NumberOfPostsToShowOnHomePage;
        }

        public string Message { get; set; }
        public int NumberOfPostsToShowOnHomePage { get; set; }
        public SelectList NumberOfPostsToShowOnHomePageList
        {
            get
            {
                return new SelectList(new Dictionary<string, string>
                                          {
                                              {"1", "One"},
                                              {"2", "Two"},
                                              {"3", "Three"},
                                              {"4", "Four"},
                                              {"5", "Five"}
                                          }, "Key", "Value", NumberOfPostsToShowOnHomePage);
            }
        }
    }
}