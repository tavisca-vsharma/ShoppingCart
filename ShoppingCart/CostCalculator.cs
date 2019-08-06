using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class CostCalculator
    {
        private Dictionary<Product, int> _productItems = new Dictionary<Product, int>();
        private Dictionary<Product, int> _productCost = new Dictionary<Product, int>();
        private Cart _cart;
        public int _totalCost=0;

        public CostCalculator()
        {

        }
        public CostCalculator(Cart cart)
        {
            this._cart = cart;
        }

        public void GetItems()
        {
            _productItems = _cart.ReturnProducts();
        }
        public void SetCosts(Product product, int cost)
        {
            GetItems();
            Console.WriteLine(_productItems);
            Console.WriteLine("hey you man");
            if(_productCost.ContainsKey(product))
            {
                _productCost[product] = cost;
            }
            else
            {
                _productCost.Add(product, cost);
            }
        }

        public int GetCosts()
        {
            foreach(KeyValuePair<Product, int> kc in _productItems)
            {
                _totalCost += (kc.Value) * _productCost[kc.Key];
            }
            return _totalCost;
        }
    }



}
