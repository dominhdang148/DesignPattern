class Product : Prototype
{
    public string name { get; set; }
    public int price { get; set; }

    public Product(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
    public Prototype Clone()
    {
        return new Product(this.name, this.price);
    }

    public override string ToString()
    {
        return "Name: " + this.name + " Price: " + this.price;
    }

}