using System;
using System.Collections.Generic;
using System.Linq;
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

            Figure figureT = new Figure(pointA, pointB, pointC, "triangle");
            Figure figureS = new Figure(pointA, pointB, pointC, "square");
            Figure figureR = new Figure(pointA, pointB, pointC, "rectangle");

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

        public Figure(Point pointA, Point pointB, Point pointC, string figureName)
        {
            this.points = new Point[]{ pointA, pointB, pointC };
            this.figureName = figureName;
        }

        public Point[] Points { get {  return points; } }
    }
}
