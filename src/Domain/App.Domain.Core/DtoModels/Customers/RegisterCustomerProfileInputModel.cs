using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels.Customers
{
    public class RegisterCustomerProfileInputModel
    {
        

        public int? GenderId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime? Birthdate { get; set; }

        public int? CityId { get; set; }

        public string MobileNumber { get; set; } = null!;

        public string BackupMobileNumber { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }

    }
}
