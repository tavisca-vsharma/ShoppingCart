using System.Collections.Generic;

namespace ShoppingCart
{
    public class User
    {
        //orchaestrater class
        private ProductStore _productStore = new ProductStore();
        public Cart _cartOfCustomer = new Cart();
        public CostCalculator _costCalculator = new CostCalculator(_cartOfCustomer);
        
        public void AddProductItemToProducts(Product product, int quantity)
        {
            _productStore.AddProductToStore(product,quantity);
        }
        public void SetCostsToProducts(Product product, int cost)
        {
            _costCalculator.SetCosts(product, cost);
        }
        public int GetCostsToProducts()
        {
            return _costCalculator.GetCosts();
        }
        public Dictionary<Product,int> GetItemsInCart()
        {
            return _cartOfCustomer.ReturnProducts();
        }

        //public void RemoveProductItemToProducts(Product product, int quantity)
        //{
        //    _productStore.AddProductToStore(product);
        //}

    }



}
