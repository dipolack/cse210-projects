    class Product 
    {

        private string name;

        private int id;

        private double price;

        private int quantity;

        public Product(string name, int id, double price, int quantity) 
        {

        this.name = name;

        this.id = id;

        this.price = price;

        this.quantity = quantity;

        }
    

        public double GetPrice() 
        {

        return price * quantity;

        }

        public string GetName() 
        {

        return name;

        }

        public int GetId() 
        {

        return id;

        }

        public int GetQuantity() 
        {

        return quantity;

        }

}