using CoffeHouseManagerSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouseManagerSimulator.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        // Her manager dosyamızda ortak olan operasyonları burada biçimlendiriyoruz.
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to database.\nİlk kahveniz ücretsiz. Afiyet olsun. {0} {1}", customer.FirstName, customer.LastName);
        }
    }
}
