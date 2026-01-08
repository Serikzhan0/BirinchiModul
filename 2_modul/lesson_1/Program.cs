namespace lesson_1;

internal class Program
{
    static void Main(string[] args)
    {
                Product product = new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Milk",
                    Price = 15000,
                    Quantity = 10,
                    Type = 1
                };

                // Console.WriteLine(product.ToString());
        
                Console.WriteLine(product);
            }
        }

    

