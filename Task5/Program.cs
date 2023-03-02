using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте программу, в которой создайте класс «Точка» – для описания координат точки на 
 * координатной прямой рис No1. В теле класса создайте следующие закрытые поля: целочисленное 
 * поле для описания координаты точки X и целочисленное поле для описания координаты точки 
 * Y, а также строковое поле для имени точки. Создать три свойства с методами доступа get и 
 * set, а также конструктор класса, который будет инициализировать данные поля значениями 
 * аргументов. Далее создайте класс «Фигура». В теле класса фигура создайте одно поле типа масив 
 * «Точек» и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3 
 * (треугольника) и 4 аргумента (четырехугольника). В теле класса «Фигура» создайте два метода: 1- 
 * й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» и 
 * возвращать длину стороны, формула для расчета d = √(x2 − x1) 2 + (y2 − y1) 2 и метод для 
 * расчета периметра фигуры (подсказка – в методе циклом перебирать массив «Точек», пока в нем 
 * будут элементы, и рассчитывать длину стороны). В методе Main() создать и рассчитать периметр 
 * треугольника, квадрата, прямоугольника, точки выбрать произвольные.
 */
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(-2, 4, "pointA");
            Point pointB = new Point(5, 2, "pointB");
            Point pointC = new Point(3, -3, "pointC");
            Point pointD = new Point(-2, -5, "pointD");

            Figure triangle = new Figure(pointA, pointB, pointC);
            Figure square = new Figure(pointA, pointB, pointC, pointD);
            Figure rectangle = new Figure(pointA, pointB, pointC, pointD);
            triangle.FigureName = "triangle";
            square.FigureName = "square";
            rectangle.FigureName = "rectangle";

            Console.WriteLine($"Perimeter of {triangle.FigureName} equals to {Math.Round(triangle.Perimeter(), 2)} m");
            Console.WriteLine($"Perimeter of {square.FigureName} equals to {Math.Round(square.Perimeter(), 2)} m");
            Console.WriteLine($"Perimeter of {rectangle.FigureName} equals to {Math.Round(rectangle.Perimeter(), 2)} m");

            Console.ReadKey();
        }
    }

    class Point
    {
        private double x;

        private double y;

        private string pointName;

        public Point(double x, double y, string pointName)
        {
            this.x = x;
            this.y = y;
            this.pointName = pointName;
        }

        public double X { get { return x; } set { x = value; } }

        public double Y { get { return y; } set { y = value; } }

        public string PointName { get { return pointName; } set { pointName = value; } }
    }

    class Figure
    {
        private Point[] points;

        private string figureName;

        public Figure(Point pointA, Point pointB, Point pointC)
        {
            this.points = new Point[]{ pointA, pointB, pointC };
        }

        public Figure(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            this.points = new Point[] { pointA, pointB, pointC, pointD };
        }

        public Point[] Points { get {  return points; } }

        public string FigureName { get; set; }

        private double Length(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow((pointA.X - pointA.Y), 2) + Math.Pow((pointB.X - pointB.Y), 2));
        }

        public double Perimeter()
        {
            double perimeter = 0;

            for (int i = 1; i < points.Length; i++)
            {
                perimeter += Length(points[i], points[i - 1]);
            }

            return perimeter;
        }
    }
}
