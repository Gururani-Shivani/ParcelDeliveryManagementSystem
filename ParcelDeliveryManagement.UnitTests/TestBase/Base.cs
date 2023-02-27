using ParcelDeliveryBusinessLogic.Properties;
using ParcelDeliveryBusinessLogic.Services;


namespace ParcelDeliveryManagement.UnitTests.TestBase
{
    public abstract class Base
    {
        protected SampleData SampleData { get; set; }

        protected Base()
        {
            SampleData = new SampleData();
        }

        protected ParcelDeliveryResult Send(Parcel parcel)
        {
            var distributionService = new ParcelDistributionService();

            return distributionService.Send(SampleData.SampleOrganization, parcel);
        }
}
}
