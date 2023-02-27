using ParcelDeliveryBusinessLogic.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelDeliveryBusinessLogic.Services
{
    public class ParcelDistributionService
    {
        public ParcelDeliveryResult Send(IOrganization organization, Parcel parcel)
        {
            var result = new ParcelDeliveryResult();

            var signers = organization.GetSignerDepartments();

            var processors = organization.GetProcessorDepartments();


            var signerDepartment = signers.FirstOrDefault(d => d.Evaluate(parcel));
            if (signerDepartment != null)
            {
                ((IParcelSig)signerDepartment).SignOff(parcel);

                result.ParcelDepartmentsFlow.Add(signerDepartment);
            }

            var processorDepartment = processors.FirstOrDefault(d => d.Evaluate(parcel));
            if (processorDepartment != null)
            {
                ((IParcelProcess)processorDepartment).Process(parcel);

                result.ParcelDepartmentsFlow.Add(processorDepartment);
            }

            result.IsSent = true;

            return result;
        }
    }
}

