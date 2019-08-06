using System.Collections.Generic;

namespace ShoppingCart
{
    public class Cart
    {
        private Dictionary<Product, int> _cartItems = new Dictionary<Product, int>();
        //this clss will have products and can be removed from this cart.
        public void AddToCart(Product product)
        {
            if(_cartItems.ContainsKey(product))
            {
                _cartItems[product] += 1;
            }
            else
            {
                _cartItems.Add(product, 1);
            }
        }
        public void RemoveFromCart(Product product)
        {
            if (!_cartItems.ContainsKey(product))
            {
                throw new ItemNotFoundException();
            }
            else
            {
                _cartItems[product] -= 1;
                if(_cartItems[product]==0)
                {
                    _cartItems.Remove(product);
                }
            }
           
        }
        public Dictionary<Product,int> ReturnProducts()
        {
            return _cartItems;
        }
    }



}
