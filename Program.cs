using Ecommerce.Entities;
using Ecommerce.Entities.Enums;
using System.Globalization;

System.Console.WriteLine("Enter cliente data:");
System.Console.Write("Name: ");
string name = Console.ReadLine();
System.Console.Write("Email: ");
string email = Console.ReadLine();
System.Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
System.Console.WriteLine("Enter order data: ");
System.Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client c1 = new Client(name, email, birthDate);
Order order = new Order(DateTime.Now, status, c1);

System.Console.Write("How many items to this order? ");

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    System.Console.WriteLine($"Enter #{i + 1} item data: ");
    System.Console.Write("Product name: ");
    string nameProd = Console.ReadLine();
    System.Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    System.Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    
    Product p = new Product(nameProd, price);
    OrderItem item = new OrderItem(quantity, price, p);
    order.AddItem(item);

}
System.Console.WriteLine("ORDER SUMARY: ");
System.Console.WriteLine(order);

