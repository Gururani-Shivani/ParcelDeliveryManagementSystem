using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelDeliveryBusinessLogic.Properties
{
    public interface IOrganization
    {
        IList<Department> Departments { get; set; }
        IList<Department> GetSignerDepartments();
        IList<Department> GetProcessorDepartments();
    }
}
