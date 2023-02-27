using System.Collections.Generic;
using System.Linq;

namespace ParcelDeliveryBusinessLogic.Properties
{
    public class Organization : IOrganization
    {

        public IList<Department> Departments { get; set; }

        public IList<Department> GetSignerDepartments()
        {
            return Departments.Where(x => x is IParcelSig).ToList();

        }

        public IList<Department> GetProcessorDepartments()
        {
            return Departments.Where(x => x is IParcelProcess).ToList();
        }

    }
}
