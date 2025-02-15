using WSUniversalLib;

namespace test_demo_var1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int productType, materialType, count; float width, length;

                Console.WriteLine("Введите тип продукции: ");
                productType = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите тип материала: ");
                materialType = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество единиц продукции: ");
                count = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ширину продукции: ");
                width = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите длину продукции: ");
                length = float.Parse(Console.ReadLine());

                Calculation calc = new Calculation();
                Console.WriteLine("Результат: " + calc.GetQuantityForProduct(productType, materialType, count, width, length));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
