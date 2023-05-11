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
    public class EditExpertProfileAppService : IEditExpertProfileAppService
    {
        private readonly IExpertRepository _expertRepository;

        public EditExpertProfileAppService(IExpertRepository expertRepository)
        {
            _expertRepository = expertRepository;
        }

        public int Execute(EditExpertInputModel model)
        {
            // step-1 : get id of expert
            // step-2 : set data to expert 
            // step-3 : get list of city
            // step-3 : set cityid to expert 
            // step-4 : return expert id rihgt now is 0
            return 0;
        }
    }
}
