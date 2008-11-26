namespace YABE.Domain.Model
{
    using System.Collections.Generic;

    public abstract class Entity
    {
#pragma warning disable 649
        // warning disabled so that the compiler does not complain about a setter not being available for Id
        // NHibernate will set it via reflection
        private int id;
#pragma warning restore 649

        public virtual int Id { get { return id;} }

        protected abstract IList<RuleViolation> GetRuleViolations();

        public virtual void Validate()
        {
            IList<RuleViolation> violations = GetRuleViolations();

            if (violations.Count > 0)
            {
                throw new RuleViolationException(violations);
            }
        }
    }
}