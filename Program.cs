using System.Globalization;

class Program {
    static void Main(string[] args) {
        System.Console.WriteLine("Enter client data: ");
        System.Console.Write("Name: ");
        string Cname = Console.ReadLine();
        System.Console.Write("Email: ");
        string Cemail = Console.ReadLine();
        System.Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime Cdate = DateTime.Parse(Console.ReadLine());

        Client client = new Client(Cname, Cemail, Cdate);

        System.Console.WriteLine("Enter order data: ");
        System.Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
        Order order = new Order(DateTime.Now, status, client);

        System.Console.WriteLine("How many items to this order?");
        int n = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < n; i++) {
            System.Console.WriteLine($"Enter #{i + 1} item data: ");  // Corrigido para numerar corretamente
            System.Console.Write("Product name: ");
            string Pname = Console.ReadLine();
            System.Console.Write("Product price: ");
            double Pprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(Pname, Pprice);
            System.Console.Write("Quantity: ");
            int Pqte = int.Parse(Console.ReadLine());
            OrderItem orderItem = new OrderItem(Pqte, Pprice);
            order.AddItems(orderItem);
        }

        Console.WriteLine();
        Console.WriteLine("ORDER SUMMARY:");
        System.Console.WriteLine(order);
    }
}