using AbstractFactory.AbstractFactory;

class Product
{
    public void Main()
    {
        ProductMethod(new ConcrectFactoryDedicated());
        ProductMethod(new ConcrectFactoryShared());

    }

    public void ProductMethod(IAbstractFactory factory)
    {
        var productRM = factory.CreateProductRM();
        var productProtheus = factory.CreateProductProtheus();
        var productDatasul = factory.CreateProductDatasul();

        Console.WriteLine($"Produto RM: {productRM.DatabaseType} / {productRM.OperatingSystem} / {productRM.InstanceType}");
        Console.WriteLine($"Produto Protheus: {productProtheus.DatabaseType} / {productProtheus.OperatingSystem} / {productProtheus.InstanceType}");
        Console.WriteLine($"Produto Datasul: {productDatasul.DatabaseType} / {productDatasul.OperatingSystem} / {productDatasul.InstanceType}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        new Product().Main();
    }
}

