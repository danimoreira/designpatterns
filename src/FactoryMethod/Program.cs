

using FactoryMethod.CreatorProduct;

class Product
{
    public void Main()
    {
        ProductMethod(new CreatorProductA());
        ProductMethod(new CreatorProductB());

    }

    public void ProductMethod(IFactoryMethod factory)
    {
        var product = factory.Create();

        Console.WriteLine($"Produto {product.Name}: SO: {product.SO} / {product.DatabaseDefault}");        
    }
}

class Program
{
    static void Main(string[] args)
    {
        new Product().Main();
    }
}

