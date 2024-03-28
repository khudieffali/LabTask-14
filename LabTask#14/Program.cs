using LabTask_14;

class Program
{
    static void Main(string[] args)
    {
        Product product = new(1, "Lenovo", "ideapad 5", 1200, 50, 10);
        Product product1 = new(1, "Asus", "Rog", 1000, 50, 0);
        Product product2 = new(1, "Hp", "Pavilion", 1500, 60, 5);
        product.GetInfo(product);
        




    }
}
