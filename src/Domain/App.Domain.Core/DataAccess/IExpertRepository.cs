using App.Domain.Core.DtoModels.Customers;
using App.Domain.Core.DtoModels.Experts;

namespace App.Domain.Core.DataAccess;

public interface IExpertRepository
{
    int RegisterCustomerProfile(RegisterExpertProfileInputModel model);
    int EditExpertProfile(EditExpertInputModel model);
}