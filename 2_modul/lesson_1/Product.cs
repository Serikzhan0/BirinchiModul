namespace lesson_1;

public class Product
{
    public Guid ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int Type { get; set; }


    public override string ToString()
    {
        return $"ProductId: {ProductId}, Name: {Name}, Price: {Price}, Quantity: {Quantity}, Type: {Type}";
    }
}
