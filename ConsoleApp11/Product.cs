using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Product : IProduct
    {
        public string GetProductName()
        {
            return "Mobile";

        }
        public string GetProductPrice()
        {
            return " Four thousand";

        }

    }

}
