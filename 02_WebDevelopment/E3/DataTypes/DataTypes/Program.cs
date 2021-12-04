// See https://aka.ms/new-console-template for more information
using DataTypes;

List<Customer> customers = new List<Customer>();
customers.Add(new Customer("isaac", "valdespino", DateTime.Now));
customers.Add(new Customer("aldo", "rivera", DateTime.Now));
customers.Add(new Customer("antonio", "soros", DateTime.Now));
customers.Add(new Customer("margarita", "medina", DateTime.Now));
customers.Add(new Customer("antonio", "gachuz", DateTime.Now));
customers.Add(new Customer("antonia", "vaca", DateTime.Now));
customers.Add(new Customer("robert", "espinoza", DateTime.Now));
customers.Add(new Customer("roberto", "archindia", DateTime.Now));
customers.Add(new Customer("juan", "rodriguez", DateTime.Now));
customers.Add(new Customer("jose", "medina", DateTime.Now));

foreach (Customer customer in customers)
{
    string cad = $"Client Name: {customer.Name} Registration date: {customer.RegisterDate.ToString()}";
    Console.WriteLine(cad);
}
int i = 0;
for (; i < customers.Count; i++)
{
    Customer customer = customers[i];
    string cad = $"Client Name: {customer.Name} Registration date: {customer.RegisterDate.ToString()}";
    Console.WriteLine(cad);
}

i = 0;
while (i < customers.Count)
{
    Customer customer = customers[i];
    string cad = $"Client Name: {customer.Name} Registration date: {customer.RegisterDate.ToString()}";
    Console.WriteLine(cad);
    i++;
}

i = 0;
do
{
    Customer customer = customers[i];
    string cad = $"Client Name: {customer.Name} Registration date: {customer.RegisterDate}";
    Console.WriteLine(cad);
    i++;
} while (i < customers.Count);