using App.Domain.Core.AppServices.Customers.Commands;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Customers.Commands
{
    public class RegisterCustomerProfileAppService : IRegisterCustomerProfileAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public RegisterCustomerProfileAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public int Execute(RegisterCustomerProfileInputModel model)
        {
            // step-1 : add data of customer
            // step-2 : get list of city 
            // step-3 : set cityid to customer 
            // step-4 : return customer id rihgt now is 0
            return 0;
        }
    }
}
