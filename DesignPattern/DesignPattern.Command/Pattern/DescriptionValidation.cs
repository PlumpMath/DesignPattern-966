using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Pattern
{
    public class DescriptionValidation : IValidationRule
    {
        public string Model { get; set; }

        public DescriptionValidation() { }

        public DescriptionValidation(string model)
        {
            Model = model;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Model))
                throw new Exception();
        }
    }
}
