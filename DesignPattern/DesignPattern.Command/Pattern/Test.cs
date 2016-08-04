using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Pattern
{
    class Test
    {
        public void TestMethod()
        {

            ProductModel model = new ProductModel();
            model.AddValidationRules(new DescriptionValidation(""));
            model.AddValidationRules(new TitleValidation());

            model.Validate();
           
        }
    }
}
