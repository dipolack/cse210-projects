    class Customer 
    {

        private string name;

        private Address address;

        public Customer(string _name, Address _address) {

        this.name = _name;

        this.address = _address;

    }

        public bool IsInUSA() {

        return address.IsInUSA();

        }

        public string GetName() {

        return name;

        }

        public Address GetAddress() {

        return address;

        }

    }

