namespace YABE.Domain.Model
{
    using System;
    using Resources;
    using System.Collections.Generic;

    public class BlogEntity : Entity
    {
        public BlogEntity()
        {
            Options = new BlogOptions();
        }

        public virtual string Host { get; set; }
        public virtual BlogOptions Options { get; set; }

        protected override IList<RuleViolation> GetRuleViolations()
        {
            IList<RuleViolation> violations = new List<RuleViolation>();

            if (String.IsNullOrEmpty(Host)) { violations.Add(new RuleViolation("Blog.Host", Host, Model.Blog_Host_NotEmpty)); }

            return violations;
        }
    }

    public class BlogOptions
    {
        public BlogOptions()
        {
            NumberOfPostsToShowOnHomePage = 1; // default to 1
        }

        public virtual int NumberOfPostsToShowOnHomePage { get; set; }
    }
}