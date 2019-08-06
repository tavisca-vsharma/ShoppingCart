namespace ShoppingCart
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string productName)
        {
            this.productName = productName;
            //this.quantity = quantity;
        }

        //product with its various fields.
        string productName { get; set; }
        //int quantity { get; set; }
    }



}
