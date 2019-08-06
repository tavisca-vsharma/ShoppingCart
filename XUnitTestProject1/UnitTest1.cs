using ShoppingCart;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        User _user = new User();
        Product productMouse = new Product("mouse");//item product is added to Ecommerce Website.

        Product productKeyboard = new Product("keyboard");

        public UnitTest1()
        {
            _user.AddProductItemToProducts(productMouse, 3);
            _user.AddProductItemToProducts(productKeyboard, 2);// item is added to Ecommerce Website.
            _user.SetCostsToProducts(productMouse, 300);
            _user.SetCostsToProducts(productKeyboard, 400);
        }
        [Fact]
        public void Calculate_The_Cost_Test()
        {

            Customer customer = new Customer();
            customer.AddItemToBuy(productMouse);
            _user.SetCostsToProducts(productMouse, 256);
            int result = _user.GetCostsToProducts();
            Assert.Equal(256,result);            
        }
        [Fact]
        public void Add_The_Product_Test()
        {
            Customer customer = new Customer();
            customer.AddItemToBuy(productMouse);
            _user.SetCostsToProducts(productMouse, 256);
            Dictionary<Product, int> result = _user.GetItemsInCart();
            //Dictionary<Product, int> actual = new Dictionary<Product, int> { { productMouse, 1 } };
            Assert.Equal(result, new Dictionary<Product, int> {{ productMouse, 1 }});
                
        }
    }
}
