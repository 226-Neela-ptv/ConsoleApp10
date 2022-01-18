using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Product pd = new Product();
            string name = pd.GetProductName();
            string price = pd.GetProductPrice();
            Console.WriteLine(name + " is located at " + price);
        }
    }
}
