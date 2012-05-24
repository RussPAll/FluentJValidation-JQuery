using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Validators;

namespace WebFormsApp.App_Code
{
    public class FluentJQueryValidation
    {
        public string GenerateScript<T>(AbstractValidator<T> validator, string clientTagNamesPrefix = "")
        {
            string result = "";
            foreach (var member in validator)
            {
                var propertyRuleMember = member as PropertyRule;
                if (propertyRuleMember == null) continue;

                var clientTagName = clientTagNamesPrefix + propertyRuleMember.Member.Name;
                foreach (var rule in member.Validators)
                {
                    if (rule is NotEmptyValidator)
                        result += GetNotEmptyScript(clientTagName, (NotEmptyValidator)rule);
                }
            }
            return result;
        }

        private string GetNotEmptyScript(string clientTagName, NotEmptyValidator rule)
        {
            return "Blah";
        }
    }
}