namespace YABE.Domain.Model
{
    using System;
    using System.Collections.Generic;

    public class PostEntity : Entity
    {
#pragma warning disable 649
        private DateTime dateCreated;
#pragma warning restore 649

        public virtual DateTime DateCreated 
        { 
            get { return dateCreated; }
        }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual BlogEntity Blog { get; set; }
        public virtual DateTime DatePublished { get; set; }
        public virtual string Slug { get; set; }

        protected override IList<RuleViolation> GetRuleViolations()
        {
            var violations = new List<RuleViolation>();

            if (String.IsNullOrEmpty(Title))
            {
                violations.Add(new RuleViolation("Post.Title", Resources.Model.Post_Title_NotEmpty));
            }

            if (Blog == null)
            {
                violations.Add(new RuleViolation("Post.Blog", Resources.Model.Post_Blog_NotNull));
            }

            if (String.IsNullOrEmpty(Slug))
            {
                violations.Add(new RuleViolation("Post.Slug", Resources.Model.Post_Slug_NotEmpty));
            }

            return violations;
        }
    }
}