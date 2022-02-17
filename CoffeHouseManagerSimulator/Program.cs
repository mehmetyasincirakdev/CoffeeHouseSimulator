using CoffeHouseManagerSimulator.Abstract;
using CoffeHouseManagerSimulator.Adapter;
using CoffeHouseManagerSimulator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouseManagerSimulator
{
    internal class Program
    {
        //Müşteri bilgilerimizi girip programın çalışıp çalışmadığını kontrol ediyoruz.
        static void Main(string[] args)
        {
            BaseCustomerManager manager = new StarbucksCustomerManager(new MernisServisAdapter());
            manager.Save(new Entities.Customer
            {
                CustomerId = 1,
                FirstName = "Mehmet Yasin",
                LastName = "Çirak",
                DateofBirth = new DateTime(1996, 08, 11),
                NationalityId = "894564892"
            });
            manager.Save(new Entities.Customer
            {
                CustomerId = 2,
                FirstName = "asdasd",
                LastName = "asdasdasd",
                DateofBirth = new DateTime(1999, 06, 13),
                NationalityId = "00000"
            });
            Console.ReadLine();
        }
    }
}
