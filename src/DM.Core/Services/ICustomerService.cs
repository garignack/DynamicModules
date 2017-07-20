using System.Collections.Generic;
using VTX.Core.Model;

namespace VTX.Core.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
    }
}
