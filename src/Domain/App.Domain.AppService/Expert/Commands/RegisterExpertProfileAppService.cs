using App.Domain.Core.AppServices.Experts.Commands;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels.Experts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Expert.Commands
{
    public class RegisterExpertProfileAppService : IRegisterExpertProfileAppService
    {
        private readonly IExpertRepository _expertRepository;

        public RegisterExpertProfileAppService(IExpertRepository expertRepository)
        {
            _expertRepository = expertRepository;
        }

        public int Execute(RegisterExpertProfileInputModel model)
        {
            // step-1 : add data of customer
            // step-2 : get list of city 
            // step-3 : set cityid to customer 
            // step-4 : return customer id rihgt now is 0
            return 0;
        }
    }
}
