using App.Domain.Core.DtoModels.Customers;
using App.Domain.Core.DtoModels.Experts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Experts.Commands
{
    public interface IRegisterExpertProfileAppService
    {
        int Execute(RegisterExpertProfileInputModel model);
    }
}
