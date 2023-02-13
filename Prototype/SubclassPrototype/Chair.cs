class Chair : Product
{
    public string material { get; set; }
    public string shape { get; set; }
    public Chair(string name, int price, string material, string shape) : base(name, price)
    {
        this.material = material;
        this.shape = shape;
    }

    public new Prototype Clone()
    {
        return new Chair(this.name, this.price, this.material, this.shape);
    }
    public override string ToString()
    {
        return base.ToString() + " Material: " + this.material + " shape: " + this.shape;
    }

}