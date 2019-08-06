using System.Collections.Generic;

namespace ShoppingCart
{
    public class ProductStore
    {
        private Dictionary<Product, int> _productToStore = new Dictionary<Product, int>();
        public void AddProductToStore(Product product, int quantity)
        {
            if(_productToStore.ContainsKey(product))
            {
                _productToStore[product] += quantity;
            }

            else
            {
                _productToStore.Add(product, quantity);
            }
        }
    }



}
