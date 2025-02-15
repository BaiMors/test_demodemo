namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {

            List<double> ProductTypeСoef = new() { 1.1, 2.5, 8.43 };
            List<double> MaterialTypeСoef = new() { 0.3, 0.12 };

            if (productType < 1 || productType > 3) { throw new Exception("Тип продукции должен быть в диапазоне от 1 до 3"); return -1; }
            else if (materialType < 1 || materialType > 2) throw new Exception("Тип материала должен быть в диапазоне от 1 до 2");
            else if (count <= 0) throw new Exception("Количество продукции должно быть натуральным числом");
            else if (width <= 0 || length <= 0) throw new Exception("Ширина и длина продукции должны быть натуральными числами");
            else
            {
                double quantityWithoutDefect = (width * length) * count * ProductTypeСoef[productType - 1];
                return (int)Math.Ceiling(quantityWithoutDefect + quantityWithoutDefect * (MaterialTypeСoef[materialType - 1] / 100));
            }
        }
    }
}
