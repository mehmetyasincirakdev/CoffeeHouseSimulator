using CoffeHouseManagerSimulator.Abstract;
using CoffeHouseManagerSimulator.Entities;
using CoffeHouseManagerSimulator.MernisServisReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouseManagerSimulator.Adapter
{
    public class MernisServisAdapter : ICustomerCheckService
    {
        // Mernis servisine bağlanıp servisin hangi bilgileri karşılatıracağını bildiriyoruz.
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(customer.NationalityId),
                customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.DateofBirth.Year
                );
        }
    }
}
