using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Customer
    {
        Cart _cart = new Cart();
        public void AddItemToBuy(Product product)
        {
            _cart.AddToCart(product);
        }
        public void RemoveItemFromCart(Product product)
        {
            _cart.RemoveFromCart(product);
        }
    }
}
