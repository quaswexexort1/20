public class Program
{
    public static void Main(string[] args)
    {
        //(x1, y1) - координаты начала, (x2, y2) - координаты конца
        (double x1, double y1, double x2, double y2) vector = (1, 2, 5, 8);

        //выводит координаты начала вектора
        //выводит координаты конца вектора
        Console.WriteLine("Исходный вектор: " + $"({vector.x1}, {vector.y1}), ({vector.x2}, {vector.y2})");

        //вычисление координат удвоенного вектора путем умножения каждой координаты исходного вектора на 2
        (double x1, double y1, double x2, double y2) doubledVector = (vector.x1 * 2, vector.y1 * 2, vector.x2 * 2, vector.y2 * 2);

        Console.WriteLine($"Удвоенный вектор:({doubledVector.x1}, {doubledVector.y1}), ({doubledVector.x2}, {doubledVector.y2})");

        //вычисление площади прямоугольного треугольника
        //Math.Abs(vector.x2 - vector.x1) вычисляет абсолютное значение разницы между x-координатами (горизонтальная проекция, один из катетов)
        //Math.Abs(vector.y2 - vector.y1) вычисляет абсолютное значение разницы между y-координатами (вертикальная проекция, второй катет)
        //площадь прямоугольного треугольника вычисляется как (1/2) * катет1 * катет2
        double triangle = 0.5 * Math.Abs(vector.x2 - vector.x1) * Math.Abs(vector.y2 - vector.y1);

        Console.WriteLine($"Площадь прямоугольного треугольника: {triangle}");
    }
}