using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте программу в которой создайте класс «Котенок». 
 * В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз. Для каждого 
 * поля, создать свойство с двумя методами доступа. Также в теле класса создайте метод, который 
 * будет выводить на консоль «Мяу», метод должен принимать один аргумент – количество «Мяу» 
 * котенка, выводить «Мяу» соответствующее количество раз. В методе Main() создайте экземпляр 
 * класса «Котенок», присвойте всем полям значение через свойства доступа, а также вызовите 
 * метод с помощью которого котенок говорит «Мяу», в качестве аргумента метода передайте 3.
 */
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitten kitten = new Kitten();
            kitten.Name = "Test Kitten";
            kitten.Age = 4;
            kitten.FurColor = "white";
            kitten.EyesColor = "yellow";
            kitten.Meow(3);

            Console.ReadLine();
        }

        class Kitten
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string FurColor { get; set; }
            public string EyesColor { get; set; }

            public void Meow(int times)
            {
                for (int i = 0;i < times; i++)
                {
                    Console.WriteLine("Meow");
                }                
            }
        }
    }
}
