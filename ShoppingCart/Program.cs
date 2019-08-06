using System;

namespace ShoppingCart
{
    class Program
    {
        private User _user = new User();
        static void Main(string[] args)
        {
            User usr = new User();
            Product prdt1 = new Product("mouse");
            usr.AddProductItemToProducts(prdt1,3);
            Product prdt2 = new Product("keyboard");
            usr.AddProductItemToProducts(prdt2, 2);
            usr.SetCostsToProducts(prdt1, 300);
            usr.SetCostsToProducts(prdt2, 400);
        }
    }
    public class Discount
    {
        
    }



}
