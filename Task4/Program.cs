using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте программу, в которой создайте класс «Треугольник». В теле класса создайте три 
 * закрытых поля для описания сторон треугольника и три свойства для чтения и записи. Также в 
 * теле класса создайте 3 метода: 1-й для расчета площади треугольника, формула для расчета S = 
 * √p ∗ (p − a) ∗ (p − b) ∗ (p − c), где p - полупериметр треугольника p = (a + b + c)/2, a, b, c – 
 * длины сторон треугольника, 2-й для расчета периметра треугольника, формула для расчета p = 
 * (a + b + c)/2 и 3-й для вывода информации о площади и периметре треугольника. Создайте 
 * конструктор, который в качестве аргументов приминимает стороны треугольника и 
 * инициализирует поля класса. В методе Main() создайте экземпляр класса «Треугольник», задайте 
 * произвольное значение сторон треугольника и выведите на экран значение периметра и 
 * площади треугольника.
 */
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle Triangle = new Triangle();
            Triangle.SideA = 10.2;
            Triangle.SideB = 8.5;
            Triangle.SideC = 13;
            Triangle.ShowInfo();

            Console.ReadKey();
        }
    }

    class Triangle
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        private double Square()
        {
            double halfPerimeter = Perimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        private double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Square is {Math.Round(Square(), 2)} m2");
            Console.WriteLine($"Perimeter is {Math.Round(Perimeter(), 2)} m2");
        }
    }
}
