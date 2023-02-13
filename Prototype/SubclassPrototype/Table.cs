class Table : Product
{
    public string color { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int length { get; set; }
    public Table(string name, int price, string color, int width, int height, int length) : base(name, price)
    {
        this.color = color;
        this.width = width;
        this.height = height;
        this.length = length;
    }

    public new Prototype Clone()
    {
        return new Table(this.name, this.price, this.color, this.width, this.height, this.length);
    }
    public override string ToString()
    {
        return base.ToString() + " Color: " + this.color + " Width: " + this.width + " Length: " + this.length + " Height: " + this.height;
    }

}