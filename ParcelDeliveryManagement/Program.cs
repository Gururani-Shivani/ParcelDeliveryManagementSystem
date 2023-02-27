
using ParcelDeliveryBusinessLogic.Services;
using ParcelDeliveryBusinessLogic.Properties;
using ParcelDeliveryBusinessLogic.Processor;
using System.ComponentModel;
using Unity;

namespace ParcelDist.ConsoleApp
{
    class program
    {
        const string XmlFilePath = "Files/Container.xml";
        static void Main(string[] args)
        {
            var parContainer = XMLUtility.LoadXml<ParContainer>(XmlFilePath);
            var container = new UnityContainer();
            container.RegisterType<IOrganization, Organization>();
            var organization = container.Resolve<IOrganization>();
            organization.Departments = new List<Department> { new InsuranceDepartment(), new EmailDepartment(), new RegularDepartment(), new HeavyDepartment(), new AddDepartment() };
            //var defaultOrganization = CreateOrganization();

            Console.WriteLine($"************** {parContainer.Parcels.Count} Parcels is ready to process **************");
            Process(organization, parContainer);

            Console.WriteLine();
            Console.WriteLine("*************************     Done!    *************************");


        }

        private static void Process(IOrganization organization, ParContainer container)
        {
            var service = new ParcelDistributionService();

            foreach (var parcel in container.Parcels)
            {
                service.Send(organization, parcel);

                Thread.Sleep(3000);//Just for simulation
            }
        }
        private static IOrganization CreateOrganization(IOrganization organization)
       {
            return organization;
//            return new Organization
//            {
//                Departments = new List<Department>
//                {
//                    new InsuranceDepartment(),
//                    new EmailDepartment(),
//                    new RegularDepartment(),
//                    new HeavyDepartment(),
//                    new AddDepartment()
//                }
//};
        }
    }
}

