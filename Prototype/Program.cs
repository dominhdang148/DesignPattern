Table t1 = new Table("Table", 100, "brown", 3, 4, 5);
Chair c1 = new Chair("Chair", 50, "wood", "square");

Table t2 = (Table)t1.Clone();
Chair c2 = (Chair)c1.Clone();
// Table t2 = t1;
// Chair c2 = c1;

Console.Clear();

Console.WriteLine("================== BEFORE CHANGING ================");

Console.WriteLine(t1);
Console.WriteLine(t2);

Console.WriteLine(c1);
Console.WriteLine(c2);

Console.WriteLine("================== AFTER CHANGING =================");

t1.color = "black";
t1.width = 6;
t1.height = 3;
t1.length = 7;

c1.material = "plastic";
c1.shape = "circle";

Console.WriteLine(t1);
Console.WriteLine(t2);

Console.WriteLine(c1);
Console.WriteLine(c2);

Console.ReadKey();