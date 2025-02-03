using System.Text;

class Order {
    public DateTime Date { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public Client Client { get; set; }
    List<OrderItem> OrderItems = new List<OrderItem>();

    public Order() { }

    public Order(DateTime date, OrderStatus orderStatus, Client client) {
        Date = date;
        OrderStatus = orderStatus;
        Client = client;
    }

    public void AddItems(OrderItem item) {
        OrderItems.Add(item);
    }

    public void RemoveItems(OrderItem item) {
        OrderItems.Remove(item); // Corrigido: agora remove o item da lista
    }

    public double Total() {
        double sum = 0.0;
        foreach (OrderItem item in OrderItems) {
            sum += item.subTotal();
        }
        return sum;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Order moment: " + Date);
        sb.AppendLine("Order status: " + OrderStatus);
        sb.AppendLine("Client: " + Client.Name);  // Corrigido: agora exibe o nome do cliente
        sb.AppendLine("Order items: ");
        foreach (OrderItem item in OrderItems) {
            sb.AppendLine(item.ToString());
        }
        sb.AppendLine("Total price: $" + Total().ToString("F2"));
        return sb.ToString();
    }
}
