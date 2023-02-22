using ParcelDeliveryBusinessLogic.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ParcelDeliveryBusinessLogic.Services
{
    public class ParcelDeliveryResult
    {

        public ParcelDeliveryResult()
        {
            ParcelDepartmentsFlow = new List<Department>();
        }
        public bool IsSent { get; set; }
        public List<Department> ParcelDepartmentsFlow { get; set; }
    }
}

