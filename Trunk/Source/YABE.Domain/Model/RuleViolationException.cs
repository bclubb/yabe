namespace YABE.Domain.Model
{
    using System;
    using System.Collections.Generic;

    public class RuleViolationException : Exception
    {
        public IList<RuleViolation> Violations { get; private set; }

        public RuleViolationException(IList<RuleViolation> violations)
        {
            Violations = violations;
        }
    }
}