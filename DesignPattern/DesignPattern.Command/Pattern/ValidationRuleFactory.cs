using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Pattern
{
    class ValidationRuleFactory
    {
        public static IValidationRule GetRule(string ruleType)
        {
            switch(ruleType)
            {
                case "description":
                    return new DescriptionValidation();
            }

            return null;
        }
    }
}
