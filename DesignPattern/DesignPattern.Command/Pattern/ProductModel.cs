using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Pattern
{
    class ProductModel
    {
        private List<IValidationRule> _validationRules = new List<IValidationRule>();

        public void AddValidationRules(IValidationRule validationRule)
        {
            _validationRules.Add(validationRule);
        }

        public void Validate()
        {
            foreach(IValidationRule val in _validationRules)
            {
                val.Validate();
            }
        }
    }
}
