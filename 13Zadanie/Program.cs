using _13Zadanie;

class Program
{
    public static void Main()
    {
        Product blanket = new("Одеяло двуспальное ", 1850, 15);

        ProductService.AddStock(blanket, 10);
        Console.WriteLine($"Товар: {blanket.Name}\nКоличество: {blanket.Quantity}");

        ProductService.RemoveStock(blanket, 8);
        Console.WriteLine($"Товар: {blanket.Name}\nКоличество: {blanket.Quantity}");

        try
        {
            ProductService.RemoveStock(blanket, 100);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}