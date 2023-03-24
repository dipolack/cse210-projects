    class Order {

    private Product[] products;

    private Customer customer;

    public Order(Product[] products, Customer customer) {

    this.products = products;

    this.customer = customer;

    }

    public double GetTotalCost() {

    double totalCost = 0;

    foreach (Product product in products) {

    totalCost += product.GetPrice();

    }

    if (customer.IsInUSA()) {

    totalCost += 5;

    } 
    
    else {

    totalCost += 35;

    }

    return totalCost;

    }

    public string GetPackingLabel() {

    string packingLabel = "";

    foreach (Product product in products) {

    packingLabel += product.GetName() + " (ID: " + product.GetId() + ")\n";

    }

    return packingLabel;

    }

    public string GetShippingLabel() {

    Customer customer = this.customer;

    string shippingLabel = customer.GetName() + "\n" + customer.GetAddress().GetAddressString();

    return shippingLabel;

    }


    public void AddProduct(Product product)
    {
        List<Product> productList = new List<Product>(products);
        
        productList.Add(product);
        
        products = productList.ToArray();
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in products)
        {
            totalPrice += product.GetPrice();
        }

    if (customer.IsInUSA())
        {
            totalPrice += 5;
        }
    
    else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

}