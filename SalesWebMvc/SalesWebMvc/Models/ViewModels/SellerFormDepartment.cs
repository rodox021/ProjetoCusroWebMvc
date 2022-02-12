using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormDepartment
    {
        public ICollection<Seller> Sellers { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
