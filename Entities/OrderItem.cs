using System.Globalization;

class OrderItem {
    public int Quantity { get; set; }
    public double Price { get; set; }

    public OrderItem() { }

    public OrderItem(int quantity, double price) {
        Quantity = quantity;
        Price = price;
    }

    public double subTotal() {
        return Quantity * Price;
    }

    public override string ToString() {
        return Quantity + " x " + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " = " + subTotal().ToString("F2", CultureInfo.InvariantCulture);
    }
}