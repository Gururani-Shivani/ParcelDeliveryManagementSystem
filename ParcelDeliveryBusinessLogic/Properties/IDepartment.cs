using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelDeliveryBusinessLogic.Properties
{
    public interface IDepartment
    {
        bool Evaluate(Parcel parcel);

    }
}
