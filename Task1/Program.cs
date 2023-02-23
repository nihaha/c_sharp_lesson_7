using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте программу в которой создайте класс «Адрес». 
 * В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс. 
 * Для каждого поля, создать свойство с двумя методами доступа. Также в классе необходимо 
 * создать метод для отображения информации про адрес. В методе Main() создайте экземпляр 
 * класса «Адрес», присвойте всем полям значение через свойства доступа, а также на экземпляр 
 * класса вызовите метод, который выводит информацию про адрес.
 */
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Khreschatyk";
            address.Building = "1A";
            address.Apartment = "48";
            address.ZipCode = "01001";

            address.ShowAddress();

            Console.ReadLine();
        }
    }

    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Apartment { get; set; }
        public string ZipCode { get; set; }

        public void ShowAddress()
        {
            Console.WriteLine($"Full address: {Country}, {City}, {Street} Str., bld. {Building}, ap. {Apartment}, {ZipCode}");
        }
    }
}
