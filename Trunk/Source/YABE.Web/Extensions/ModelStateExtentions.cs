namespace YABE.Web.Extensions
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Domain.Model;

    public static class ModelStateExtentions
    {
        public static void AddRuleViolations(this ModelStateDictionary modelState, IList<RuleViolation> violations)
        {
            foreach (RuleViolation violation in violations)
            {
                modelState.AddModelError(violation.Name, violation.Message);
            }
        }
    }
}