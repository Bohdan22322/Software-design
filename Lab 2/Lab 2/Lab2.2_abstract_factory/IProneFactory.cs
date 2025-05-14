public class IProneFactory : IBrandFactory
{
    public IDevice CreateLaptop() => new Laptop();
    public IDevice CreateSmartphone() => new Smartphone();
    public IDevice CreateEBook() => new EBook();
}
